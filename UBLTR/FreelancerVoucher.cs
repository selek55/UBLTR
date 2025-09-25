using System.Collections.Generic;
using System.Xml.Serialization;
using UBLTR.Invoice;

namespace UBLTR.FreelancerVoucher
{
    /// <summary>
    /// E-Serbest Meslek Makbuzu için GIB'nin dağıttığı herhangi bir XML dokumanı olmadığı için manuel yaratılmış bir dokuman.
    /// </summary>
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FreelancerVoucher-2")]
    [XmlRoot("FreelancerVoucher", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FreelancerVoucher-2", IsNullable = false)]
    public class FreelancerVoucherType //: Library.Interfaces.IDocument
    {
        public FreelancerVoucherType()
        {
            //Xmlns.Add("cac", XmlNamespaceConst.Cac);
            //Xmlns.Add("cbc", XmlNamespaceConst.Cbc);
            Xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            Xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            Xmlns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            Xmlns.Add("ccts", "urn:un:unece:uncefact:documentation:2");

            //Xmlns.Add("ext", XmlNamespaceConst.Ext);
            Xmlns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");

            Xmlns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            Xmlns.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");

            //Xmlns.Add("ds", XmlNamespaceConst.Ds);
            //Xmlns.Add("xades", XmlNamespaceConst.Xades);
            //Xmlns.Add("xsd", XmlNamespaceConst.Xsd);
            //Xmlns.Add("xsi", XmlNamespaceConst.Xsi);

            Xmlns.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            Xmlns.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
            Xmlns.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            Xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:FreelancerVoucher-2");
        }

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns = new XmlSerializerNamespaces();

        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation = $"urn:oasis:names:specification:ubl:schema:xsd:FreelancerVoucher-2 UBL-FreelancerVoucher-2.1.xsd";

        //[XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        //[XmlArrayItem("UBLExtension", IsNullable = true)]
        //public UBLExtensionType[] UBLExtensions { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public UBLVersionIDType UBLVersionID { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public CustomizationIDType CustomizationID { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public ProfileIDType ProfileID { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public ProfileExecutionIDType ProfileExecutionID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public CopyIndicatorType CopyIndicator { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public TaxPointDateType TaxPointDate { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public CreditNoteTypeCodeType CreditNoteTypeCode { get; set; }

        [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<NoteType> Note { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCodeType DocumentCurrencyCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public TaxCurrencyCodeType TaxCurrencyCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public PricingCurrencyCodeType PricingCurrencyCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public PaymentCurrencyCodeType PaymentCurrencyCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public AccountingCostCodeType AccountingCostCode { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public AccountingCostType AccountingCost { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public LineCountNumericType LineCountNumeric { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public BuyerReferenceType BuyerReference { get; set; }

        //[XmlElement("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<PeriodType> InvoicePeriod { get; set; }

        //[XmlElement("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<ResponseType> DiscrepancyResponse { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public OrderReferenceType OrderReference { get; set; }

        //[XmlElement("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<BillingReferenceType> BillingReference { get; set; }

        //[XmlElement("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DocumentReferenceType> DespatchDocumentReference { get; set; }

        //[XmlElement("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DocumentReferenceType> ReceiptDocumentReference { get; set; }

        //[XmlElement("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DocumentReferenceType> ContractDocumentReference { get; set; }

        [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<DocumentReferenceType> AdditionalDocumentReference { get; set; }

        //[XmlElement("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DocumentReferenceType> StatementDocumentReference { get; set; }

        //[XmlElement("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DocumentReferenceType> OriginatorDocumentReference { get; set; }

        //[XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<SignatureType> Signature { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public PartyType PayeeParty { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public CustomerPartyType BuyerCustomerParty { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public SupplierPartyType SellerSupplierParty { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public PartyType TaxRepresentativeParty { get; set; }

        //[XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DeliveryType> Delivery { get; set; }

        //[XmlElement("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<DeliveryTermsType> DeliveryTerms { get; set; }

        //[XmlElement("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<PaymentMeansType> PaymentMeans { get; set; }

        //[XmlElement("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<PaymentTermsType> PaymentTerms { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public ExchangeRateType TaxExchangeRate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public ExchangeRateType PaymentExchangeRate { get; set; }

        //[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }

        //[XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public List<AllowanceChargeType> AllowanceCharge { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal { get; set; }

        // [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        // public TaxTotalType WithholdingTaxTotal { get; set; }

        [XmlElement("FreelancerVoucherLegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public FreelancerMonetaryTotalType LegalMonetaryTotal { get; set; }

        [XmlElement("FreelancerVoucherLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<FreelancerVoucherLineType> FreelancerVoucherLine { get; set; }
    }

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public class FreelancerMonetaryTotalType
    {
        private PriceAmountType _grossWageAmountField;
        private PriceAmountType _priceAmountField;
        private LineExtensionAmountType lineExtensionAmountField;
        private PayableAmountType payableAmountField;

        [System.Xml.Serialization.XmlElementAttribute("GrossWageAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType GrossWageAmountType
        {
            get { return _grossWageAmountField; }
            set { _grossWageAmountField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute("PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType PriceAmountType
        {
            get { return _priceAmountField; }
            set { _priceAmountField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get { return lineExtensionAmountField; }
            set { lineExtensionAmountField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAmountType PayableAmount
        {
            get { return payableAmountField; }
            set { payableAmountField = value; }
        }
    }


    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("FreelancerVoucherLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public class FreelancerVoucherLineType
    {
        private IDType idField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TaxTotalType taxTotalField;

        private System.Collections.Generic.List<AllowanceChargeType> allowanceChargeField;

        private ItemType itemField;

        private GrossWageType _grossWageField;

        private PriceType priceField;

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get { return idField; }
            set { idField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get { return lineExtensionAmountField; }
            set { lineExtensionAmountField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType TaxTotal
        {
            get { return taxTotalField; }
            set { taxTotalField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge
        {
            get { return allowanceChargeField; }
            set { allowanceChargeField = value; }
        }

        public ItemType Item
        {
            get { return itemField; }
            set { itemField = value; }
        }

        public GrossWageType GrossWage
        {
            get { return _grossWageField; }
            set { _grossWageField = value; }
        }

        public PriceType Price
        {
            get { return priceField; }
            set { priceField = value; }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class GrossWageType
    {

        private PriceAmountType grossWageAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType GrossWageAmount
        {
            get
            {
                return this.grossWageAmountField;
            }
            set
            {
                this.grossWageAmountField = value;
            }
        }
    }
}
