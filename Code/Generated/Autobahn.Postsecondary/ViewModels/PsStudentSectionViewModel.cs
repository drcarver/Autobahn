//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _AcademicGrade;

        // member variable for the CourseOverrideSchool property
        private  _CourseOverrideSchool;

        // member variable for the DegreeApplicability property
        private  _DegreeApplicability;

        // member variable for the NumberOfCreditsAttempted property
        private  _NumberOfCreditsAttempted;

        // member variable for the NumberOfCreditsEarned property
        private  _NumberOfCreditsEarned;

        // member variable for the QualityPointsEarned property
        private  _QualityPointsEarned;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseAcademicGradeStatusCodeId property
        private  _RefCourseAcademicGradeStatusCodeId;

        // member variable for the RefCourseRepeatCodeId property
        private  _RefCourseRepeatCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AcademicGrade { get => _AcademicGrade; set => SetProperty(ref _AcademicGrade, value); }

        /// <summary>
        /// </summary>
        public  CourseOverrideSchool { get => _CourseOverrideSchool; set => SetProperty(ref _CourseOverrideSchool, value); }

        /// <summary>
        /// </summary>
        public  DegreeApplicability { get => _DegreeApplicability; set => SetProperty(ref _DegreeApplicability, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsAttempted { get => _NumberOfCreditsAttempted; set => SetProperty(ref _NumberOfCreditsAttempted, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// </summary>
        public  QualityPointsEarned { get => _QualityPointsEarned; set => SetProperty(ref _QualityPointsEarned, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public  RefCourseAcademicGradeStatusCodeId { get => _RefCourseAcademicGradeStatusCodeId; set => SetProperty(ref _RefCourseAcademicGradeStatusCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public  RefCourseRepeatCodeId { get => _RefCourseRepeatCodeId; set => SetProperty(ref _RefCourseRepeatCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicGrade = model.AcademicGrade; // 
            CourseOverrideSchool = model.CourseOverrideSchool; // 
            DegreeApplicability = model.DegreeApplicability; // 
            NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // 
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // 
            QualityPointsEarned = model.QualityPointsEarned; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // 
            RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
