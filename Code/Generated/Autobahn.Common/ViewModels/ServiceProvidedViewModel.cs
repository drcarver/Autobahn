//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvidedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceProvidedViewModel
     /// </summary>
    public partial class ServiceProvidedViewModel : ViewModelBase, Interfaces.IServiceProvided
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvided";

        // member variable for the ServicesReceivedId property
        private Guid _ServicesReceivedId;

        // member variable for the RefServicesId property
        private Guid? _RefServicesId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

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
        /// The title of the ServiceProvidedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceivedId"/> model
        /// </summary>
        public Guid ServicesReceivedId { get => _ServicesReceivedId; set => SetProperty(ref _ServicesReceivedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServicesId"/> model
        /// </summary>
        public Guid? RefServicesId { get => _RefServicesId; set => SetProperty(ref _RefServicesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceTypeId"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvided model)
        {
            IsBusy = true;
            Id = model.Id;
            ServicesReceivedId = model.ServicesReceivedId;
            RefServicesId = model.RefServicesId;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
