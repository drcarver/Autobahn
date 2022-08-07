//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildServicesApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildServicesApplicationViewModel
     /// </summary>
    public partial class ELChildServicesApplicationViewModel : ViewModelBase, Interfaces.IELChildServicesApplicationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildServicesApplication";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ELApplicationIdentifier property
        private System.String _ELApplicationIdentifier;

        // member variable for the ApplicationDate property
        private System.DateTime? _ApplicationDate;

        // member variable for the ELEnrollmentApplicationDocumentIdentifier property
        private System.String _ELEnrollmentApplicationDocumentIdentifier;

        // member variable for the ELEnrollmentApplicationDocumentName property
        private System.String _ELEnrollmentApplicationDocumentName;

        // member variable for the ELEnrollmentApplicationDocumentType property
        private System.String _ELEnrollmentApplicationDocumentType;

        // member variable for the ELApplicationRequiredDocument property
        private System.Boolean? _ELApplicationRequiredDocument;

        // member variable for the ELEnrollmentApplicationVerificationDate property
        private System.DateTime? _ELEnrollmentApplicationVerificationDate;

        // member variable for the ELEnrollmentApplicationVerificationReasonType property
        private System.String _ELEnrollmentApplicationVerificationReasonType;

        // member variable for the SitePreferenceRank property
        private System.String _SitePreferenceRank;

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
        /// The title of the ELChildServicesApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String ELApplicationIdentifier  { get => _ELApplicationIdentifier; set => SetProperty(ref _ELApplicationIdentifier, value); }

        public System.DateTime? ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        public System.String ELEnrollmentApplicationDocumentIdentifier  { get => _ELEnrollmentApplicationDocumentIdentifier; set => SetProperty(ref _ELEnrollmentApplicationDocumentIdentifier, value); }

        public System.String ELEnrollmentApplicationDocumentName  { get => _ELEnrollmentApplicationDocumentName; set => SetProperty(ref _ELEnrollmentApplicationDocumentName, value); }

        public System.String ELEnrollmentApplicationDocumentType  { get => _ELEnrollmentApplicationDocumentType; set => SetProperty(ref _ELEnrollmentApplicationDocumentType, value); }

        public System.Boolean? ELApplicationRequiredDocument { get => _ELApplicationRequiredDocument; set => SetProperty(ref _ELApplicationRequiredDocument, value); }

        public System.DateTime? ELEnrollmentApplicationVerificationDate { get => _ELEnrollmentApplicationVerificationDate; set => SetProperty(ref _ELEnrollmentApplicationVerificationDate, value); }

        public System.String ELEnrollmentApplicationVerificationReasonType  { get => _ELEnrollmentApplicationVerificationReasonType; set => SetProperty(ref _ELEnrollmentApplicationVerificationReasonType, value); }

        public System.String SitePreferenceRank  { get => _SitePreferenceRank; set => SetProperty(ref _SitePreferenceRank, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildServicesApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ELApplicationIdentifier = model.ELApplicationIdentifier;
            ApplicationDate = model.ApplicationDate;
            ELEnrollmentApplicationDocumentIdentifier = model.ELEnrollmentApplicationDocumentIdentifier;
            ELEnrollmentApplicationDocumentName = model.ELEnrollmentApplicationDocumentName;
            ELEnrollmentApplicationDocumentType = model.ELEnrollmentApplicationDocumentType;
            ELApplicationRequiredDocument = model.ELApplicationRequiredDocument;
            ELEnrollmentApplicationVerificationDate = model.ELEnrollmentApplicationVerificationDate;
            ELEnrollmentApplicationVerificationReasonType = model.ELEnrollmentApplicationVerificationReasonType;
            SitePreferenceRank = model.SitePreferenceRank;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
