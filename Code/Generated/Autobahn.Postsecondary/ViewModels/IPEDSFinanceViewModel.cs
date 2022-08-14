//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The IPEDSFinanceViewModel
     /// </summary>
    public partial class IPEDSFinanceViewModel : ViewModelBase, Interfaces.IIPEDSFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IPEDSFinance";

        // member variable for the OrganizationFinancialId property
        private Guid _OrganizationFinancialId;

        // member variable for the RefIPEDSFASBFinancialPositionId property
        private Guid? _RefIPEDSFASBFinancialPositionId;

        // member variable for the RefIPEDSFASBFunctionalExpenseId property
        private Guid? _RefIPEDSFASBFunctionalExpenseId;

        // member variable for the RefIPEDSFASBPellGrantTransactionsId property
        private Guid? _RefIPEDSFASBPellGrantTransactionsId;

        // member variable for the RefIPEDSFASBRevenueId property
        private Guid? _RefIPEDSFASBRevenueId;

        // member variable for the RefIPEDSFASBRevenueRestrictionId property
        private Guid? _RefIPEDSFASBRevenueRestrictionId;

        // member variable for the RefIPEDSFASBScholarshipsandFellowshipsRevenueId property
        private Guid? _RefIPEDSFASBScholarshipsandFellowshipsRevenueId;

        // member variable for the RefIPEDSGASBFinancialPositionId property
        private Guid? _RefIPEDSGASBFinancialPositionId;

        // member variable for the RefIPEDSGASBFunctionalExpenseId property
        private Guid? _RefIPEDSGASBFunctionalExpenseId;

        // member variable for the RefIPEDSGASBRevenueId property
        private Guid? _RefIPEDSGASBRevenueId;

        // member variable for the RefIPEDSGASBScholarshipsandFellowshipsRevenueId property
        private Guid? _RefIPEDSGASBScholarshipsandFellowshipsRevenueId;

        // member variable for the RefIPEDSIntercollegiateAthleticsExpensesId property
        private Guid? _RefIPEDSIntercollegiateAthleticsExpensesId;

        // member variable for the RefIPEDSNaturalExpenseId property
        private Guid? _RefIPEDSNaturalExpenseId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IPEDSFinanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationFinancial"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get => _OrganizationFinancialId; set => SetProperty(ref _OrganizationFinancialId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFinancialPosition"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFinancialPositionId { get => _RefIPEDSFASBFinancialPositionId; set => SetProperty(ref _RefIPEDSFASBFinancialPositionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get => _RefIPEDSFASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSFASBFunctionalExpenseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get => _RefIPEDSFASBPellGrantTransactionsId; set => SetProperty(ref _RefIPEDSFASBPellGrantTransactionsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueId { get => _RefIPEDSFASBRevenueId; set => SetProperty(ref _RefIPEDSFASBRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueRestriction"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueRestrictionId { get => _RefIPEDSFASBRevenueRestrictionId; set => SetProperty(ref _RefIPEDSFASBRevenueRestrictionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSFASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSFASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFinancialPosition"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFinancialPositionId { get => _RefIPEDSGASBFinancialPositionId; set => SetProperty(ref _RefIPEDSGASBFinancialPositionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFunctionalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFunctionalExpenseId { get => _RefIPEDSGASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSGASBFunctionalExpenseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSGASBRevenueId { get => _RefIPEDSGASBRevenueId; set => SetProperty(ref _RefIPEDSGASBRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSGASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSGASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get => _RefIPEDSIntercollegiateAthleticsExpensesId; set => SetProperty(ref _RefIPEDSIntercollegiateAthleticsExpensesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSNaturalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSNaturalExpenseId { get => _RefIPEDSNaturalExpenseId; set => SetProperty(ref _RefIPEDSNaturalExpenseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIPEDSFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationFinancialId = model.OrganizationFinancialId;
            RefIPEDSFASBFinancialPositionId = model.RefIPEDSFASBFinancialPositionId;
            RefIPEDSFASBFunctionalExpenseId = model.RefIPEDSFASBFunctionalExpenseId;
            RefIPEDSFASBPellGrantTransactionsId = model.RefIPEDSFASBPellGrantTransactionsId;
            RefIPEDSFASBRevenueId = model.RefIPEDSFASBRevenueId;
            RefIPEDSFASBRevenueRestrictionId = model.RefIPEDSFASBRevenueRestrictionId;
            RefIPEDSFASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSFASBScholarshipsandFellowshipsRevenueId;
            RefIPEDSGASBFinancialPositionId = model.RefIPEDSGASBFinancialPositionId;
            RefIPEDSGASBFunctionalExpenseId = model.RefIPEDSGASBFunctionalExpenseId;
            RefIPEDSGASBRevenueId = model.RefIPEDSGASBRevenueId;
            RefIPEDSGASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSGASBScholarshipsandFellowshipsRevenueId;
            RefIPEDSIntercollegiateAthleticsExpensesId = model.RefIPEDSIntercollegiateAthleticsExpensesId;
            RefIPEDSNaturalExpenseId = model.RefIPEDSNaturalExpenseId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
