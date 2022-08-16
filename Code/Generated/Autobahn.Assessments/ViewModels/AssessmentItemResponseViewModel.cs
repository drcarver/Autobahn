//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _AidSetUsed;

        // member variable for the AssessmentItemResponseDescriptiveFeedbackDate property
        private  _AssessmentItemResponseDescriptiveFeedbackDate;

        // member variable for the DescriptiveFeedback property
        private  _DescriptiveFeedback;

        // member variable for the Duration property
        private Guid? _Duration;

        // member variable for the FirstAttemptDuration property
        private  _FirstAttemptDuration;

        // member variable for the HintCount property
        private  _HintCount;

        // member variable for the HintIncludedAnswer property
        private  _HintIncludedAnswer;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessItemResponseStatusId property
        private  _RefAssessItemResponseStatusId;

        // member variable for the RefAssessmentItemResponseScoreStatusId property
        private  _RefAssessmentItemResponseScoreStatusId;

        // member variable for the RefProficiencyStatusId property
        private  _RefProficiencyStatusId;

        // member variable for the ResultXML property
        private  _ResultXML;

        // member variable for the ScaffoldingItemFlag property
        private  _ScaffoldingItemFlag;

        // member variable for the ScoreValue property
        private  _ScoreValue;

        // member variable for the SecurityIssue property
        private  _SecurityIssue;

        // member variable for the StartDate property
        private  _StartDate;

        // member variable for the StartTime property
        private  _StartTime;

        // member variable for the Value property
        private  _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AidSetUsed { get => _AidSetUsed; set => SetProperty(ref _AidSetUsed, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemResponseDescriptiveFeedbackDate { get => _AssessmentItemResponseDescriptiveFeedbackDate; set => SetProperty(ref _AssessmentItemResponseDescriptiveFeedbackDate, value); }

        /// <summary>
        /// </summary>
        public  DescriptiveFeedback { get => _DescriptiveFeedback; set => SetProperty(ref _DescriptiveFeedback, value); }

        /// <summary>
        /// </summary>
        public Guid? Duration { get => _Duration; set => SetProperty(ref _Duration, value); }

        /// <summary>
        /// </summary>
        public  FirstAttemptDuration { get => _FirstAttemptDuration; set => SetProperty(ref _FirstAttemptDuration, value); }

        /// <summary>
        /// </summary>
        public  HintCount { get => _HintCount; set => SetProperty(ref _HintCount, value); }

        /// <summary>
        /// </summary>
        public  HintIncludedAnswer { get => _HintIncludedAnswer; set => SetProperty(ref _HintIncludedAnswer, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessItemResponseStatus"/> model
        /// </summary>
        public  RefAssessItemResponseStatusId { get => _RefAssessItemResponseStatusId; set => SetProperty(ref _RefAssessItemResponseStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        public  RefAssessmentItemResponseScoreStatusId { get => _RefAssessmentItemResponseScoreStatusId; set => SetProperty(ref _RefAssessmentItemResponseScoreStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        public  RefProficiencyStatusId { get => _RefProficiencyStatusId; set => SetProperty(ref _RefProficiencyStatusId, value); }

        /// <summary>
        /// </summary>
        public  ResultXML { get => _ResultXML; set => SetProperty(ref _ResultXML, value); }

        /// <summary>
        /// </summary>
        public  ScaffoldingItemFlag { get => _ScaffoldingItemFlag; set => SetProperty(ref _ScaffoldingItemFlag, value); }

        /// <summary>
        /// </summary>
        public  ScoreValue { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        /// <summary>
        /// </summary>
        public  SecurityIssue { get => _SecurityIssue; set => SetProperty(ref _SecurityIssue, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// </summary>
        public  StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        /// <summary>
        /// </summary>
        public  Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            AidSetUsed = model.AidSetUsed; // 
            AssessmentItemResponseDescriptiveFeedbackDate = model.AssessmentItemResponseDescriptiveFeedbackDate; // 
            DescriptiveFeedback = model.DescriptiveFeedback; // 
            Duration = model.Duration; // 
            FirstAttemptDuration = model.FirstAttemptDuration; // 
            HintCount = model.HintCount; // 
            HintIncludedAnswer = model.HintIncludedAnswer; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessItemResponseStatusId = model.RefAssessItemResponseStatusId; // 
            RefAssessmentItemResponseScoreStatusId = model.RefAssessmentItemResponseScoreStatusId; // 
            RefProficiencyStatusId = model.RefProficiencyStatusId; // 
            ResultXML = model.ResultXML; // 
            ScaffoldingItemFlag = model.ScaffoldingItemFlag; // 
            ScoreValue = model.ScoreValue; // 
            SecurityIssue = model.SecurityIssue; // 
            StartDate = model.StartDate; // 
            StartTime = model.StartTime; // 
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
