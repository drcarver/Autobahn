//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationServiceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationServiceViewModel
     /// </summary>
    public partial class OrganizationServiceViewModel : ViewModelBase, Interfaces.IOrganizationServiceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationService";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid _RefStudentSupportServiceTypeId;

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
        /// The title of the OrganizationServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStudentSupportServiceTypeId"/> model
        /// </summary>
        public Guid RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
