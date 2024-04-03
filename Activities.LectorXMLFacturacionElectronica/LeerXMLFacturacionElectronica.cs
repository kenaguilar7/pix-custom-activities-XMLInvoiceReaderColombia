using System;
using BR.Core;
using BR.Core.Attributes;
using Activities.LectorXMLFacturacionElectronica.Properties;
using Activities.LectorXMLFacturacionElectronica.Core.Model;
using System.Text;
using System.Xml.Serialization;

namespace Namespace_LectorXMLFacturacionElectronica
{
    [LocalizableScreenName(nameof(Resources.LeerXMLFacturacionElectronica_ScreenName), typeof(Resources))]
    [BR.Core.Attributes.Path("Facturación Electrónica")]
    public class LeerXMLFacturacionElectronica : BR.Core.Activity
    {
        [LocalizableScreenName(nameof(Resources.Path_XML_ScreenName), typeof(Resources))]
        [LocalizableDescription(nameof(Resources.Path_XML_Description), typeof(Resources))]
        [IsFilePathChooser]
        [IsRequired]
        public System.String XML {get; set;} 
        
        [LocalizableScreenName(nameof(Resources.Documento_Electronico_Out_ScreenName), typeof(Resources))]
        [LocalizableDescription(nameof(Resources.Documento_Electronico_Out_Description), typeof(Resources))]
        [IsOut]
        public Invoice Invoice {get; set;} 
        
        public override void Execute(int? optionID)
        {
            ICommand converter = new Command(XML);
            Invoice = converter.Run(); 
        }
    }

    public interface ICommand 
    {
        Invoice Run(); 
    }

    public class Command : ICommand
    {
        private string _xmlPath; 
        public Command(string xmlPath){ _xmlPath = xmlPath; }
        public Invoice Run()
        {
            if (string.IsNullOrEmpty(_xmlPath)) { throw new DirectoryNotFoundException(nameof(_xmlPath)); }

            XmlSerializer serializer = new XmlSerializer(typeof(AttachedDocument));
            XmlSerializer serializerInvoice = new XmlSerializer(typeof(Invoice));

            var anotherXml = string.Empty;

            using (FileStream fileStream = new(_xmlPath, FileMode.Open))
            {
                // Deserializar el XML y obtener una instancia de la clase
                AttachedDocument instancia = (AttachedDocument)serializer.Deserialize(fileStream);
                anotherXml = instancia.Attachment.ExternalReference.Description.Value;
            }

            using Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(anotherXml));
            try
            {
                return  (Invoice)serializerInvoice.Deserialize(stream);
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
    }
}
