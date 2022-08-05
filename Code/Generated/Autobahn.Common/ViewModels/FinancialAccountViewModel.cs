//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAccountViewModel
     /// </summary>
    public partial class FinancialAccountViewModel : ViewModelBase, Interfaces.IFinancialAccount
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccount";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the AccountNumber property
        private System.String _AccountNumber;

        // member variable for the RefFinancialAccountCategoryId property
        private Guid? _RefFinancialAccountCategoryId;

        // member variable for the RefFinancialAccountFundClassificationId property
        private Guid? _RefFinancialAccountFundClassificationId;

        // member variable for the RefFinancialAccountProgramCodeId property
        private Guid? _RefFinancialAccountProgramCodeId;

        // member variable for the RefFinancialAccountBalanceSheetCodeId property
        private Guid? _RefFinancialAccountBalanceSheetCodeId;

        // member variable for the RefFinancialExpenditureFunctionCodeId property
        private Guid? _RefFinancialExpenditureFunctionCodeId;

        // member variable for the RefFinancialExpenditureObjectCodeId property
        private Guid? _RefFinancialExpenditureObjectCodeId;

        // member variable for the FinancialAccountNumber property
        private System.String _FinancialAccountNumber;

        // member variable for the FinancialExpenditureProjectReportingCode property
        private System.Decimal? _FinancialExpenditureProjectReportingCode;

        // member variable for the RefFinancialExpenditureLevelOfInstructionCodeId property
        private Guid? _RefFinancialExpenditureLevelOfInstructionCodeId;

        // member variable for the RefFinancialAccountRevenueCodeId property
        private Guid? _RefFinancialAccountRevenueCodeId;

        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAccountViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String AccountNumber  { get => _AccountNumber; set => SetProperty(ref _AccountNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategoryId"/> model
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get => _RefFinancialAccountCategoryId; set => SetProperty(ref _RefFinancialAccountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassificationId"/> model
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get => _RefFinancialAccountFundClassificationId; set => SetProperty(ref _RefFinancialAccountFundClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get => _RefFinancialAccountProgramCodeId; set => SetProperty(ref _RefFinancialAccountProgramCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get => _RefFinancialAccountBalanceSheetCodeId; set => SetProperty(ref _RefFinancialAccountBalanceSheetCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get => _RefFinancialExpenditureFunctionCodeId; set => SetProperty(ref _RefFinancialExpenditureFunctionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get => _RefFinancialExpenditureObjectCodeId; set => SetProperty(ref _RefFinancialExpenditureObjectCodeId, value); }

        public System.String FinancialAccountNumber  { get => _FinancialAccountNumber; set => SetProperty(ref _FinancialAccountNumber, value); }

        public System.Decimal? FinancialExpenditureProjectReportingCode { get => _FinancialExpenditureProjectReportingCode; set => SetProperty(ref _FinancialExpenditureProjectReportingCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get => _RefFinancialExpenditureLevelOfInstructionCodeId; set => SetProperty(ref _RefFinancialExpenditureLevelOfInstructionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get => _RefFinancialAccountRevenueCodeId; set => SetProperty(ref _RefFinancialAccountRevenueCodeId, value); }

        public System.String FederalProgramCode  { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            Description = model.Description;
            AccountNumber = model.AccountNumber;
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId;
            RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId;
            RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId;
            RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId;
            RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId;
            RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId;
            FinancialAccountNumber = model.FinancialAccountNumber;
            FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode;
            RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId;
            RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId;
            FederalProgramCode = model.FederalProgramCode;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
