//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseViewModel
     /// </summary>
    public partial class AssessmentItemResponseViewModel : BindableBase, IAssessmentItemResponse
    {
#region "Backing Fields"
        // member variable for the Value property
        private System.String _Value;

        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        // member variable for the AidSetUsed property
        private System.String _AidSetUsed;

        // member variable for the DescriptiveFeedback property
        private System.String _DescriptiveFeedback;

        // member variable for the ScaffoldingItemFlag property
        private System.Boolean? _ScaffoldingItemFlag;

        // member variable for the HintCount property
        private System.Int32? _HintCount;

        // member variable for the HintIncludedAnswer property
        private System.Boolean? _HintIncludedAnswer;

        // member variable for the Duration property
        private System.TimeSpan? _Duration;

        // member variable for the FirstAttemptDuration property
        private System.TimeSpan? _FirstAttemptDuration;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the SecurityIssue property
        private System.String _SecurityIssue;

        // member variable for the ResultXML property
        private System.String _ResultXML;

        // member variable for the AssessmentItemResponseDescriptiveFeedbackDate property
        private System.DateTime? _AssessmentItemResponseDescriptiveFeedbackDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.String ScoreValue  { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessItemResponseStatusId"/> model
        /// </summary>
        public Guid? RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyStatusId"/> model
        /// </summary>
        public Guid? RefProficiencyStatusId { get; set; }

        public System.String AidSetUsed  { get => _AidSetUsed; set => SetProperty(ref _AidSetUsed, value); }

        public System.String DescriptiveFeedback  { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        public System.Boolean? ScaffoldingItemFlag { get => _ScaffoldingItemFlag; set => SetProperty(ref _ScaffoldingItemFlag, value); }

        public System.Int32? HintCount { get => _HintCount; set => SetProperty(ref _HintCount, value); }

        public System.Boolean? HintIncludedAnswer { get => _HintIncludedAnswer; set => SetProperty(ref _HintIncludedAnswer, value); }

        public System.TimeSpan? Duration { get => _Duration; set => SetProperty(ref _Duration, value); }

        public System.TimeSpan? FirstAttemptDuration { get => _FirstAttemptDuration; set => SetProperty(ref _FirstAttemptDuration, value); }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.String SecurityIssue  { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSessionId"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

        public System.String ResultXML  { get => _ResultXML; set => SetProperty(ref _ResultXML, value); }

        public System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get => _AssessmentItemResponseDescriptiveFeedbackDate; set => SetProperty(ref _AssessmentItemResponseDescriptiveFeedbackDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseScoreStatusId"/> model
        /// </summary>
        public Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

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
        public void Load(IAssessmentItemResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            Value = model.Value;
            ScoreValue = model.ScoreValue;
            RefAssessItemResponseStatusId = model.RefAssessItemResponseStatusId;
            RefProficiencyStatusId = model.RefProficiencyStatusId;
            AidSetUsed = model.AidSetUsed;
            DescriptiveFeedback = model.DescriptiveFeedback;
            ScaffoldingItemFlag = model.ScaffoldingItemFlag;
            HintCount = model.HintCount;
            HintIncludedAnswer = model.HintIncludedAnswer;
            Duration = model.Duration;
            FirstAttemptDuration = model.FirstAttemptDuration;
            StartTime = model.StartTime;
            StartDate = model.StartDate;
            SecurityIssue = model.SecurityIssue;
            AssessmentItemId = model.AssessmentItemId;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
            ResultXML = model.ResultXML;
            AssessmentItemResponseDescriptiveFeedbackDate = model.AssessmentItemResponseDescriptiveFeedbackDate;
            RefAssessmentItemResponseScoreStatusId = model.RefAssessmentItemResponseScoreStatusId;
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
