//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServicesReceivedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServicesReceivedViewModel
     /// </summary>
    public partial class IndividualizedProgramServicesReceivedViewModel : ViewModelBase, Interfaces.IIndividualizedProgramServicesReceived
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramServicesReceived";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ServicesReceivedId property
        private Guid _ServicesReceivedId;

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
        /// The title of the IndividualizedProgramServicesReceivedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceivedId"/> model
        /// </summary>
        public Guid ServicesReceivedId { get => _ServicesReceivedId; set => SetProperty(ref _ServicesReceivedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramServicesReceived model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            ServicesReceivedId = model.ServicesReceivedId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
