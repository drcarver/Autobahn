//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistrationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentRegistrationViewModel
     /// </summary>
    public partial class AssessmentRegistrationViewModel : BindableBase, IAssessmentRegistration
    {
#region "Backing Fields"
        // member variable for the CreationDate property
        private System.DateTime? _CreationDate;

        // member variable for the DaysOfInstructionPriorToAssessment property
        private System.Int32? _DaysOfInstructionPriorToAssessment;

        // member variable for the ScorePublishDate property
        private System.DateTime? _ScorePublishDate;

        // member variable for the TestAttemptIdentifier property
        private System.String _TestAttemptIdentifier;

        // member variable for the RetestIndicator property
        private System.Boolean? _RetestIndicator;

        // member variable for the TestingIndicator property
        private System.String _TestingIndicator;

        // member variable for the AssessmentRegistrationCompletionStatusDateTime property
        private System.DateTime? _AssessmentRegistrationCompletionStatusDateTime;

        // member variable for the StateFullAcademicYear property
        private System.Boolean? _StateFullAcademicYear;

        // member variable for the LEAFullAcademicYear property
        private System.Boolean? _LEAFullAcademicYear;

        // member variable for the SchoolFullAcademicYear property
        private System.Boolean? _SchoolFullAcademicYear;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        public System.Int32? DaysOfInstructionPriorToAssessment { get => _DaysOfInstructionPriorToAssessment; set => SetProperty(ref _DaysOfInstructionPriorToAssessment, value); }

        public System.DateTime? ScorePublishDate { get => _ScorePublishDate; set => SetProperty(ref _ScorePublishDate, value); }

        public System.String TestAttemptIdentifier  { get => _TestAttemptIdentifier; set => SetProperty(ref _TestAttemptIdentifier, value); }

        public System.Boolean? RetestIndicator { get => _RetestIndicator; set => SetProperty(ref _RetestIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        public System.String TestingIndicator  { get => _TestingIndicator; set => SetProperty(ref _TestingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganizationId"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganizationId"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPersonId"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        public System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get => _AssessmentRegistrationCompletionStatusDateTime; set => SetProperty(ref _AssessmentRegistrationCompletionStatusDateTime, value); }

        public System.Boolean? StateFullAcademicYear { get => _StateFullAcademicYear; set => SetProperty(ref _StateFullAcademicYear, value); }

        public System.Boolean? LEAFullAcademicYear { get => _LEAFullAcademicYear; set => SetProperty(ref _LEAFullAcademicYear, value); }

        public System.Boolean? SchoolFullAcademicYear { get => _SchoolFullAcademicYear; set => SetProperty(ref _SchoolFullAcademicYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicatorId"/> model
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotTestedId"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotTestedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotCompletingId"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotCompletingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelToBeAssessedId"/> model
        /// </summary>
        public Guid? RefGradeLevelToBeAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenAssessedId"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenAssessedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentRegistrationCompletionStatusId"/> model
        /// </summary>
        public Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

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
        public void Load(IAssessmentRegistration model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            AssessmentFormId = model.AssessmentFormId;
            CreationDate = model.CreationDate;
            DaysOfInstructionPriorToAssessment = model.DaysOfInstructionPriorToAssessment;
            ScorePublishDate = model.ScorePublishDate;
            TestAttemptIdentifier = model.TestAttemptIdentifier;
            RetestIndicator = model.RetestIndicator;
            CourseSectionId = model.CourseSectionId;
            TestingIndicator = model.TestingIndicator;
            OrganizationId = model.OrganizationId;
            SchoolOrganizationId = model.SchoolOrganizationId;
            LeaOrganizationId = model.LeaOrganizationId;
            AssessmentAdministrationId = model.AssessmentAdministrationId;
            AssignedByPersonId = model.AssignedByPersonId;
            AssessmentRegistrationCompletionStatusDateTime = model.AssessmentRegistrationCompletionStatusDateTime;
            StateFullAcademicYear = model.StateFullAcademicYear;
            LEAFullAcademicYear = model.LEAFullAcademicYear;
            SchoolFullAcademicYear = model.SchoolFullAcademicYear;
            RefAssessmentParticipationIndicatorId = model.RefAssessmentParticipationIndicatorId;
            RefAssessmentPurposeId = model.RefAssessmentPurposeId;
            RefAssessmentReasonNotTestedId = model.RefAssessmentReasonNotTestedId;
            RefAssessmentReasonNotCompletingId = model.RefAssessmentReasonNotCompletingId;
            RefGradeLevelToBeAssessedId = model.RefGradeLevelToBeAssessedId;
            RefGradeLevelWhenAssessedId = model.RefGradeLevelWhenAssessedId;
            RefAssessmentRegistrationCompletionStatusId = model.RefAssessmentRegistrationCompletionStatusId;
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
