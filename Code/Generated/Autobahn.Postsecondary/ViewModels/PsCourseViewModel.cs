//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsCourseViewModel
     /// </summary>
    public partial class PsCourseViewModel : ViewModelBase, Interfaces.IPsCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsCourse";

        // member variable for the CourseNumber property
        private  _CourseNumber;

        // member variable for the NCAAEligibilityInd property
        private  _NCAAEligibilityInd;

        // member variable for the OriginalCourseIdentifier property
        private  _OriginalCourseIdentifier;

        // member variable for the OverrideSchoolCourseNumber property
        private  _OverrideSchoolCourseNumber;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCourseCreditBasisTypeId property
        private  _RefCourseCreditBasisTypeId;

        // member variable for the RefCourseCreditLevelTypeId property
        private  _RefCourseCreditLevelTypeId;

        // member variable for the RefNCESCollegeCourseMapCodeId property
        private  _RefNCESCollegeCourseMapCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CourseNumber { get => _CourseNumber; set => SetProperty(ref _CourseNumber, value); }

        /// <summary>
        /// </summary>
        public  NCAAEligibilityInd { get => _NCAAEligibilityInd; set => SetProperty(ref _NCAAEligibilityInd, value); }

        /// <summary>
        /// </summary>
        public  OriginalCourseIdentifier { get => _OriginalCourseIdentifier; set => SetProperty(ref _OriginalCourseIdentifier, value); }

        /// <summary>
        /// </summary>
        public  OverrideSchoolCourseNumber { get => _OverrideSchoolCourseNumber; set => SetProperty(ref _OverrideSchoolCourseNumber, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisType"/> model
        /// </summary>
        public  RefCourseCreditBasisTypeId { get => _RefCourseCreditBasisTypeId; set => SetProperty(ref _RefCourseCreditBasisTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelType"/> model
        /// </summary>
        public  RefCourseCreditLevelTypeId { get => _RefCourseCreditLevelTypeId; set => SetProperty(ref _RefCourseCreditLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCode"/> model
        /// </summary>
        public  RefNCESCollegeCourseMapCodeId { get => _RefNCESCollegeCourseMapCodeId; set => SetProperty(ref _RefNCESCollegeCourseMapCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseNumber = model.CourseNumber; // 
            NCAAEligibilityInd = model.NCAAEligibilityInd; // 
            OriginalCourseIdentifier = model.OriginalCourseIdentifier; // 
            OverrideSchoolCourseNumber = model.OverrideSchoolCourseNumber; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCipCodeId = model.RefCipCodeId; // 
            RefCourseCreditBasisTypeId = model.RefCourseCreditBasisTypeId; // 
            RefCourseCreditLevelTypeId = model.RefCourseCreditLevelTypeId; // 
            RefNCESCollegeCourseMapCodeId = model.RefNCESCollegeCourseMapCodeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
