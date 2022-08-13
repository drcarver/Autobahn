//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentParticipantSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSessionViewModel
     /// </summary>
    public partial class AssessmentParticipantSessionViewModel : ViewModelBase, Interfaces.IAssessmentParticipantSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentParticipantSession";

        // member variable for the ActualEndDateTime property
        private System.DateTime? _ActualEndDateTime;

        // member variable for the ActualStartDateTime property
        private System.DateTime? _ActualStartDateTime;

        // member variable for the AssessmentFormSectionId property
        private Guid? _AssessmentFormSectionId;

        // member variable for the AssessmentParticipantSessionDatabaseName property
        private System.String _AssessmentParticipantSessionDatabaseName;

        // member variable for the AssessmentParticipantSessionGUID property
        private System.String _AssessmentParticipantSessionGUID;

        // member variable for the AssessmentRegistrationId property
        private Guid? _AssessmentRegistrationId;

        // member variable for the AssessmentSessionId property
        private Guid _AssessmentSessionId;

        // member variable for the DeliveryDeviceDetails property
        private System.String _DeliveryDeviceDetails;

        // member variable for the LocationId property
        private Guid? _LocationId;

        // member variable for the PlatformUserAgent property
        private System.String _PlatformUserAgent;

        // member variable for the RefAssessmentPlatformTypeId property
        private Guid? _RefAssessmentPlatformTypeId;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private Guid? _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

        // member variable for the TimeAssessed property
        private System.String _TimeAssessed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentParticipantSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid? AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String AssessmentParticipantSessionDatabaseName { get => _AssessmentParticipantSessionDatabaseName; set => SetProperty(ref _AssessmentParticipantSessionDatabaseName, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String AssessmentParticipantSessionGUID { get => _AssessmentParticipantSessionGUID; set => SetProperty(ref _AssessmentParticipantSessionGUID, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        public Guid AssessmentSessionId { get => _AssessmentSessionId; set => SetProperty(ref _AssessmentSessionId, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String DeliveryDeviceDetails { get => _DeliveryDeviceDetails; set => SetProperty(ref _DeliveryDeviceDetails, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public Guid? LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String PlatformUserAgent { get => _PlatformUserAgent; set => SetProperty(ref _PlatformUserAgent, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformType"/> model
        /// </summary>
        public Guid? RefAssessmentPlatformTypeId { get => _RefAssessmentPlatformTypeId; set => SetProperty(ref _RefAssessmentPlatformTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String SpecialEventDescription { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        /// <summary>
        /// The language that the assessment is administered.
        /// </summary>
        public System.String TimeAssessed { get => _TimeAssessed; set => SetProperty(ref _TimeAssessed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualEndDateTime = model.ActualEndDateTime;
            ActualStartDateTime = model.ActualStartDateTime;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentParticipantSessionDatabaseName = model.AssessmentParticipantSessionDatabaseName;
            AssessmentParticipantSessionGUID = model.AssessmentParticipantSessionGUID;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssessmentSessionId = model.AssessmentSessionId;
            DeliveryDeviceDetails = model.DeliveryDeviceDetails;
            LocationId = model.LocationId;
            PlatformUserAgent = model.PlatformUserAgent;
            RefAssessmentPlatformTypeId = model.RefAssessmentPlatformTypeId;
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId;
            RefLanguageId = model.RefLanguageId;
            SecurityIssue = model.SecurityIssue;
            SpecialEventDescription = model.SpecialEventDescription;
            TimeAssessed = model.TimeAssessed;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
