//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the CourseNumber property
        private System.String _CourseNumber;

        // member variable for the NCAAEligibilityInd property
        private System.Int32? _NCAAEligibilityInd;

        // member variable for the OriginalCourseIdentifier property
        private System.String _OriginalCourseIdentifier;

        // member variable for the OverrideSchoolCourseNumber property
        private System.String _OverrideSchoolCourseNumber;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCourseCreditBasisTypeId property
        private Guid? _RefCourseCreditBasisTypeId;

        // member variable for the RefCourseCreditLevelTypeId property
        private Guid? _RefCourseCreditLevelTypeId;

        // member variable for the RefNCESCollegeCourseMapCodeId property
        private Guid? _RefNCESCollegeCourseMapCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsCourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String CourseNumber { get => _CourseNumber; set => SetProperty(ref _CourseNumber, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.Int32? NCAAEligibilityInd { get => _NCAAEligibilityInd; set => SetProperty(ref _NCAAEligibilityInd, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String OriginalCourseIdentifier { get => _OriginalCourseIdentifier; set => SetProperty(ref _OriginalCourseIdentifier, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String OverrideSchoolCourseNumber { get => _OverrideSchoolCourseNumber; set => SetProperty(ref _OverrideSchoolCourseNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisType"/> model
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get => _RefCourseCreditBasisTypeId; set => SetProperty(ref _RefCourseCreditBasisTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelType"/> model
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get => _RefCourseCreditLevelTypeId; set => SetProperty(ref _RefCourseCreditLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCode"/> model
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get => _RefNCESCollegeCourseMapCodeId; set => SetProperty(ref _RefNCESCollegeCourseMapCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseId = model.CourseId;
            CourseNumber = model.CourseNumber;
            NCAAEligibilityInd = model.NCAAEligibilityInd;
            OriginalCourseIdentifier = model.OriginalCourseIdentifier;
            OverrideSchoolCourseNumber = model.OverrideSchoolCourseNumber;
            RefCipCodeId = model.RefCipCodeId;
            RefCourseCreditBasisTypeId = model.RefCourseCreditBasisTypeId;
            RefCourseCreditLevelTypeId = model.RefCourseCreditLevelTypeId;
            RefNCESCollegeCourseMapCodeId = model.RefNCESCollegeCourseMapCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
