//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The LearnerActivityViewModel
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

        // member variable for the CreationDate property
        private System.DateTime? _CreationDate;

        // member variable for the DueDate property
        private System.DateTime? _DueDate;

        // member variable for the DueTime property
        private System.TimeSpan? _DueTime;

        // member variable for the LeaOrganizationId property
        private Guid? _LeaOrganizationId;

        // member variable for the MaximumAttemptsAllowed property
        private System.Decimal? _MaximumAttemptsAllowed;

        // member variable for the MaximumTimeAllowed property
        private System.Decimal? _MaximumTimeAllowed;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PossiblePoints property
        private System.Decimal? _PossiblePoints;

        // member variable for the Prerequisite property
        private System.String _Prerequisite;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefLearnerActivityAddToGradeBookFlagId property
        private Guid? _RefLearnerActivityAddToGradeBookFlagId;

        // member variable for the RefLearnerActivityMaximumTimeAllowedUnitsId property
        private Guid? _RefLearnerActivityMaximumTimeAllowedUnitsId;

        // member variable for the RefLearnerActivityTypeId property
        private Guid? _RefLearnerActivityTypeId;

        // member variable for the ReleaseDate property
        private System.DateTime? _ReleaseDate;

        // member variable for the RubricUrl property
        private System.String _RubricUrl;

        // member variable for the SchoolOrganizationId property
        private Guid? _SchoolOrganizationId;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearnerActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistration"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPerson"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get => _AssignedByPersonId; set => SetProperty(ref _AssignedByPersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? DueDate { get => _DueDate; set => SetProperty(ref _DueDate, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.TimeSpan? DueTime { get => _DueTime; set => SetProperty(ref _DueTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganization"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get => _LeaOrganizationId; set => SetProperty(ref _LeaOrganizationId, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? MaximumAttemptsAllowed { get => _MaximumAttemptsAllowed; set => SetProperty(ref _MaximumAttemptsAllowed, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? MaximumTimeAllowed { get => _MaximumTimeAllowed; set => SetProperty(ref _MaximumTimeAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.Decimal? PossiblePoints { get => _PossiblePoints; set => SetProperty(ref _PossiblePoints, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String Prerequisite { get => _Prerequisite; set => SetProperty(ref _Prerequisite, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlag"/> model
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get => _RefLearnerActivityAddToGradeBookFlagId; set => SetProperty(ref _RefLearnerActivityAddToGradeBookFlagId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get => _RefLearnerActivityMaximumTimeAllowedUnitsId; set => SetProperty(ref _RefLearnerActivityMaximumTimeAllowedUnitsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityType"/> model
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get => _RefLearnerActivityTypeId; set => SetProperty(ref _RefLearnerActivityTypeId, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.DateTime? ReleaseDate { get => _ReleaseDate; set => SetProperty(ref _ReleaseDate, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String RubricUrl { get => _RubricUrl; set => SetProperty(ref _RubricUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganization"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get => _SchoolOrganizationId; set => SetProperty(ref _SchoolOrganizationId, value); }

        /// <summary>
        /// The default language used for the assignment.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// The default language used for the assignment.
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
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            AssignedByPersonId = model.AssignedByPersonId;
            CourseSectionId = model.CourseSectionId;
            CreationDate = model.CreationDate;
            DueDate = model.DueDate;
            DueTime = model.DueTime;
            LeaOrganizationId = model.LeaOrganizationId;
            MaximumAttemptsAllowed = model.MaximumAttemptsAllowed;
            MaximumTimeAllowed = model.MaximumTimeAllowed;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            PersonId = model.PersonId;
            PossiblePoints = model.PossiblePoints;
            Prerequisite = model.Prerequisite;
            RefLanguageId = model.RefLanguageId;
            RefLearnerActivityAddToGradeBookFlagId = model.RefLearnerActivityAddToGradeBookFlagId;
            RefLearnerActivityMaximumTimeAllowedUnitsId = model.RefLearnerActivityMaximumTimeAllowedUnitsId;
            RefLearnerActivityTypeId = model.RefLearnerActivityTypeId;
            ReleaseDate = model.ReleaseDate;
            RubricUrl = model.RubricUrl;
            SchoolOrganizationId = model.SchoolOrganizationId;
            Title = model.Title;
            Weight = model.Weight;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
