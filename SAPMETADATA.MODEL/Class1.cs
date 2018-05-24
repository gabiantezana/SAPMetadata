using System.Collections.Generic;

namespace SAPMETADATA.MODEL
{
    public class Model
    {
        public List<Company> Companies { get; set; }
        public List<Table> TableList { get; set; }
        public List<Udo> UdoList { get; set; }
    }

    public class Company
    {
        
    }

    public class Table
    {
        public string TableName { get; set; }
        public string TableDescription { get; set; }
        public TableTypes TableType { get; set; }
        public bool Archivable { get; set; }
        public string ArchiveDateField { get; set; }
        public List<Field> FieldList { get; set; }
    }

    public class Field
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public FieldTypes Type { get; set; }
        public FieldSubTypes SubType { get; set; }
        public ValidValues ValidValues { get; set; }
        public string LinkedTable { get; set; }
        public string DefaultValue { get; set; }
        public int EditSize { get; set; }
        public bool Mandatory { get; set; }
        public string LinkedUDO { get; set; }
        public ObjectTypes LinkedSystemObject { get; set; }
    }

    public class Udo 
    {
        public string TableName { get; set; }
        public string Code { get; set; }
        public string LogTableName { get; set; }
        public bool CanCreateDefaultForm { get; set; }
        public UdoObjectType ObjectType { get; set; }
        public string ExtensionName { get; set; }
        public bool CanCancel { get; set; }
        public bool CanDelete { get; set; }
        public bool CanLog { get; set; }
        public bool ManageSeries { get; set; }
        public bool CanFind { get; set; }
        public bool CanYearTransfer { get; set; }
        public string Name { get; set; }
        public bool CanClose { get; set; }
        public bool OverwriteDllfile { get; set; }
        public bool UseUniqueFormType { get; set; }
        public bool CanArchive { get; set; }
        public bool MenuItem { get; set; }
        public string MenuCaption { get; set; }
        public int FatherMenuID { get; set; }
        public int Position { get; set; }
        public string MenuUID { get; set; }
        public bool EnableEnhancedForm { get; set; }
        public bool RebuildEnhancedForm { get; set; }
        public string FormSRF { get; set; }
        public bool CanApprove { get; set; }
        public string TemplateID { get; set; }
    }


    #region ComObjectsTypes

    public class ValidValues
    {
        public string Value { get; set; }
        public string Description { get; set; }
    }

    public enum TableTypes
    {
        bott_NoObject = 0,
        bott_MasterData = 1,
        bott_MasterDataLines = 2,
        bott_Document = 3,
        bott_DocumentLines = 4,
        bott_NoObjectAutoIncrement = 5
    }

    public enum ObjectTypes
    {
        oChartOfAccounts = 1,
        oBusinessPartners = 2,
        oBanks = 3,
        oItems = 4,
        oVatGroups = 5,
        oPriceLists = 6,
        oSpecialPrices = 7,
        oItemProperties = 8,
        oBusinessPartnerGroups = 10,
        oUsers = 12,
        oInvoices = 13,
        oCreditNotes = 14,
        oDeliveryNotes = 15,
        oReturns = 16,
        oOrders = 17,
        oPurchaseInvoices = 18,
        oPurchaseCreditNotes = 19,
        oPurchaseDeliveryNotes = 20,
        oPurchaseReturns = 21,
        oPurchaseOrders = 22,
        oQuotations = 23,
        oIncomingPayments = 24,
        oJournalVouchers = 28,
        oJournalEntries = 30,
        oStockTakings = 31,
        oContacts = 33,
        oCreditCards = 36,
        oCurrencyCodes = 37,
        oPaymentTermsTypes = 40,
        oBankPages = 42,
        oManufacturers = 43,
        oVendorPayments = 46,
        oLandedCostsCodes = 48,
        oShippingTypes = 49,
        oLengthMeasures = 50,
        oWeightMeasures = 51,
        oItemGroups = 52,
        oSalesPersons = 53,
        oCustomsGroups = 56,
        oChecksforPayment = 57,
        oInventoryGenEntry = 59,
        oInventoryGenExit = 60,
        oWarehouses = 64,
        oCommissionGroups = 65,
        oProductTrees = 66,
        oStockTransfer = 67,
        oWorkOrders = 68,
        oCreditPaymentMethods = 70,
        oCreditCardPayments = 71,
        oAlternateCatNum = 73,
        oBudget = 77,
        oBudgetDistribution = 78,
        oMessages = 81,
        oBudgetScenarios = 91,
        oUserDefaultGroups = 93,
        oSalesOpportunities = 97,
        oSalesStages = 101,
        oActivityTypes = 103,
        oActivityLocations = 104,
        oDrafts = 112,
        oDeductionTaxHierarchies = 116,
        oDeductionTaxGroups = 117,
        oAdditionalExpenses = 125,
        oSalesTaxAuthorities = 126,
        oSalesTaxAuthoritiesTypes = 127,
        oSalesTaxCodes = 128,
        oQueryCategories = 134,
        oFactoringIndicators = 138,
        oPaymentsDrafts = 140,
        oAccountSegmentations = 142,
        oAccountSegmentationCategories = 143,
        oWarehouseLocations = 144,
        oForms1099 = 145,
        oInventoryCycles = 146,
        oWizardPaymentMethods = 147,
        oBPPriorities = 150,
        oDunningLetters = 151,
        oUserFields = 152,
        oUserTables = 153,
        oPickLists = 156,
        oPaymentRunExport = 158,
        oUserQueries = 160,
        oMaterialRevaluation = 162,
        oCorrectionPurchaseInvoice = 163,
        oCorrectionPurchaseInvoiceReversal = 164,
        oCorrectionInvoice = 165,
        oCorrectionInvoiceReversal = 166,
        oContractTemplates = 170,
        oEmployeesInfo = 171,
        oCustomerEquipmentCards = 176,
        oWithholdingTaxCodes = 178,
        oBillOfExchangeTransactions = 182,
        oKnowledgeBaseSolutions = 189,
        oServiceContracts = 190,
        oServiceCalls = 191,
        oUserKeys = 193,
        oQueue = 194,
        oSalesForecast = 198,
        oTerritories = 200,
        oIndustries = 201,
        oProductionOrders = 202,
        oDownPayments = 203,
        oPurchaseDownPayments = 204,
        oPackagesTypes = 205,
        oUserObjectsMD = 206,
        oTeams = 211,
        oRelationships = 212,
        oUserPermissionTree = 214,
        oActivityStatus = 217,
        oChooseFromList = 218,
        oFormattedSearches = 219,
        oAttachments2 = 221,
        oUserLanguages = 223,
        oMultiLanguageTranslations = 224,
        oDynamicSystemStrings = 229,
        oHouseBankAccounts = 231,
        oBusinessPlaces = 247,
        oLocalEra = 250,
        oNotaFiscalCFOP = 258,
        oNotaFiscalCST = 259,
        oNotaFiscalUsage = 260,
        oClosingDateProcedure = 261,
        oBPFiscalRegistryID = 278,
        oSalesTaxInvoice = 280,
        oPurchaseTaxInvoice = 281,
        BoRecordset = 300,
        BoRecordsetEx = 301,
        BoBridge = 305,
        oStockTransferDraft = 1179,
        oPurchaseQuotations = 540000006,
        oInventoryTransferRequest = 1250000001,
        oPurchaseRequest = 1470000113
    }

    public enum FieldTypes
    {
        db_Alpha = 0,
        db_Memo = 1,
        db_Numeric = 2,
        db_Date = 3,
        db_Float = 4
    }

    public enum FieldSubTypes
    {
        st_None = 0,
        st_Phone = 35,
        st_Percentage = 37,
        st_Address = 63,
        st_Link = 66,
        st_Image = 73,
        st_Measurement = 77,
        st_Price = 80,
        st_Quantity = 81,
        st_Rate = 82,
        st_Sum = 83,
        st_Time = 84
    }

    public enum UdoObjectType
    {
        boud_MasterData = 1,
        boud_Document = 3
    }
    #endregion 

}
