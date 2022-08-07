//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSessionViewModel
     /// </summary>
    public partial class AssessmentParticipantSessionViewModel : ViewModelBase, Interfaces.IAssessmentParticipantSessionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentParticipantSession";

        // member variable for the ActualStartDateTime property
        private System.DateTime? _ActualStartDateTime;

        // member variable for the ActualEndDateTime property
        private System.DateTime? _ActualEndDateTime;

        // member variable for the TimeAssessed property
        private System.String _TimeAssessed;

        // member variable for the RefAssessmentPlatformTypeId property
        private Guid? _RefAssessmentPlatformTypeId;

        // member variable for the DeliveryDeviceDetails property
        private System.String _DeliveryDeviceDetails;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private Guid? _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

        // member variable for the LocationId property
        private Guid? _LocationId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the AssessmentFormSectionId property
        private Guid? _AssessmentFormSectionId;

        // member variable for the AssessmentSessionId property
        private Guid _AssessmentSessionId;

        // member variable for the AssessmentRegistrationId property
        private Guid? _AssessmentRegistrationId;

        // member variable for the AssessmentParticipantSessionDatabaseName property
        private System.String _AssessmentParticipantSessionDatabaseName;

        // member variable for the AssessmentParticipantSessionGUID property
        private System.String _AssessmentParticipantSessionGUID;

        // member variable for the PlatformUserAgent property
        private System.String _PlatformUserAgent;

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
        /// The title of the AssessmentParticipantSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        public System.String TimeAssessed  { get => _TimeAssessed; set => SetProperty(ref _TimeAssessed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentPlatformTypeId { get => _RefAssessmentPlatformTypeId; set => SetProperty(ref _RefAssessmentPlatformTypeId, value); }

        public System.String DeliveryDeviceDetails  { get => _DeliveryDeviceDetails; set => SetProperty(ref _DeliveryDeviceDetails, value); }

        public System.String SecurityIssue  { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        public System.String SpecialEventDescription  { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid? LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid? AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSessionId"/> model
        /// </summary>
        public Guid AssessmentSessionId { get => _AssessmentSessionId; set => SetProperty(ref _AssessmentSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        public System.String AssessmentParticipantSessionDatabaseName  { get => _AssessmentParticipantSessionDatabaseName; set => SetProperty(ref _AssessmentParticipantSessionDatabaseName, value); }

        public System.String AssessmentParticipantSessionGUID  { get => _AssessmentParticipantSessionGUID; set => SetProperty(ref _AssessmentParticipantSessionGUID, value); }

        public System.String PlatformUserAgent  { get => _PlatformUserAgent; set => SetProperty(ref _PlatformUserAgent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualStartDateTime = model.ActualStartDateTime;
            ActualEndDateTime = model.ActualEndDateTime;
            TimeAssessed = model.TimeAssessed;
            RefAssessmentPlatformTypeId = model.RefAssessmentPlatformTypeId;
            DeliveryDeviceDetails = model.DeliveryDeviceDetails;
            SecurityIssue = model.SecurityIssue;
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId;
            SpecialEventDescription = model.SpecialEventDescription;
            LocationId = model.LocationId;
            RefLanguageId = model.RefLanguageId;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentSessionId = model.AssessmentSessionId;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssessmentParticipantSessionDatabaseName = model.AssessmentParticipantSessionDatabaseName;
            AssessmentParticipantSessionGUID = model.AssessmentParticipantSessionGUID;
            PlatformUserAgent = model.PlatformUserAgent;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
