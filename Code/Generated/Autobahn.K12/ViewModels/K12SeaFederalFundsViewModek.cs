//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaFederalFundsViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFundsViewModel
     /// </summary>
    public partial class K12SeaFederalFundsViewModel : BindableBase, IK12SeaFederalFunds
    {
#region "Backing Fields"
        // member variable for the StateTransferabilityOfFunds property
        private System.Boolean? _StateTransferabilityOfFunds;

        // member variable for the DateStateReceivedTitleIIIAllocation property
        private System.DateTime? _DateStateReceivedTitleIIIAllocation;

        // member variable for the DateTitleIIIFundsAvailableToSubgrantees property
        private System.DateTime? _DateTitleIIIFundsAvailableToSubgrantees;

        // member variable for the NumberOfDaysForTitleIIISubgrants property
        private System.Decimal? _NumberOfDaysForTitleIIISubgrants;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaId"/> model
        /// </summary>
        public Guid K12SeaId { get; set; }

        public System.Boolean? StateTransferabilityOfFunds { get => _StateTransferabilityOfFunds; set => SetProperty(ref _StateTransferabilityOfFunds, value); }

        public System.DateTime? DateStateReceivedTitleIIIAllocation { get => _DateStateReceivedTitleIIIAllocation; set => SetProperty(ref _DateStateReceivedTitleIIIAllocation, value); }

        public System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get => _DateTitleIIIFundsAvailableToSubgrantees; set => SetProperty(ref _DateTitleIIIFundsAvailableToSubgrantees, value); }

        public System.Decimal? NumberOfDaysForTitleIIISubgrants { get => _NumberOfDaysForTitleIIISubgrants; set => SetProperty(ref _NumberOfDaysForTitleIIISubgrants, value); }

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
        public void Load(IK12SeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SeaId = model.K12SeaId;
            StateTransferabilityOfFunds = model.StateTransferabilityOfFunds;
            DateStateReceivedTitleIIIAllocation = model.DateStateReceivedTitleIIIAllocation;
            DateTitleIIIFundsAvailableToSubgrantees = model.DateTitleIIIFundsAvailableToSubgrantees;
            NumberOfDaysForTitleIIISubgrants = model.NumberOfDaysForTitleIIISubgrants;
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
