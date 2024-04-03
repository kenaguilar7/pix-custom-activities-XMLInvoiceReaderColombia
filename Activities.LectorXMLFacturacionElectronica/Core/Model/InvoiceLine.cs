using System.Xml.Serialization;

namespace Activities.LectorXMLFacturacionElectronica.Core.Model
{
    public class InvoiceLine
    {
        //[XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public ID ID { get; set; }

        //[XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public Note Note { get; set; }

        [XmlElement("InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Quantity InvoicedQuantity { get; set; }

        [XmlElement("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount LineExtensionAmount { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotal TaxTotal { get; set; }

        [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public WithholdingTaxTotal WithholdingTaxTotal { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Item Item { get; set; }

        [XmlElement("Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Price Price { get; set; }
    }

    public class Item
    {
        [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Description { get; set; }

        //[XmlElement("StandardItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public StandardItemIdentification StandardItemIdentification { get; set; }
    }
    public class ID
    {
        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class Note
    {
        [XmlAttribute("languageLocaleID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string LanguageLocaleID { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
    //public class StandardItemIdentification
    //{
    //    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    //    public ID ID { get; set; }
    //}

    public class Price
    {
        [XmlElement("PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount PriceAmount { get; set; }

        [XmlElement("BaseQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Quantity BaseQuantity { get; set; }
    }




    public class Quantity
    {
        [XmlAttribute("unitCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UnitCode { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class TaxTotal
    {
        [XmlElement("TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount TaxAmount { get; set; }

        [XmlElement("RoundingAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount RoundingAmount { get; set; }

        [XmlElement("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxSubtotal TaxSubtotal { get; set; }
    }

    public class WithholdingTaxTotal
    {
        [XmlElement("TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount TaxAmount { get; set; }

        [XmlElement("TaxEvidenceIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public bool TaxEvidenceIndicator { get; set; }

        [XmlElement("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxSubtotal TaxSubtotal { get; set; }
    }

    public class TaxSubtotal
    {
        [XmlElement("TaxableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount TaxableAmount { get; set; }

        [XmlElement("TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount TaxAmount { get; set; }

        [XmlElement("TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxCategory TaxCategory { get; set; }
    }

    public class TaxCategory
    {
        [XmlElement("Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal Percent { get; set; }

        [XmlElement("TaxScheme")]
        public TaxScheme TaxScheme { get; set; }
    }


    public class Amount
    {
        [XmlAttribute("currencyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CurrencyID { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }
}
