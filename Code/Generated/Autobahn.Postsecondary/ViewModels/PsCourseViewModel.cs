//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsCourseViewModel
     /// </summary>
    public partial class PsCourseViewModel : ViewModelBase, Interfaces.IPsCourseViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsCourse";

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the CourseNumber property
        private System.String _CourseNumber;

        // member variable for the OriginalCourseIdentifier property
        private System.String _OriginalCourseIdentifier;

        // member variable for the OverrideSchoolCourseNumber property
        private System.String _OverrideSchoolCourseNumber;

        // member variable for the NCAAEligibilityInd property
        private System.Int32? _NCAAEligibilityInd;

        // member variable for the RefCourseCreditBasisTypeId property
        private Guid? _RefCourseCreditBasisTypeId;

        // member variable for the RefCourseCreditLevelTypeId property
        private Guid? _RefCourseCreditLevelTypeId;

        // member variable for the RefNCESCollegeCourseMapCodeId property
        private Guid? _RefNCESCollegeCourseMapCodeId;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

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
        /// The title of the PsCourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        public System.String CourseNumber  { get => _CourseNumber; set => SetProperty(ref _CourseNumber, value); }

        public System.String OriginalCourseIdentifier  { get => _OriginalCourseIdentifier; set => SetProperty(ref _OriginalCourseIdentifier, value); }

        public System.String OverrideSchoolCourseNumber  { get => _OverrideSchoolCourseNumber; set => SetProperty(ref _OverrideSchoolCourseNumber, value); }

        public System.Int32? NCAAEligibilityInd { get => _NCAAEligibilityInd; set => SetProperty(ref _NCAAEligibilityInd, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisTypeId"/> model
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get => _RefCourseCreditBasisTypeId; set => SetProperty(ref _RefCourseCreditBasisTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelTypeId"/> model
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get => _RefCourseCreditLevelTypeId; set => SetProperty(ref _RefCourseCreditLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCodeId"/> model
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get => _RefNCESCollegeCourseMapCodeId; set => SetProperty(ref _RefNCESCollegeCourseMapCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

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
            OriginalCourseIdentifier = model.OriginalCourseIdentifier;
            OverrideSchoolCourseNumber = model.OverrideSchoolCourseNumber;
            NCAAEligibilityInd = model.NCAAEligibilityInd;
            RefCourseCreditBasisTypeId = model.RefCourseCreditBasisTypeId;
            RefCourseCreditLevelTypeId = model.RefCourseCreditLevelTypeId;
            RefNCESCollegeCourseMapCodeId = model.RefNCESCollegeCourseMapCodeId;
            RefCipCodeId = model.RefCipCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
