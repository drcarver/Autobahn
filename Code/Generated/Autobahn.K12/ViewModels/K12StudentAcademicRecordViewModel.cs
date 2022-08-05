//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicRecordViewModel
     /// </summary>
    public partial class K12StudentAcademicRecordViewModel : ViewModelBase, Interfaces.IK12StudentAcademicRecord
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicRecord";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the CreditsAttemptedCumulative property
        private System.Decimal? _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private System.Decimal? _CreditsEarnedCumulative;

        // member variable for the GradePointsEarnedCumulative property
        private System.Decimal? _GradePointsEarnedCumulative;

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the ProjectedGraduationDate property
        private System.DateTime? _ProjectedGraduationDate;

        // member variable for the HighSchoolStudentClassRank property
        private System.Int32? _HighSchoolStudentClassRank;

        // member variable for the ClassRankingDate property
        private System.DateTime? _ClassRankingDate;

        // member variable for the TotalNumberInClass property
        private System.Int32? _TotalNumberInClass;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.DateTime? _DiplomaOrCredentialAwardDate;

        // member variable for the RefGpaWeightedIndicatorId property
        private Guid? _RefGpaWeightedIndicatorId;

        // member variable for the RefHighSchoolDiplomaTypeId property
        private Guid? _RefHighSchoolDiplomaTypeId;

        // member variable for the RefHighSchoolDiplomaDistinctionTypeId property
        private Guid? _RefHighSchoolDiplomaDistinctionTypeId;

        // member variable for the RefTechnologyLiteracyStatusId property
        private Guid? _RefTechnologyLiteracyStatusId;

        // member variable for the RefPsEnrollmentActionId property
        private Guid? _RefPsEnrollmentActionId;

        // member variable for the RefPreAndPostTestIndicatorId property
        private Guid? _RefPreAndPostTestIndicatorId;

        // member variable for the RefProfessionalTechnicalCredentialTypeId property
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

        // member variable for the RefProgressLevelId property
        private Guid? _RefProgressLevelId;

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
        /// The title of the K12StudentAcademicRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        public System.Decimal? CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        public System.Decimal? GradePointsEarnedCumulative { get => _GradePointsEarnedCumulative; set => SetProperty(ref _GradePointsEarnedCumulative, value); }

        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        public System.DateTime? ProjectedGraduationDate { get => _ProjectedGraduationDate; set => SetProperty(ref _ProjectedGraduationDate, value); }

        public System.Int32? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        public System.DateTime? ClassRankingDate { get => _ClassRankingDate; set => SetProperty(ref _ClassRankingDate, value); }

        public System.Int32? TotalNumberInClass { get => _TotalNumberInClass; set => SetProperty(ref _TotalNumberInClass, value); }

        public System.DateTime? DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicatorId"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get => _RefGpaWeightedIndicatorId; set => SetProperty(ref _RefGpaWeightedIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaTypeId"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get => _RefHighSchoolDiplomaTypeId; set => SetProperty(ref _RefHighSchoolDiplomaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionTypeId"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get => _RefHighSchoolDiplomaDistinctionTypeId; set => SetProperty(ref _RefHighSchoolDiplomaDistinctionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatusId"/> model
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get => _RefTechnologyLiteracyStatusId; set => SetProperty(ref _RefTechnologyLiteracyStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentActionId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get => _RefPsEnrollmentActionId; set => SetProperty(ref _RefPsEnrollmentActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicatorId"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialTypeId"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevelId"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative;
            CreditsEarnedCumulative = model.CreditsEarnedCumulative;
            GradePointsEarnedCumulative = model.GradePointsEarnedCumulative;
            GradePointAverageCumulative = model.GradePointAverageCumulative;
            ProjectedGraduationDate = model.ProjectedGraduationDate;
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank;
            ClassRankingDate = model.ClassRankingDate;
            TotalNumberInClass = model.TotalNumberInClass;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId;
            RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId;
            RefHighSchoolDiplomaDistinctionTypeId = model.RefHighSchoolDiplomaDistinctionTypeId;
            RefTechnologyLiteracyStatusId = model.RefTechnologyLiteracyStatusId;
            RefPsEnrollmentActionId = model.RefPsEnrollmentActionId;
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId;
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId;
            RefProgressLevelId = model.RefProgressLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}