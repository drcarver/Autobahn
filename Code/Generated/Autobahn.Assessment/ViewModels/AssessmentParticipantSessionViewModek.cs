//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentParticipantSessionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentParticipantSessionViewModel
     /// </summary>
    public partial class AssessmentParticipantSessionViewModel : BindableBase, IAssessmentParticipantSession
    {
#region "Backing Fields"
        // member variable for the ActualStartDateTime property
        private System.DateTime? _ActualStartDateTime;

        // member variable for the ActualEndDateTime property
        private System.DateTime? _ActualEndDateTime;

        // member variable for the TimeAssessed property
        private System.String _TimeAssessed;

        // member variable for the DeliveryDeviceDetails property
        private System.String _DeliveryDeviceDetails;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private System.String _SpecialEventDescription;

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

#endregion

#region Properties
        public System.DateTime? ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        public System.DateTime? ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        public System.String TimeAssessed  { get => _TimeAssessed; set => SetProperty(ref _TimeAssessed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentPlatformTypeId { get; set; }

        public System.String DeliveryDeviceDetails  { get => _DeliveryDeviceDetails; set => SetProperty(ref _DeliveryDeviceDetails, value); }

        public System.String SecurityIssue  { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        public System.String SpecialEventDescription  { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSectionId"/> model
        /// </summary>
        public Guid? AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSessionId"/> model
        /// </summary>
        public Guid AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        public System.String AssessmentParticipantSessionDatabaseName  { get => _AssessmentParticipantSessionDatabaseName; set => SetProperty(ref _AssessmentParticipantSessionDatabaseName, value); }

        public System.String AssessmentParticipantSessionGUID  { get => _AssessmentParticipantSessionGUID; set => SetProperty(ref _AssessmentParticipantSessionGUID, value); }

        public System.String PlatformUserAgent  { get => _PlatformUserAgent; set => SetProperty(ref _PlatformUserAgent, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentParticipantSession model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
