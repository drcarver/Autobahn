//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPEDSFinanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IPEDSFinanceViewModel
     /// </summary>
    public partial class IPEDSFinanceViewModel : BindableBase, IIPEDSFinance
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancialId"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFinancialPositionId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBFunctionalExpenseId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBPellGrantTransactionsId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBRevenueRestrictionId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBRevenueRestrictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenueId"/> model
        /// </summary>
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFinancialPositionId"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFinancialPositionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBFunctionalExpenseId"/> model
        /// </summary>
        public Guid? RefIPEDSGASBFunctionalExpenseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBRevenueId"/> model
        /// </summary>
        public Guid? RefIPEDSGASBRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSGASBScholarshipsandFellowshipsRevenueId"/> model
        /// </summary>
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSIntercollegiateAthleticsExpensesId"/> model
        /// </summary>
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPEDSNaturalExpenseId"/> model
        /// </summary>
        public Guid? RefIPEDSNaturalExpenseId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IIPEDSFinance model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
