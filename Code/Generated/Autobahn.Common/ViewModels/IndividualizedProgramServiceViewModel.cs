//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServiceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServiceViewModel
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : ViewModelBase, Interfaces.IIndividualizedProgramService
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramService";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefIndividualizedProgramPlannedServiceTypeId property
        private Guid? _RefIndividualizedProgramPlannedServiceTypeId;

        // member variable for the RefMethodOfServiceDeliveryId property
        private Guid? _RefMethodOfServiceDeliveryId;

        // member variable for the RefServiceFrequencyId property
        private Guid? _RefServiceFrequencyId;

        // member variable for the PlannedServiceDuration property
        private System.Decimal? _PlannedServiceDuration;

        // member variable for the PlannedServiceStartDate property
        private System.DateTime? _PlannedServiceStartDate;

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
        /// The title of the IndividualizedProgramServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get => _RefIndividualizedProgramPlannedServiceTypeId; set => SetProperty(ref _RefIndividualizedProgramPlannedServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDeliveryId"/> model
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get => _RefMethodOfServiceDeliveryId; set => SetProperty(ref _RefMethodOfServiceDeliveryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequencyId"/> model
        /// </summary>
        public Guid? RefServiceFrequencyId { get => _RefServiceFrequencyId; set => SetProperty(ref _RefServiceFrequencyId, value); }

        public System.Decimal? PlannedServiceDuration { get => _PlannedServiceDuration; set => SetProperty(ref _PlannedServiceDuration, value); }

        public System.DateTime? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId;
            RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId;
            RefServiceFrequencyId = model.RefServiceFrequencyId;
            PlannedServiceDuration = model.PlannedServiceDuration;
            PlannedServiceStartDate = model.PlannedServiceStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
