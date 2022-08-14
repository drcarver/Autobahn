//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServicesApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildServicesApplicationViewModel
     /// </summary>
    public partial class ELChildServicesApplicationViewModel : ViewModelBase, Interfaces.IELChildServicesApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildServicesApplication";

        // member variable for the ApplicationDate property
        private System.DateTime? _ApplicationDate;

        // member variable for the ELApplicationIdentifier property
        private System.String _ELApplicationIdentifier;

        // member variable for the ELApplicationRequiredDocument property
        private System.Boolean? _ELApplicationRequiredDocument;

        // member variable for the ELEnrollmentApplicationDocumentIdentifier property
        private System.String _ELEnrollmentApplicationDocumentIdentifier;

        // member variable for the ELEnrollmentApplicationDocumentName property
        private System.String _ELEnrollmentApplicationDocumentName;

        // member variable for the ELEnrollmentApplicationDocumentType property
        private System.String _ELEnrollmentApplicationDocumentType;

        // member variable for the ELEnrollmentApplicationVerificationDate property
        private System.DateTime? _ELEnrollmentApplicationVerificationDate;

        // member variable for the ELEnrollmentApplicationVerificationReasonType property
        private System.String _ELEnrollmentApplicationVerificationReasonType;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the SitePreferenceRank property
        private System.String _SitePreferenceRank;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildServicesApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime? ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELApplicationIdentifier { get => _ELApplicationIdentifier; set => SetProperty(ref _ELApplicationIdentifier, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.Boolean? ELApplicationRequiredDocument { get => _ELApplicationRequiredDocument; set => SetProperty(ref _ELApplicationRequiredDocument, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentIdentifier { get => _ELEnrollmentApplicationDocumentIdentifier; set => SetProperty(ref _ELEnrollmentApplicationDocumentIdentifier, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentName { get => _ELEnrollmentApplicationDocumentName; set => SetProperty(ref _ELEnrollmentApplicationDocumentName, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationDocumentType { get => _ELEnrollmentApplicationDocumentType; set => SetProperty(ref _ELEnrollmentApplicationDocumentType, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.DateTime? ELEnrollmentApplicationVerificationDate { get => _ELEnrollmentApplicationVerificationDate; set => SetProperty(ref _ELEnrollmentApplicationVerificationDate, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String ELEnrollmentApplicationVerificationReasonType { get => _ELEnrollmentApplicationVerificationReasonType; set => SetProperty(ref _ELEnrollmentApplicationVerificationReasonType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        public System.String SitePreferenceRank { get => _SitePreferenceRank; set => SetProperty(ref _SitePreferenceRank, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildServicesApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationDate = model.ApplicationDate;
            ELApplicationIdentifier = model.ELApplicationIdentifier;
            ELApplicationRequiredDocument = model.ELApplicationRequiredDocument;
            ELEnrollmentApplicationDocumentIdentifier = model.ELEnrollmentApplicationDocumentIdentifier;
            ELEnrollmentApplicationDocumentName = model.ELEnrollmentApplicationDocumentName;
            ELEnrollmentApplicationDocumentType = model.ELEnrollmentApplicationDocumentType;
            ELEnrollmentApplicationVerificationDate = model.ELEnrollmentApplicationVerificationDate;
            ELEnrollmentApplicationVerificationReasonType = model.ELEnrollmentApplicationVerificationReasonType;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            SitePreferenceRank = model.SitePreferenceRank;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
