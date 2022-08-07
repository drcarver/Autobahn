//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFundsViewModel
     /// </summary>
    public partial class K12SeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12SeaFederalFundsViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFunds";

        // member variable for the K12SeaId property
        private Guid _K12SeaId;

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

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12SeaFederalFundsViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaId"/> model
        /// </summary>
        public Guid K12SeaId { get => _K12SeaId; set => SetProperty(ref _K12SeaId, value); }

        public System.Boolean? StateTransferabilityOfFunds { get => _StateTransferabilityOfFunds; set => SetProperty(ref _StateTransferabilityOfFunds, value); }

        public System.DateTime? DateStateReceivedTitleIIIAllocation { get => _DateStateReceivedTitleIIIAllocation; set => SetProperty(ref _DateStateReceivedTitleIIIAllocation, value); }

        public System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get => _DateTitleIIIFundsAvailableToSubgrantees; set => SetProperty(ref _DateTitleIIIFundsAvailableToSubgrantees, value); }

        public System.Decimal? NumberOfDaysForTitleIIISubgrants { get => _NumberOfDaysForTitleIIISubgrants; set => SetProperty(ref _NumberOfDaysForTitleIIISubgrants, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SeaId = model.K12SeaId;
            StateTransferabilityOfFunds = model.StateTransferabilityOfFunds;
            DateStateReceivedTitleIIIAllocation = model.DateStateReceivedTitleIIIAllocation;
            DateTitleIIIFundsAvailableToSubgrantees = model.DateTitleIIIFundsAvailableToSubgrantees;
            NumberOfDaysForTitleIIISubgrants = model.NumberOfDaysForTitleIIISubgrants;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
