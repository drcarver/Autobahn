//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the ClassRankingDate property
        private  _ClassRankingDate;

        // member variable for the CreditsAttemptedCumulative property
        private  _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private  _CreditsEarnedCumulative;

        // member variable for the DiplomaOrCredentialAwardDate property
        private  _DiplomaOrCredentialAwardDate;

        // member variable for the GradePointAverageCumulative property
        private  _GradePointAverageCumulative;

        // member variable for the GradePointsEarnedCumulative property
        private  _GradePointsEarnedCumulative;

        // member variable for the HighSchoolStudentClassRank property
        private Guid? _HighSchoolStudentClassRank;

        // member variable for the ProjectedGraduationDate property
        private  _ProjectedGraduationDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefGpaWeightedIndicatorId property
        private  _RefGpaWeightedIndicatorId;

        // member variable for the RefHighSchoolDiplomaDistinctionTypeId property
        private  _RefHighSchoolDiplomaDistinctionTypeId;

        // member variable for the RefHighSchoolDiplomaTypeId property
        private  _RefHighSchoolDiplomaTypeId;

        // member variable for the RefPreAndPostTestIndicatorId property
        private  _RefPreAndPostTestIndicatorId;

        // member variable for the RefProfessionalTechnicalCredentialTypeId property
        private  _RefProfessionalTechnicalCredentialTypeId;

        // member variable for the RefProgressLevelId property
        private  _RefProgressLevelId;

        // member variable for the RefPsEnrollmentActionId property
        private  _RefPsEnrollmentActionId;

        // member variable for the RefTechnologyLiteracyStatusId property
        private  _RefTechnologyLiteracyStatusId;

        // member variable for the TotalNumberInClass property
        private  _TotalNumberInClass;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ClassRankingDate { get => _ClassRankingDate; set => SetProperty(ref _ClassRankingDate, value); }

        /// <summary>
        /// </summary>
        public  CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// </summary>
        public  CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        /// <summary>
        /// </summary>
        public  DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// </summary>
        public  GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        /// <summary>
        /// </summary>
        public  GradePointsEarnedCumulative { get => _GradePointsEarnedCumulative; set => SetProperty(ref _GradePointsEarnedCumulative, value); }

        /// <summary>
        /// </summary>
        public Guid? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        /// <summary>
        /// </summary>
        public  ProjectedGraduationDate { get => _ProjectedGraduationDate; set => SetProperty(ref _ProjectedGraduationDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public  RefGpaWeightedIndicatorId { get => _RefGpaWeightedIndicatorId; set => SetProperty(ref _RefGpaWeightedIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
        /// </summary>
        public  RefHighSchoolDiplomaDistinctionTypeId { get => _RefHighSchoolDiplomaDistinctionTypeId; set => SetProperty(ref _RefHighSchoolDiplomaDistinctionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        public  RefHighSchoolDiplomaTypeId { get => _RefHighSchoolDiplomaTypeId; set => SetProperty(ref _RefHighSchoolDiplomaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
        /// </summary>
        public  RefPreAndPostTestIndicatorId { get => _RefPreAndPostTestIndicatorId; set => SetProperty(ref _RefPreAndPostTestIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
        /// </summary>
        public  RefProgressLevelId { get => _RefProgressLevelId; set => SetProperty(ref _RefProgressLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
        /// </summary>
        public  RefPsEnrollmentActionId { get => _RefPsEnrollmentActionId; set => SetProperty(ref _RefPsEnrollmentActionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
        /// </summary>
        public  RefTechnologyLiteracyStatusId { get => _RefTechnologyLiteracyStatusId; set => SetProperty(ref _RefTechnologyLiteracyStatusId, value); }

        /// <summary>
        /// </summary>
        public  TotalNumberInClass { get => _TotalNumberInClass; set => SetProperty(ref _TotalNumberInClass, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassRankingDate = model.ClassRankingDate; // 
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // 
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // 
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
            GradePointAverageCumulative = model.GradePointAverageCumulative; // 
            GradePointsEarnedCumulative = model.GradePointsEarnedCumulative; // 
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // 
            ProjectedGraduationDate = model.ProjectedGraduationDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // 
            RefHighSchoolDiplomaDistinctionTypeId = model.RefHighSchoolDiplomaDistinctionTypeId; // 
            RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // 
            RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // 
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // 
            RefProgressLevelId = model.RefProgressLevelId; // 
            RefPsEnrollmentActionId = model.RefPsEnrollmentActionId; // 
            RefTechnologyLiteracyStatusId = model.RefTechnologyLiteracyStatusId; // 
            TotalNumberInClass = model.TotalNumberInClass; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
