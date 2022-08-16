//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _ActualEndDateTime;

        // member variable for the ActualStartDateTime property
        private  _ActualStartDateTime;

        // member variable for the AssessmentParticipantSessionDatabaseName property
        private  _AssessmentParticipantSessionDatabaseName;

        // member variable for the AssessmentParticipantSessionGUID property
        private  _AssessmentParticipantSessionGUID;

        // member variable for the DeliveryDeviceDetails property
        private  _DeliveryDeviceDetails;

        // member variable for the LocationId property
        private  _LocationId;

        // member variable for the PlatformUserAgent property
        private  _PlatformUserAgent;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentPlatformTypeId property
        private  _RefAssessmentPlatformTypeId;

        // member variable for the RefAssessmentSessionSpecialCircumstanceTypeId property
        private  _RefAssessmentSessionSpecialCircumstanceTypeId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the SecurityIssue property
        private  _SecurityIssue;

        // member variable for the SpecialEventDescription property
        private  _SpecialEventDescription;

        // member variable for the TimeAssessed property
        private  _TimeAssessed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ActualEndDateTime { get => _ActualEndDateTime; set => SetProperty(ref _ActualEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  ActualStartDateTime { get => _ActualStartDateTime; set => SetProperty(ref _ActualStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  AssessmentParticipantSessionDatabaseName { get => _AssessmentParticipantSessionDatabaseName; set => SetProperty(ref _AssessmentParticipantSessionDatabaseName, value); }

        /// <summary>
        /// </summary>
        public  AssessmentParticipantSessionGUID { get => _AssessmentParticipantSessionGUID; set => SetProperty(ref _AssessmentParticipantSessionGUID, value); }

        /// <summary>
        /// </summary>
        public  DeliveryDeviceDetails { get => _DeliveryDeviceDetails; set => SetProperty(ref _DeliveryDeviceDetails, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public  LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// </summary>
        public  PlatformUserAgent { get => _PlatformUserAgent; set => SetProperty(ref _PlatformUserAgent, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPlatformType"/> model
        /// </summary>
        public  RefAssessmentPlatformTypeId { get => _RefAssessmentPlatformTypeId; set => SetProperty(ref _RefAssessmentPlatformTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public  RefAssessmentSessionSpecialCircumstanceTypeId { get => _RefAssessmentSessionSpecialCircumstanceTypeId; set => SetProperty(ref _RefAssessmentSessionSpecialCircumstanceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// </summary>
        public  SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// </summary>
        public  SpecialEventDescription { get => _SpecialEventDescription; set => SetProperty(ref _SpecialEventDescription, value); }

        /// <summary>
        /// </summary>
        public  TimeAssessed { get => _TimeAssessed; set => SetProperty(ref _TimeAssessed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentParticipantSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ActualEndDateTime = model.ActualEndDateTime; // 
            ActualStartDateTime = model.ActualStartDateTime; // 
            AssessmentParticipantSessionDatabaseName = model.AssessmentParticipantSessionDatabaseName; // 
            AssessmentParticipantSessionGUID = model.AssessmentParticipantSessionGUID; // 
            DeliveryDeviceDetails = model.DeliveryDeviceDetails; // 
            LocationId = model.LocationId; // 
            PlatformUserAgent = model.PlatformUserAgent; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentPlatformTypeId = model.RefAssessmentPlatformTypeId; // 
            RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId; // 
            RefLanguageId = model.RefLanguageId; // 
            SecurityIssue = model.SecurityIssue; // 
            SpecialEventDescription = model.SpecialEventDescription; // 
            TimeAssessed = model.TimeAssessed; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
