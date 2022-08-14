//**********************************************************
//* DomainName: Common Models
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

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // member variable for the RefInstitutionTelephoneTypeId property
        private Guid? _RefInstitutionTelephoneTypeId;

        // member variable for the RefTelephoneNumberListedStatusId property
        private Guid? _RefTelephoneNumberListedStatusId;

        // member variable for the TelephoneNumber property
        private System.String _TelephoneNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstitutionTelephoneType"/> model
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get => _RefInstitutionTelephoneTypeId; set => SetProperty(ref _RefInstitutionTelephoneTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        /// <summary>
        /// The type of communication number listed for an organization.
        /// </summary>
        public System.String TelephoneNumber { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            OrganizationId = model.OrganizationId;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator;
            RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId;
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId;
            TelephoneNumber = model.TelephoneNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
