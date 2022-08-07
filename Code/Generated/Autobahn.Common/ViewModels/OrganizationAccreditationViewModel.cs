//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationAccreditationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationAccreditationViewModel
     /// </summary>
    public partial class OrganizationAccreditationViewModel : ViewModelBase, Interfaces.IOrganizationAccreditationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationAccreditation";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the AccreditationStatus property
        private System.Boolean? _AccreditationStatus;

        // member variable for the RefAccreditationAgencyId property
        private Guid? _RefAccreditationAgencyId;

        // member variable for the AccreditationAwardDate property
        private System.DateTime? _AccreditationAwardDate;

        // member variable for the AccreditationExpirationDate property
        private System.DateTime? _AccreditationExpirationDate;

        // member variable for the SeekingAccreditationDate property
        private System.DateTime? _SeekingAccreditationDate;

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the AccreditationAgencyName property
        private System.String _AccreditationAgencyName;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationAccreditationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Boolean? AccreditationStatus { get => _AccreditationStatus; set => SetProperty(ref _AccreditationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccreditationAgencyId"/> model
        /// </summary>
        public Guid? RefAccreditationAgencyId { get => _RefAccreditationAgencyId; set => SetProperty(ref _RefAccreditationAgencyId, value); }

        public System.DateTime? AccreditationAwardDate { get => _AccreditationAwardDate; set => SetProperty(ref _AccreditationAwardDate, value); }

        public System.DateTime? AccreditationExpirationDate { get => _AccreditationExpirationDate; set => SetProperty(ref _AccreditationExpirationDate, value); }

        public System.DateTime? SeekingAccreditationDate { get => _SeekingAccreditationDate; set => SetProperty(ref _SeekingAccreditationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatusId"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        public System.String AccreditationAgencyName  { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationAccreditation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AccreditationStatus = model.AccreditationStatus;
            RefAccreditationAgencyId = model.RefAccreditationAgencyId;
            AccreditationAwardDate = model.AccreditationAwardDate;
            AccreditationExpirationDate = model.AccreditationExpirationDate;
            SeekingAccreditationDate = model.SeekingAccreditationDate;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId;
            AccreditationAgencyName = model.AccreditationAgencyName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
