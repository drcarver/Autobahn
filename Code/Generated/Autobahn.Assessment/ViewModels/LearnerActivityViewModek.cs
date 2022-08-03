//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   LearnerActivityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The LearnerActivityViewModel
     /// </summary>
    public partial class LearnerActivityViewModel : BindableBase, ILearnerActivity
    {
#region "Backing Fields"
        // member variable for the Title property
        private System.String _Title;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Prerequisite property
        private System.String _Prerequisite;

        // member variable for the RubricUrl property
        private System.String _RubricUrl;

        // member variable for the CreationDate property
        private System.DateTime? _CreationDate;

        // member variable for the MaximumTimeAllowed property
        private System.Decimal? _MaximumTimeAllowed;

        // member variable for the DueDate property
        private System.DateTime? _DueDate;

        // member variable for the DueTime property
        private System.TimeSpan? _DueTime;

        // member variable for the MaximumAttemptsAllowed property
        private System.Decimal? _MaximumAttemptsAllowed;

        // member variable for the ReleaseDate property
        private System.DateTime? _ReleaseDate;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        // member variable for the PossiblePoints property
        private System.Decimal? _PossiblePoints;

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
        /// Reference to an optional instance of the <see cref="AssessmentRegistrationId"/> model
        /// </summary>
        public Guid? AssessmentRegistrationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Prerequisite  { get => _Prerequisite; set => SetProperty(ref _Prerequisite, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityTypeId"/> model
        /// </summary>
        public Guid? RefLearnerActivityTypeId { get; set; }

        public System.String RubricUrl  { get => _RubricUrl; set => SetProperty(ref _RubricUrl, value); }

        public System.DateTime? CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        public System.Decimal? MaximumTimeAllowed { get => _MaximumTimeAllowed; set => SetProperty(ref _MaximumTimeAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnitsId"/> model
        /// </summary>
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        public System.DateTime? DueDate { get => _DueDate; set => SetProperty(ref _DueDate, value); }

        public System.TimeSpan? DueTime { get => _DueTime; set => SetProperty(ref _DueTime, value); }

        public System.Decimal? MaximumAttemptsAllowed { get => _MaximumAttemptsAllowed; set => SetProperty(ref _MaximumAttemptsAllowed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlagId"/> model
        /// </summary>
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        public System.DateTime? ReleaseDate { get => _ReleaseDate; set => SetProperty(ref _ReleaseDate, value); }

        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        public System.Decimal? PossiblePoints { get => _PossiblePoints; set => SetProperty(ref _PossiblePoints, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssignedByPersonId"/> model
        /// </summary>
        public Guid? AssignedByPersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="SchoolOrganizationId"/> model
        /// </summary>
        public Guid? SchoolOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LeaOrganizationId"/> model
        /// </summary>
        public Guid? LeaOrganizationId { get; set; }

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
        public void Load(ILearnerActivity model)
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
