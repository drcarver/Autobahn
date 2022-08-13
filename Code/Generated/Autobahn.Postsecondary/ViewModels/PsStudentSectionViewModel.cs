//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the AcademicGrade property
        private System.String _AcademicGrade;

        // member variable for the CourseOverrideSchool property
        private System.String _CourseOverrideSchool;

        // member variable for the DegreeApplicability property
        private System.Boolean? _DegreeApplicability;

        // member variable for the NumberOfCreditsAttempted property
        private System.Decimal? _NumberOfCreditsAttempted;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the QualityPointsEarned property
        private System.Decimal? _QualityPointsEarned;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private Guid? _RefCourseAcademicGradeStatusCodeId;

        // member variable for the RefCourseRepeatCodeId property
        private Guid? _RefCourseRepeatCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.String AcademicGrade { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.String CourseOverrideSchool { get => _CourseOverrideSchool; set => SetProperty(ref _CourseOverrideSchool, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Boolean? DegreeApplicability { get => _DegreeApplicability; set => SetProperty(ref _DegreeApplicability, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? QualityPointsEarned { get => _QualityPointsEarned; set => SetProperty(ref _QualityPointsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicGrade = model.AcademicGrade;
            CourseOverrideSchool = model.CourseOverrideSchool;
            DegreeApplicability = model.DegreeApplicability;
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            QualityPointsEarned = model.QualityPointsEarned;
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId;
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
