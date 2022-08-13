//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseViewModel
     /// </summary>
    public partial class AssessmentItemResponseViewModel : ViewModelBase, Interfaces.IAssessmentItemResponse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemResponse";

        // member variable for the AidSetUsed property
        private System.String _AidSetUsed;

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the AssessmentItemResponseDescriptiveFeedbackDate property
        private System.DateTime? _AssessmentItemResponseDescriptiveFeedbackDate;

        // member variable for the AssessmentParticipantSessionId property
        private Guid _AssessmentParticipantSessionId;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the Duration property
        private System.TimeSpan? _Duration;

        // member variable for the FirstAttemptDuration property
        private System.TimeSpan? _FirstAttemptDuration;

        // member variable for the HintCount property
        private System.Int32? _HintCount;

        // member variable for the HintIncludedAnswer property
        private System.Boolean? _HintIncludedAnswer;

        // member variable for the RefAssessItemResponseStatusId property
        private Guid? _RefAssessItemResponseStatusId;

        // member variable for the RefAssessmentItemResponseScoreStatusId property
        private Guid? _RefAssessmentItemResponseScoreStatusId;

        // member variable for the RefProficiencyStatusId property
        private Guid? _RefProficiencyStatusId;

        // member variable for the ResultXML property
        private System.String _ResultXML;

        // member variable for the ScaffoldingItemFlag property
        private System.Boolean? _ScaffoldingItemFlag;

        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the Value property
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemResponseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String AidSetUsed { get => _AidSetUsed; set => SetProperty(ref _AidSetUsed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get => _AssessmentItemResponseDescriptiveFeedbackDate; set => SetProperty(ref _AssessmentItemResponseDescriptiveFeedbackDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get => _AssessmentParticipantSessionId; set => SetProperty(ref _AssessmentParticipantSessionId, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? Duration { get => _Duration; set => SetProperty(ref _Duration, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? FirstAttemptDuration { get => _FirstAttemptDuration; set => SetProperty(ref _FirstAttemptDuration, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Int32? HintCount { get => _HintCount; set => SetProperty(ref _HintCount, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Boolean? HintIncludedAnswer { get => _HintIncludedAnswer; set => SetProperty(ref _HintIncludedAnswer, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessItemResponseStatus"/> model
        /// </summary>
        public Guid? RefAssessItemResponseStatusId { get => _RefAssessItemResponseStatusId; set => SetProperty(ref _RefAssessItemResponseStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        public Guid? RefAssessmentItemResponseScoreStatusId { get => _RefAssessmentItemResponseScoreStatusId; set => SetProperty(ref _RefAssessmentItemResponseScoreStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        public Guid? RefProficiencyStatusId { get => _RefProficiencyStatusId; set => SetProperty(ref _RefProficiencyStatusId, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String ResultXML { get => _ResultXML; set => SetProperty(ref _ResultXML, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Boolean? ScaffoldingItemFlag { get => _ScaffoldingItemFlag; set => SetProperty(ref _ScaffoldingItemFlag, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String ScoreValue { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            AidSetUsed = model.AidSetUsed;
            AssessmentItemId = model.AssessmentItemId;
            AssessmentItemResponseDescriptiveFeedbackDate = model.AssessmentItemResponseDescriptiveFeedbackDate;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            DescriptiveFeedback = model.DescriptiveFeedback;
            Duration = model.Duration;
            FirstAttemptDuration = model.FirstAttemptDuration;
            HintCount = model.HintCount;
            HintIncludedAnswer = model.HintIncludedAnswer;
            RefAssessItemResponseStatusId = model.RefAssessItemResponseStatusId;
            RefAssessmentItemResponseScoreStatusId = model.RefAssessmentItemResponseScoreStatusId;
            RefProficiencyStatusId = model.RefProficiencyStatusId;
            ResultXML = model.ResultXML;
            ScaffoldingItemFlag = model.ScaffoldingItemFlag;
            ScoreValue = model.ScoreValue;
            SecurityIssue = model.SecurityIssue;
            StartDate = model.StartDate;
            StartTime = model.StartTime;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
