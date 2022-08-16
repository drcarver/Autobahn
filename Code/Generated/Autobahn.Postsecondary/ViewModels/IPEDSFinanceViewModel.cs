//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIPEDSFASBFinancialPositionId property
        private  _RefIPEDSFASBFinancialPositionId;

        // member variable for the RefIPEDSFASBFunctionalExpenseId property
        private Guid? _RefIPEDSFASBFunctionalExpenseId;

        // member variable for the RefIPEDSFASBPellGrantTransactionsId property
        private  _RefIPEDSFASBPellGrantTransactionsId;

        // member variable for the RefIPEDSFASBRevenueId property
        private  _RefIPEDSFASBRevenueId;

        // member variable for the RefIPEDSFASBRevenueRestrictionId property
        private  _RefIPEDSFASBRevenueRestrictionId;

        // member variable for the RefIPEDSFASBScholarshipsandFellowshipsRevenueId property
        private  _RefIPEDSFASBScholarshipsandFellowshipsRevenueId;

        // member variable for the RefIPEDSGASBFinancialPositionId property
        private  _RefIPEDSGASBFinancialPositionId;

        // member variable for the RefIPEDSGASBFunctionalExpenseId property
        private  _RefIPEDSGASBFunctionalExpenseId;

        // member variable for the RefIPEDSGASBRevenueId property
        private  _RefIPEDSGASBRevenueId;

        // member variable for the RefIPEDSGASBScholarshipsandFellowshipsRevenueId property
        private  _RefIPEDSGASBScholarshipsandFellowshipsRevenueId;

        // member variable for the RefIPEDSIntercollegiateAthleticsExpensesId property
        private  _RefIPEDSIntercollegiateAthleticsExpensesId;

        // member variable for the RefIPEDSNaturalExpenseId property
        private  _RefIPEDSNaturalExpenseId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFinancialPosition"/> model
        /// </summary>
        public  RefIPEDSFASBFinancialPositionId { get => _RefIPEDSFASBFinancialPositionId; set => SetProperty(ref _RefIPEDSFASBFinancialPositionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpense"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get => _RefIPEDSFASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSFASBFunctionalExpenseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        public  RefIPEDSFASBPellGrantTransactionsId { get => _RefIPEDSFASBPellGrantTransactionsId; set => SetProperty(ref _RefIPEDSFASBPellGrantTransactionsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenue"/> model
        /// </summary>
        public  RefIPEDSFASBRevenueId { get => _RefIPEDSFASBRevenueId; set => SetProperty(ref _RefIPEDSFASBRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueRestriction"/> model
        /// </summary>
        public  RefIPEDSFASBRevenueRestrictionId { get => _RefIPEDSFASBRevenueRestrictionId; set => SetProperty(ref _RefIPEDSFASBRevenueRestrictionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public  RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSFASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSFASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFinancialPosition"/> model
        /// </summary>
        public  RefIPEDSGASBFinancialPositionId { get => _RefIPEDSGASBFinancialPositionId; set => SetProperty(ref _RefIPEDSGASBFinancialPositionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFunctionalExpense"/> model
        /// </summary>
        public  RefIPEDSGASBFunctionalExpenseId { get => _RefIPEDSGASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSGASBFunctionalExpenseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBRevenue"/> model
        /// </summary>
        public  RefIPEDSGASBRevenueId { get => _RefIPEDSGASBRevenueId; set => SetProperty(ref _RefIPEDSGASBRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBScholarshipsandFellowshipsRevenue"/> model
        /// </summary>
        public  RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSGASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSGASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpenses"/> model
        /// </summary>
        public  RefIPEDSIntercollegiateAthleticsExpensesId { get => _RefIPEDSIntercollegiateAthleticsExpensesId; set => SetProperty(ref _RefIPEDSIntercollegiateAthleticsExpensesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSNaturalExpense"/> model
        /// </summary>
        public  RefIPEDSNaturalExpenseId { get => _RefIPEDSNaturalExpenseId; set => SetProperty(ref _RefIPEDSNaturalExpenseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIPEDSFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIPEDSFASBFinancialPositionId = model.RefIPEDSFASBFinancialPositionId; // 
            RefIPEDSFASBFunctionalExpenseId = model.RefIPEDSFASBFunctionalExpenseId; // 
            RefIPEDSFASBPellGrantTransactionsId = model.RefIPEDSFASBPellGrantTransactionsId; // 
            RefIPEDSFASBRevenueId = model.RefIPEDSFASBRevenueId; // 
            RefIPEDSFASBRevenueRestrictionId = model.RefIPEDSFASBRevenueRestrictionId; // 
            RefIPEDSFASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSFASBScholarshipsandFellowshipsRevenueId; // 
            RefIPEDSGASBFinancialPositionId = model.RefIPEDSGASBFinancialPositionId; // 
            RefIPEDSGASBFunctionalExpenseId = model.RefIPEDSGASBFunctionalExpenseId; // 
            RefIPEDSGASBRevenueId = model.RefIPEDSGASBRevenueId; // 
            RefIPEDSGASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSGASBScholarshipsandFellowshipsRevenueId; // 
            RefIPEDSIntercollegiateAthleticsExpensesId = model.RefIPEDSIntercollegiateAthleticsExpensesId; // 
            RefIPEDSNaturalExpenseId = model.RefIPEDSNaturalExpenseId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
