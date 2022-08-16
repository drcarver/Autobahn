//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFundsViewModel
     /// </summary>
    public partial class K12SeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12SeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFunds";

        // member variable for the DateStateReceivedTitleIIIAllocation property
        private  _DateStateReceivedTitleIIIAllocation;

        // member variable for the DateTitleIIIFundsAvailableToSubgrantees property
        private  _DateTitleIIIFundsAvailableToSubgrantees;

        // member variable for the NumberOfDaysForTitleIIISubgrants property
        private  _NumberOfDaysForTitleIIISubgrants;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StateTransferabilityOfFunds property
        private Guid? _StateTransferabilityOfFunds;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DateStateReceivedTitleIIIAllocation { get => _DateStateReceivedTitleIIIAllocation; set => SetProperty(ref _DateStateReceivedTitleIIIAllocation, value); }

        /// <summary>
        /// </summary>
        public  DateTitleIIIFundsAvailableToSubgrantees { get => _DateTitleIIIFundsAvailableToSubgrantees; set => SetProperty(ref _DateTitleIIIFundsAvailableToSubgrantees, value); }

        /// <summary>
        /// </summary>
        public  NumberOfDaysForTitleIIISubgrants { get => _NumberOfDaysForTitleIIISubgrants; set => SetProperty(ref _NumberOfDaysForTitleIIISubgrants, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? StateTransferabilityOfFunds { get => _StateTransferabilityOfFunds; set => SetProperty(ref _StateTransferabilityOfFunds, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            DateStateReceivedTitleIIIAllocation = model.DateStateReceivedTitleIIIAllocation; // 
            DateTitleIIIFundsAvailableToSubgrantees = model.DateTitleIIIFundsAvailableToSubgrantees; // 
            NumberOfDaysForTitleIIISubgrants = model.NumberOfDaysForTitleIIISubgrants; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StateTransferabilityOfFunds = model.StateTransferabilityOfFunds; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
