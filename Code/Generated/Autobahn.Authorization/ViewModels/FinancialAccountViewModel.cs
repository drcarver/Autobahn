//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   FinancialAccountViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The FinancialAccountViewModel
     /// </summary>
    public partial class FinancialAccountViewModel : ViewModelBase, Interfaces.IFinancialAccount
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccount";

        // member variable for the AccountNumber property
        private System.String _AccountNumber;

        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // member variable for the FinancialAccountNumber property
        private System.String _FinancialAccountNumber;

        // member variable for the FinancialExpenditureProjectReportingCode property
        private System.Decimal? _FinancialExpenditureProjectReportingCode;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the RefFinancialAccountBalanceSheetCodeId property
        private Guid? _RefFinancialAccountBalanceSheetCodeId;

        // member variable for the RefFinancialAccountCategoryId property
        private Guid? _RefFinancialAccountCategoryId;

        // member variable for the RefFinancialAccountFundClassificationId property
        private Guid? _RefFinancialAccountFundClassificationId;

        // member variable for the RefFinancialAccountProgramCodeId property
        private Guid? _RefFinancialAccountProgramCodeId;

        // member variable for the RefFinancialAccountRevenueCodeId property
        private Guid? _RefFinancialAccountRevenueCodeId;

        // member variable for the RefFinancialExpenditureFunctionCodeId property
        private Guid? _RefFinancialExpenditureFunctionCodeId;

        // member variable for the RefFinancialExpenditureLevelOfInstructionCodeId property
        private Guid? _RefFinancialExpenditureLevelOfInstructionCodeId;

        // member variable for the RefFinancialExpenditureObjectCodeId property
        private Guid? _RefFinancialExpenditureObjectCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAccountViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String AccountNumber { get => _AccountNumber; set => SetProperty(ref _AccountNumber, value); }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String FederalProgramCode { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String FinancialAccountNumber { get => _FinancialAccountNumber; set => SetProperty(ref _FinancialAccountNumber, value); }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.Decimal? FinancialExpenditureProjectReportingCode { get => _FinancialExpenditureProjectReportingCode; set => SetProperty(ref _FinancialExpenditureProjectReportingCode, value); }

        /// <summary>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get => _RefFinancialAccountBalanceSheetCodeId; set => SetProperty(ref _RefFinancialAccountBalanceSheetCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategory"/> model
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get => _RefFinancialAccountCategoryId; set => SetProperty(ref _RefFinancialAccountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassification"/> model
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get => _RefFinancialAccountFundClassificationId; set => SetProperty(ref _RefFinancialAccountFundClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get => _RefFinancialAccountProgramCodeId; set => SetProperty(ref _RefFinancialAccountProgramCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCode"/> model
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get => _RefFinancialAccountRevenueCodeId; set => SetProperty(ref _RefFinancialAccountRevenueCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get => _RefFinancialExpenditureFunctionCodeId; set => SetProperty(ref _RefFinancialExpenditureFunctionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get => _RefFinancialExpenditureLevelOfInstructionCodeId; set => SetProperty(ref _RefFinancialExpenditureLevelOfInstructionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCode"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get => _RefFinancialExpenditureObjectCodeId; set => SetProperty(ref _RefFinancialExpenditureObjectCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountNumber = model.AccountNumber;
            FederalProgramCode = model.FederalProgramCode;
            FinancialAccountNumber = model.FinancialAccountNumber;
            FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode;
            Name = model.Name;
            RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId;
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId;
            RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId;
            RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId;
            RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId;
            RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId;
            RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId;
            RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
