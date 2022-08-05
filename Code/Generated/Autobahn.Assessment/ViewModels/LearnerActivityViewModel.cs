//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActivityViewModel
     /// </summary>
    public partial class LearnerActivityViewModel : ViewModelBase, Interfaces.ILearnerActivity
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivity";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the AssessmentRegistrationId property
        private Guid? _AssessmentRegistrationId;

        // member variable for the CourseSectionId property
        private Guid? _CourseSectionId;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Prerequisite property
        private System.String _Prerequisite;

        // member variable for the RefLearnerActivityTypeId property
        private Guid? _RefLearnerActivityTypeId;

        // member variable for the RubricUrl property
        private System.String _RubricUrl;

        // member variable for the CreationDate property
        private System.DateTime? _CreationDate;

        // member variable for the MaximumTimeAllowed property
        private System.Decimal? _MaximumTimeAllowed;

        // member variable for the RefLearnerActivityMaximumTimeAllowedUnitsId property
        private Guid? _RefLearnerActivityMaximumTimeAllowedUnitsId;

        // member variable for the DueDate property
        private System.DateTime? _DueDate;

        // member variable for the DueTime property
        private System.TimeSpan? _DueTime;

        // member variable for the MaximumAttemptsAllowed property
        private System.Decimal? _MaximumAttemptsAllowed;

        // member variable for the RefLearnerActivityAddToGradeBookFlagId property
        private Guid? _RefLearnerActivityAddToGradeBookFlagId;

        // member variable for the ReleaseDate property
        private System.DateTime? _ReleaseDate;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        // member variable for the PossiblePoints property
        private System.Decimal? _PossiblePoints;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the AssignedByPersonId property
        private Guid? _AssignedByPersonId;

        // member variable for the SchoolOrganizationId property
        private Guid? _SchoolOrganizationId;

        // member variable for the LeaOrganizationId property
        private Guid? _LeaOrganizationId;

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
        /// The title of the LearnerActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get => _AssessmentRegistrationId; set => SetProperty(ref _AssessmentRegistrationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid? CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Prerequisite  { get => _Prerequisite; set => SetProperty(ref _Prerequisite, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityTypeId"/> model
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get => _RefLearnerActivityTypeId; set => SetProperty(ref _RefLearnerActivityTypeId, value); }

        public System.String RubricUrl  { get => _RubricUrl; set => SetProperty(ref _RubricUrl, value); }

        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        public System.Decimal? MaximumTimeAllowed { get => _MaximumTimeAllowed; set => SetProperty(ref _MaximumTimeAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnitsId"/> model
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get => _RefLearnerActivityMaximumTimeAllowedUnitsId; set => SetProperty(ref _RefLearnerActivityMaximumTimeAllowedUnitsId, value); }

        public System.DateTime? DueDate { get => _DueDate; set => SetProperty(ref _DueDate, value); }

        public System.TimeSpan? DueTime { get => _DueTime; set => SetProperty(ref _DueTime, value); }

        public System.Decimal? MaximumAttemptsAllowed { get => _MaximumAttemptsAllowed; set => SetProperty(ref _MaximumAttemptsAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlagId"/> model
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get => _RefLearnerActivityAddToGradeBookFlagId; set => SetProperty(ref _RefLearnerActivityAddToGradeBookFlagId, value); }

        public System.DateTime? ReleaseDate { get => _ReleaseDate; set => SetProperty(ref _ReleaseDate, value); }

        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        public System.Decimal? PossiblePoints { get => _PossiblePoints; set => SetProperty(ref _PossiblePoints, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPersonId"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get => _AssignedByPersonId; set => SetProperty(ref _AssignedByPersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganizationId"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get => _SchoolOrganizationId; set => SetProperty(ref _SchoolOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganizationId"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get => _LeaOrganizationId; set => SetProperty(ref _LeaOrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            AssessmentRegistrationId = model.AssessmentRegistrationId;
            CourseSectionId = model.CourseSectionId;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            Title = model.Title;
            Description = model.Description;
            Prerequisite = model.Prerequisite;
            RefLearnerActivityTypeId = model.RefLearnerActivityTypeId;
            RubricUrl = model.RubricUrl;
            CreationDate = model.CreationDate;
            MaximumTimeAllowed = model.MaximumTimeAllowed;
            RefLearnerActivityMaximumTimeAllowedUnitsId = model.RefLearnerActivityMaximumTimeAllowedUnitsId;
            DueDate = model.DueDate;
            DueTime = model.DueTime;
            MaximumAttemptsAllowed = model.MaximumAttemptsAllowed;
            RefLearnerActivityAddToGradeBookFlagId = model.RefLearnerActivityAddToGradeBookFlagId;
            ReleaseDate = model.ReleaseDate;
            Weight = model.Weight;
            PossiblePoints = model.PossiblePoints;
            RefLanguageId = model.RefLanguageId;
            AssignedByPersonId = model.AssignedByPersonId;
            SchoolOrganizationId = model.SchoolOrganizationId;
            LeaOrganizationId = model.LeaOrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
