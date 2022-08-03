//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicRecordViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicRecordViewModel
     /// </summary>
    public partial class K12StudentAcademicRecordViewModel : BindableBase, IK12StudentAcademicRecord
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

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
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaTypeId"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionTypeId"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatusId"/> model
        /// </summary>
        public Guid? RefTechnologyLiteracyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentActionId"/> model
        /// </summary>
        public Guid? RefPsEnrollmentActionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicatorId"/> model
        /// </summary>
        public Guid? RefPreAndPostTestIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialTypeId"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevelId"/> model
        /// </summary>
        public Guid? RefProgressLevelId { get; set; }

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
        public void Load(IK12StudentAcademicRecord model)
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
