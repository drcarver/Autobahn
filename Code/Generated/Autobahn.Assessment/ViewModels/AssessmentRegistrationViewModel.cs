//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentRegistrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentRegistrationViewModel
     /// </summary>
    public partial class AssessmentRegistrationViewModel : ViewModelBase, Interfaces.IAssessmentRegistrationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistration";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the AssessmentFormId property
        private Guid _AssessmentFormId;

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

        // member variable for the CourseSectionId property
        private Guid? _CourseSectionId;

        // member variable for the TestingIndicator property
        private System.String _TestingIndicator;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // member variable for the SchoolOrganizationId property
        private Guid? _SchoolOrganizationId;

        // member variable for the LeaOrganizationId property
        private Guid? _LeaOrganizationId;

        // member variable for the AssessmentAdministrationId property
        private Guid? _AssessmentAdministrationId;

        // member variable for the AssignedByPersonId property
        private Guid? _AssignedByPersonId;

        // member variable for the AssessmentRegistrationCompletionStatusDateTime property
        private System.DateTime? _AssessmentRegistrationCompletionStatusDateTime;

        // member variable for the StateFullAcademicYear property
        private System.Boolean? _StateFullAcademicYear;

        // member variable for the LEAFullAcademicYear property
        private System.Boolean? _LEAFullAcademicYear;

        // member variable for the SchoolFullAcademicYear property
        private System.Boolean? _SchoolFullAcademicYear;

        // member variable for the RefAssessmentParticipationIndicatorId property
        private Guid? _RefAssessmentParticipationIndicatorId;

        // member variable for the RefAssessmentPurposeId property
        private Guid? _RefAssessmentPurposeId;

        // member variable for the RefAssessmentReasonNotTestedId property
        private Guid? _RefAssessmentReasonNotTestedId;

        // member variable for the RefAssessmentReasonNotCompletingId property
        private Guid? _RefAssessmentReasonNotCompletingId;

        // member variable for the RefGradeLevelToBeAssessedId property
        private Guid? _RefGradeLevelToBeAssessedId;

        // member variable for the RefGradeLevelWhenAssessedId property
        private Guid? _RefGradeLevelWhenAssessedId;

        // member variable for the RefAssessmentRegistrationCompletionStatusId property
        private Guid? _RefAssessmentRegistrationCompletionStatusId;

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
        /// The title of the AssessmentRegistrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        public System.Int32? DaysOfInstructionPriorToAssessment { get => _DaysOfInstructionPriorToAssessment; set => SetProperty(ref _DaysOfInstructionPriorToAssessment, value); }

        public System.DateTime? ScorePublishDate { get => _ScorePublishDate; set => SetProperty(ref _ScorePublishDate, value); }

        public System.String TestAttemptIdentifier  { get => _TestAttemptIdentifier; set => SetProperty(ref _TestAttemptIdentifier, value); }

        public System.Boolean? RetestIndicator { get => _RetestIndicator; set => SetProperty(ref _RetestIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        public System.String TestingIndicator  { get => _TestingIndicator; set => SetProperty(ref _TestingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganizationId"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get => _SchoolOrganizationId; set => SetProperty(ref _SchoolOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganizationId"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get => _LeaOrganizationId; set => SetProperty(ref _LeaOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministrationId"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get => _AssessmentAdministrationId; set => SetProperty(ref _AssessmentAdministrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPersonId"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get => _AssignedByPersonId; set => SetProperty(ref _AssignedByPersonId, value); }

        public System.DateTime? AssessmentRegistrationCompletionStatusDateTime { get => _AssessmentRegistrationCompletionStatusDateTime; set => SetProperty(ref _AssessmentRegistrationCompletionStatusDateTime, value); }

        public System.Boolean? StateFullAcademicYear { get => _StateFullAcademicYear; set => SetProperty(ref _StateFullAcademicYear, value); }

        public System.Boolean? LEAFullAcademicYear { get => _LEAFullAcademicYear; set => SetProperty(ref _LEAFullAcademicYear, value); }

        public System.Boolean? SchoolFullAcademicYear { get => _SchoolFullAcademicYear; set => SetProperty(ref _SchoolFullAcademicYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicatorId"/> model
        /// </summary>
        public Guid? RefAssessmentParticipationIndicatorId { get => _RefAssessmentParticipationIndicatorId; set => SetProperty(ref _RefAssessmentParticipationIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotTestedId"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotTestedId { get => _RefAssessmentReasonNotTestedId; set => SetProperty(ref _RefAssessmentReasonNotTestedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentReasonNotCompletingId"/> model
        /// </summary>
        public Guid? RefAssessmentReasonNotCompletingId { get => _RefAssessmentReasonNotCompletingId; set => SetProperty(ref _RefAssessmentReasonNotCompletingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelToBeAssessedId"/> model
        /// </summary>
        public Guid? RefGradeLevelToBeAssessedId { get => _RefGradeLevelToBeAssessedId; set => SetProperty(ref _RefGradeLevelToBeAssessedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenAssessedId"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenAssessedId { get => _RefGradeLevelWhenAssessedId; set => SetProperty(ref _RefGradeLevelWhenAssessedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentRegistrationCompletionStatusId"/> model
        /// </summary>
        public Guid? RefAssessmentRegistrationCompletionStatusId { get => _RefAssessmentRegistrationCompletionStatusId; set => SetProperty(ref _RefAssessmentRegistrationCompletionStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistration model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
