//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentRegistrationViewModel
     /// </summary>
    public partial class AssessmentRegistrationViewModel : ViewModelBase, Interfaces.IAssessmentRegistration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistration";

        // member variable for the AssessmentRegistrationCompletionStatusDateTime property
        private  _AssessmentRegistrationCompletionStatusDateTime;

        // member variable for the AssignedByPersonId property
        private  _AssignedByPersonId;

        // member variable for the CreationDate property
        private  _CreationDate;

        // member variable for the DaysOfInstructionPriorToAssessment property
        private  _DaysOfInstructionPriorToAssessment;

        // member variable for the LEAFullAcademicYear property
        private  _LEAFullAcademicYear;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentParticipationIndicatorId property
        private Guid? _RefAssessmentParticipationIndicatorId;

        // member variable for the RefAssessmentPurposeId property
        private  _RefAssessmentPurposeId;

        // member variable for the RefAssessmentReasonNotCompletingId property
        private  _RefAssessmentReasonNotCompletingId;

        // member variable for the RefAssessmentReasonNotTestedId property
        private  _RefAssessmentReasonNotTestedId;

        // member variable for the RefAssessmentRegistrationCompletionStatusId property
        private  _RefAssessmentRegistrationCompletionStatusId;

        // member variable for the RefGradeLevelToBeAssessedId property
        private  _RefGradeLevelToBeAssessedId;

        // member variable for the RefGradeLevelWhenAssessedId property
        private  _RefGradeLevelWhenAssessedId;

        // member variable for the RetestIndicator property
        private  _RetestIndicator;

        // member variable for the SchoolFullAcademicYear property
        private  _SchoolFullAcademicYear;

        // member variable for the ScorePublishDate property
        private  _ScorePublishDate;

        // member variable for the StateFullAcademicYear property
        private  _StateFullAcademicYear;

        // member variable for the TestAttemptIdentifier property
        private  _TestAttemptIdentifier;

        // member variable for the TestingIndicator property
        private  _TestingIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentRegistrationCompletionStatusDateTime { get => _AssessmentRegistrationCompletionStatusDateTime; set => SetProperty(ref _AssessmentRegistrationCompletionStatusDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        public  AssignedByPersonId { get => _AssignedByPersonId; set => SetProperty(ref _AssignedByPersonId, value); }

        /// <summary>
        /// </summary>
        public  CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        /// <summary>
        /// </summary>
        public  DaysOfInstructionPriorToAssessment { get => _DaysOfInstructionPriorToAssessment; set => SetProperty(ref _DaysOfInstructionPriorToAssessment, value); }

        /// <summary>
        /// </summary>
        public  LEAFullAcademicYear { get => _LEAFullAcademicYear; set => SetProperty(ref _LEAFullAcademicYear, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicator"/> model
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get => _RefAssessmentParticipationIndicatorId; set => SetProperty(ref _RefAssessmentParticipationIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public  RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotCompleting"/> model
        /// </summary>
        public  RefAssessmentReasonNotCompletingId { get => _RefAssessmentReasonNotCompletingId; set => SetProperty(ref _RefAssessmentReasonNotCompletingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotTested"/> model
        /// </summary>
        public  RefAssessmentReasonNotTestedId { get => _RefAssessmentReasonNotTestedId; set => SetProperty(ref _RefAssessmentReasonNotTestedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentRegistrationCompletionStatus"/> model
        /// </summary>
        public  RefAssessmentRegistrationCompletionStatusId { get => _RefAssessmentRegistrationCompletionStatusId; set => SetProperty(ref _RefAssessmentRegistrationCompletionStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelToBeAssessed"/> model
        /// </summary>
        public  RefGradeLevelToBeAssessedId { get => _RefGradeLevelToBeAssessedId; set => SetProperty(ref _RefGradeLevelToBeAssessedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenAssessed"/> model
        /// </summary>
        public  RefGradeLevelWhenAssessedId { get => _RefGradeLevelWhenAssessedId; set => SetProperty(ref _RefGradeLevelWhenAssessedId, value); }

        /// <summary>
        /// </summary>
        public  RetestIndicator { get => _RetestIndicator; set => SetProperty(ref _RetestIndicator, value); }

        /// <summary>
        /// </summary>
        public  SchoolFullAcademicYear { get => _SchoolFullAcademicYear; set => SetProperty(ref _SchoolFullAcademicYear, value); }

        /// <summary>
        /// </summary>
        public  ScorePublishDate { get => _ScorePublishDate; set => SetProperty(ref _ScorePublishDate, value); }

        /// <summary>
        /// </summary>
        public  StateFullAcademicYear { get => _StateFullAcademicYear; set => SetProperty(ref _StateFullAcademicYear, value); }

        /// <summary>
        /// </summary>
        public  TestAttemptIdentifier { get => _TestAttemptIdentifier; set => SetProperty(ref _TestAttemptIdentifier, value); }

        /// <summary>
        /// </summary>
        public  TestingIndicator { get => _TestingIndicator; set => SetProperty(ref _TestingIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentRegistrationCompletionStatusDateTime = model.AssessmentRegistrationCompletionStatusDateTime; // 
            AssignedByPersonId = model.AssignedByPersonId; // 
            CreationDate = model.CreationDate; // 
            DaysOfInstructionPriorToAssessment = model.DaysOfInstructionPriorToAssessment; // 
            LEAFullAcademicYear = model.LEAFullAcademicYear; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentParticipationIndicatorId = model.RefAssessmentParticipationIndicatorId; // 
            RefAssessmentPurposeId = model.RefAssessmentPurposeId; // 
            RefAssessmentReasonNotCompletingId = model.RefAssessmentReasonNotCompletingId; // 
            RefAssessmentReasonNotTestedId = model.RefAssessmentReasonNotTestedId; // 
            RefAssessmentRegistrationCompletionStatusId = model.RefAssessmentRegistrationCompletionStatusId; // 
            RefGradeLevelToBeAssessedId = model.RefGradeLevelToBeAssessedId; // 
            RefGradeLevelWhenAssessedId = model.RefGradeLevelWhenAssessedId; // 
            RetestIndicator = model.RetestIndicator; // 
            SchoolFullAcademicYear = model.SchoolFullAcademicYear; // 
            ScorePublishDate = model.ScorePublishDate; // 
            StateFullAcademicYear = model.StateFullAcademicYear; // 
            TestAttemptIdentifier = model.TestAttemptIdentifier; // 
            TestingIndicator = model.TestingIndicator; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
