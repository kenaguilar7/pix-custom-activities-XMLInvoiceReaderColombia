using System.Xml;
using System.Xml.Serialization;

namespace Activities.LectorXMLFacturacionElectronica.Core.Model
{

    [XmlRoot("AttachedDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2")]
    public class AttachedDocument
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UBLVersionID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CustomizationID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ProfileID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ProfileExecutionID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueTime { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentType { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ParentDocumentID { get; set; }

        [XmlElement(ElementName = "SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SenderParty SenderParty { get; set; }

        [XmlElement("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ReceiverParty ReceiverParty { get; set; }

        [XmlElement("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Attachment Attachment { get; set; }

        [XmlElement("ParentDocumentLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ParentDocumentLineReference ParentDocumentLineReference { get; set; }
    }

    public class ReceiverParty
    {
        [XmlElement("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyTaxScheme PartyTaxScheme { get; set; }
    }

    public class SenderParty
    {
        [XmlElement("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyTaxScheme PartyTaxScheme { get; set; }
    }

    public class PartyTaxScheme
    {
        [XmlElement(ElementName = "RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string RegistrationName { get; set; }

        [XmlElement(ElementName = "CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyID CompanyID { get; set; }

        [XmlElement(ElementName = "TaxLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxLevelCode TaxLevelCode { get; set; }

        [XmlElement(ElementName = "TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxScheme TaxScheme { get; set; }
    }

    public class CompanyID
    {
        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }

        [XmlAttribute("schemeName")]
        public string SchemeName { get; set; }

        [XmlAttribute("schemeAgencyID")]
        public string SchemeAgencyID { get; set; }

        [XmlAttribute("schemeAgencyName")]
        public string SchemeAgencyName { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class TaxLevelCode
    {
        [XmlAttribute("listName")]
        public string ListName { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class TaxScheme
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Name { get; set; }
    }

    public class Attachment
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExternalReference ExternalReference { get; set; }
    }

    public class ExternalReference
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string MimeCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string EncodingCode { get; set; }

        [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public XmlCDataSection Description { get; set; }
    }


    public class ParentDocumentLineReference
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string LineID { get; set; }

        [XmlElement("DocumentReference")]
        public DocumentReference DocumentReference { get; set; }
    }

    public class DocumentReference
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUID UUID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentType { get; set; }

        [XmlElement("Attachment")]
        public Attachment Attachment { get; set; }

        [XmlElement("ResultOfVerification")]
        public ResultOfVerification ResultOfVerification { get; set; }
    }

    public class UUID
    {
        [XmlAttribute("schemeName")]
        public string SchemeName { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class ResultOfVerification
    {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ValidatorID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ValidationResultCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ValidationDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ValidationTime { get; set; }
    }

    // Define other classes as needed based on the structure of your XML.

    // To deserialize this XML into the corresponding C# object:
    // var serializer = new XmlSerializer(typeof(AttachedDocument));
    // AttachedDocument result;
    // using (var reader = new StringReader(xmlContent))
    // {
    //     result = (AttachedDocument)serializer.Deserialize(reader);
    // }

}
