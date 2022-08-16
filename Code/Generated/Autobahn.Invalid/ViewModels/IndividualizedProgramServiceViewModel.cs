//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServiceViewModel
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : ViewModelBase, Interfaces.IIndividualizedProgramService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramService";

        // member variable for the PlannedServiceDuration property
        private  _PlannedServiceDuration;

        // member variable for the PlannedServiceStartDate property
        private Guid? _PlannedServiceStartDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIndividualizedProgramPlannedServiceTypeId property
        private  _RefIndividualizedProgramPlannedServiceTypeId;

        // member variable for the RefMethodOfServiceDeliveryId property
        private  _RefMethodOfServiceDeliveryId;

        // member variable for the RefServiceFrequencyId property
        private  _RefServiceFrequencyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  PlannedServiceDuration { get => _PlannedServiceDuration; set => SetProperty(ref _PlannedServiceDuration, value); }

        /// <summary>
        /// </summary>
        public Guid? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceType"/> model
        /// </summary>
        public  RefIndividualizedProgramPlannedServiceTypeId { get => _RefIndividualizedProgramPlannedServiceTypeId; set => SetProperty(ref _RefIndividualizedProgramPlannedServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDelivery"/> model
        /// </summary>
        public  RefMethodOfServiceDeliveryId { get => _RefMethodOfServiceDeliveryId; set => SetProperty(ref _RefMethodOfServiceDeliveryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequency"/> model
        /// </summary>
        public  RefServiceFrequencyId { get => _RefServiceFrequencyId; set => SetProperty(ref _RefServiceFrequencyId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramService model)
        {
            IsBusy = true;
            Id = model.Id;
            PlannedServiceDuration = model.PlannedServiceDuration; // 
            PlannedServiceStartDate = model.PlannedServiceStartDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId; // 
            RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId; // 
            RefServiceFrequencyId = model.RefServiceFrequencyId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
