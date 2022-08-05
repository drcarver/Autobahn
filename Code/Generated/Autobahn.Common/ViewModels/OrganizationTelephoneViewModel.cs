//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTelephoneViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTelephoneViewModel
     /// </summary>
    public partial class OrganizationTelephoneViewModel : ViewModelBase, Interfaces.IOrganizationTelephone
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTelephone";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the TelephoneNumber property
        private System.String _TelephoneNumber;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // member variable for the RefInstitutionTelephoneTypeId property
        private Guid? _RefInstitutionTelephoneTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the RefTelephoneNumberListedStatusId property
        private Guid? _RefTelephoneNumberListedStatusId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String TelephoneNumber  { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        public System.Boolean PrimaryTelephoneNumberIndicator  { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneTypeId"/> model
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get => _RefInstitutionTelephoneTypeId; set => SetProperty(ref _RefInstitutionTelephoneTypeId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatusId"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            TelephoneNumber = model.TelephoneNumber;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator;
            RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
