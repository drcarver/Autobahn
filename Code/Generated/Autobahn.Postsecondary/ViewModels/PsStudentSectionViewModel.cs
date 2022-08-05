//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentSectionViewModel
     /// </summary>
    public partial class PsStudentSectionViewModel : ViewModelBase, Interfaces.IPsStudentSection
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentSection";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the CourseOverrideSchool property
        private System.String _CourseOverrideSchool;

        // member variable for the DegreeApplicability property
        private System.Boolean? _DegreeApplicability;

        // member variable for the AcademicGrade property
        private System.String _AcademicGrade;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the QualityPointsEarned property
        private System.Decimal? _QualityPointsEarned;

        // member variable for the RefCourseRepeatCodeId property
        private Guid? _RefCourseRepeatCodeId;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.String CourseOverrideSchool  { get => _CourseOverrideSchool; set => SetProperty(ref _CourseOverrideSchool, value); }

        public System.Boolean? DegreeApplicability { get => _DegreeApplicability; set => SetProperty(ref _DegreeApplicability, value); }

        public System.String AcademicGrade  { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        public System.Decimal? QualityPointsEarned { get => _QualityPointsEarned; set => SetProperty(ref _QualityPointsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCodeId"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCodeId"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            CourseOverrideSchool = model.CourseOverrideSchool;
            DegreeApplicability = model.DegreeApplicability;
            AcademicGrade = model.AcademicGrade;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            QualityPointsEarned = model.QualityPointsEarned;
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
