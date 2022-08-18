//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActivityViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearnerActivity View Model
     /// </summary>
    public partial class LearnerActivityViewModel : ViewModelBase, Interfaces.ILearnerActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivity";

        // member variable for the AssessmentRegistrationId property
        private Guid? _AssessmentRegistrationId;

        // member variable for the AssignedByPersonId property
        private Guid? _AssignedByPersonId;

        // member variable for the CourseSectionId property
        private Guid? _CourseSectionId;

        // CreationDate -- (backing property for Learner Activity Creation Date)
        private System.DateTime? _CreationDate;

        // DueDate -- (backing property for Learner Activity Due Date)
        private System.DateTime? _DueDate;

        // DueTime -- (backing property for Learner Activity Due Time)
        private System.TimeSpan? _DueTime;

        // member variable for the LeaOrganizationId property
        private Guid? _LeaOrganizationId;

        // MaximumAttemptsAllowed -- (backing property for Learner Activity Maximum Attempts Allowed)
        private System.Decimal? _MaximumAttemptsAllowed;

        // MaximumTimeAllowed -- (backing property for Learner Activity Maximum Time Allowed)
        private System.Decimal? _MaximumTimeAllowed;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // PossiblePoints -- (backing property for Learner Activity Possible Points)
        private System.Decimal? _PossiblePoints;

        // Prerequisite -- (backing property for Learner Activity Prerequisite)
        private System.String _Prerequisite;

        // RefLanguageId -- (backing property for Learner Activity Language)
        private Guid? _RefLanguageId;

        // RefLearnerActivityAddToGradeBookFlagId -- (backing property for Learner Activity Add to Grade Book Flag)
        private Guid? _RefLearnerActivityAddToGradeBookFlagId;

        // RefLearnerActivityMaximumTimeAllowedUnitsId -- (backing property for Learner Activity Maximum Time Allowed Unit)
        private Guid? _RefLearnerActivityMaximumTimeAllowedUnitsId;

        // RefLearnerActivityTypeId -- (backing property for Learner Activity Type)
        private Guid? _RefLearnerActivityTypeId;

        // ReleaseDate -- (backing property for Learner Activity Release Date)
        private System.DateTime? _ReleaseDate;

        // RubricUrl -- (backing property for Learner Activity Rubric URL)
        private System.String _RubricUrl;

        // member variable for the SchoolOrganizationId property
        private Guid? _SchoolOrganizationId;

        // Title -- (backing property for Learner Activity Title)
        private System.String _Title;

        // Weight -- (backing property for Learner Activity Weight)
        private System.Decimal? _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get => _AssignedByPersonId; set => SetProperty(ref _AssignedByPersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Learner Activity Creation Date
        /// <para>
        /// The creation date of the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19944">Learner Activity Creation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        /// <summary>
        /// Learner Activity Due Date
        /// <para>
        /// The date assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19947">Learner Activity Due Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DueDate { get => _DueDate; set => SetProperty(ref _DueDate, value); }

        /// <summary>
        /// Learner Activity Due Time
        /// <para>
        /// The time the assignment is due.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19948">Learner Activity Due Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? DueTime { get => _DueTime; set => SetProperty(ref _DueTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get => _LeaOrganizationId; set => SetProperty(ref _LeaOrganizationId, value); }

        /// <summary>
        /// Learner Activity Maximum Attempts Allowed
        /// <para>
        /// The number attempts a student may make on this assignment. Assumed to be unlimited if zero or omitted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19949">Learner Activity Maximum Attempts Allowed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? MaximumAttemptsAllowed { get => _MaximumAttemptsAllowed; set => SetProperty(ref _MaximumAttemptsAllowed, value); }

        /// <summary>
        /// Learner Activity Maximum Time Allowed
        /// <para>
        /// The time required to complete the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19945">Learner Activity Maximum Time Allowed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? MaximumTimeAllowed { get => _MaximumTimeAllowed; set => SetProperty(ref _MaximumTimeAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Learner Activity Possible Points
        /// <para>
        /// The number of possible points for an assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19953">Learner Activity Possible Points</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? PossiblePoints { get => _PossiblePoints; set => SetProperty(ref _PossiblePoints, value); }

        /// <summary>
        /// Learner Activity Prerequisite
        /// <para>
        /// The description of the skills or competencies the student must have to engage in assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19942">Learner Activity Prerequisite</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Prerequisite { get => _Prerequisite; set => SetProperty(ref _Prerequisite, value); }

        /// <summary>
        /// Learner Activity Language
        /// <para>
        /// The default language used for the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19939">Learner Activity Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Learner Activity Add to Grade Book Flag
        /// <para>
        /// Identifies the assignment as one that is graded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19950">Learner Activity Add to Grade Book Flag</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get => _RefLearnerActivityAddToGradeBookFlagId; set => SetProperty(ref _RefLearnerActivityAddToGradeBookFlagId, value); }

        /// <summary>
        /// Learner Activity Maximum Time Allowed Unit
        /// <para>
        /// The unit of time of the�Maximum Time Allowed�value.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19946">Learner Activity Maximum Time Allowed Unit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get => _RefLearnerActivityMaximumTimeAllowedUnitsId; set => SetProperty(ref _RefLearnerActivityMaximumTimeAllowedUnitsId, value); }

        /// <summary>
        /// Learner Activity Type
        /// <para>
        /// The type of work assigned to the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get => _RefLearnerActivityTypeId; set => SetProperty(ref _RefLearnerActivityTypeId, value); }

        /// <summary>
        /// Learner Activity Release Date
        /// <para>
        /// The date the student was informed about an assignment or that an automated system displays the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19951">Learner Activity Release Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ReleaseDate { get => _ReleaseDate; set => SetProperty(ref _ReleaseDate, value); }

        /// <summary>
        /// Learner Activity Rubric URL
        /// <para>
        /// The Uniform Resource Locator pointing to a rubric that may be used to evaluate learner performance on the assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19954">Learner Activity Rubric URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RubricUrl { get => _RubricUrl; set => SetProperty(ref _RubricUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get => _SchoolOrganizationId; set => SetProperty(ref _SchoolOrganizationId, value); }

        /// <summary>
        /// Learner Activity Title
        /// <para>
        /// The title�for work assigned to the learner, which can comprise of learning resources, activities, and assessments.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19940">Learner Activity Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Learner Activity Weight
        /// <para>
        /// The percentage weight of the assignment during the particular course or term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19952">Learner Activity Weight</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentRegistrationId = model.AssessmentRegistrationId; // 
            AssignedByPersonId = model.AssignedByPersonId; // 
            CourseSectionId = model.CourseSectionId; // 
            CreationDate = model.CreationDate; // Learner Activity Creation Date
            DueDate = model.DueDate; // Learner Activity Due Date
            DueTime = model.DueTime; // Learner Activity Due Time
            LeaOrganizationId = model.LeaOrganizationId; // 
            MaximumAttemptsAllowed = model.MaximumAttemptsAllowed; // Learner Activity Maximum Attempts Allowed
            MaximumTimeAllowed = model.MaximumTimeAllowed; // Learner Activity Maximum Time Allowed
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            PersonId = model.PersonId; // 
            PossiblePoints = model.PossiblePoints; // Learner Activity Possible Points
            Prerequisite = model.Prerequisite; // Learner Activity Prerequisite
            RefLanguageId = model.RefLanguageId; // Learner Activity Language
            RefLearnerActivityAddToGradeBookFlagId = model.RefLearnerActivityAddToGradeBookFlagId; // Learner Activity Add to Grade Book Flag
            RefLearnerActivityMaximumTimeAllowedUnitsId = model.RefLearnerActivityMaximumTimeAllowedUnitsId; // Learner Activity Maximum Time Allowed Unit
            RefLearnerActivityTypeId = model.RefLearnerActivityTypeId; // Learner Activity Type
            ReleaseDate = model.ReleaseDate; // Learner Activity Release Date
            RubricUrl = model.RubricUrl; // Learner Activity Rubric URL
            SchoolOrganizationId = model.SchoolOrganizationId; // 
            Title = model.Title; // Learner Activity Title
            Weight = model.Weight; // Learner Activity Weight
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearnerActivityAddToGradeBookFlag List
        /// <summary>
        /// The complete <see cref="RefLearnerActivityAddToGradeBookFlag"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearnerActivityAddToGradeBookFlagList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a290a174-02d3-4400-b14e-3f95317715c6"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ebcc308c-0e8b-478c-a935-d47ef8813cba"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("812aa0a4-260b-43f8-8877-94b7f3c9b0da"), Code="NotSelected", Description="Not selected", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefLearnerActivityMaximumTimeAllowedUnits List
        /// <summary>
        /// The complete <see cref="RefLearnerActivityMaximumTimeAllowedUnits"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearnerActivityMaximumTimeAllowedUnitsList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a3321ab9-2ca1-4088-9473-624849e0e3d3"), Code="Week", Description="Week", Definition="The value specified for Learner Activity Maximum Time Allowed is a number of weeks.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3916de6-8c9e-49c1-94de-7da14bcb6833"), Code="Day", Description="Day", Definition="The value specified for Learner Activity Maximum Time Allowed is a number of days.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("4638dc12-7348-4650-8e6a-9afdcb33bba2"), Code="Hour", Description="Hour", Definition="The value specified for Learner Activity Maximum Time Allowed is a number of hours.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("061e476b-787f-41a4-bb92-528815b6a06f"), Code="Minute", Description="Minute", Definition="The value specified for Learner Activity Maximum Time Allowed is a number of minute.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("9f2bd2d7-e174-4683-9d0c-8127692082b0"), Code="Second", Description="Second", Definition="The value specified for Learner Activity Maximum Time Allowed is a number of seconds.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefLearnerActivityType List
        /// <summary>
        /// The complete <see cref="RefLearnerActivityType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearnerActivityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ebc095a2-788d-47bc-95c7-f1f9ab457d2a"), Code="Assignment", Description="Assignment", Definition="The type of work assigned to the learner is an assignment.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("50385410-ab7e-47eb-b5eb-b642812e9fdb"), Code="LearningResource", Description="Learning Resource", Definition="The type of assignment to the learner is a learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bde1fff2-29cc-4e97-847e-8c9c9c53b41e"), Code="Activity", Description="Activity", Definition="The type of work assigned to the learner is an activity.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("efec7d03-859e-4a2b-9e3d-e5f4e70bf168"), Code="Lesson", Description="Lesson", Definition="The type of work assigned to the learner is a lesson.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
