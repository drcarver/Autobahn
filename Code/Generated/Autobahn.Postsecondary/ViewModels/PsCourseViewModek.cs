//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsCourseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsCourseViewModel
     /// </summary>
    public partial class PsCourseViewModel : BindableBase, IPsCourse
    {
#region "Backing Fields"
        // member variable for the CourseNumber property
        private System.String _CourseNumber;

        // member variable for the OriginalCourseIdentifier property
        private System.String _OriginalCourseIdentifier;

        // member variable for the OverrideSchoolCourseNumber property
        private System.String _OverrideSchoolCourseNumber;

        // member variable for the NCAAEligibilityInd property
        private System.Int32? _NCAAEligibilityInd;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        public System.String CourseNumber  { get => _CourseNumber; set => SetProperty(ref _CourseNumber, value); }

        public System.String OriginalCourseIdentifier  { get => _OriginalCourseIdentifier; set => SetProperty(ref _OriginalCourseIdentifier, value); }

        public System.String OverrideSchoolCourseNumber  { get => _OverrideSchoolCourseNumber; set => SetProperty(ref _OverrideSchoolCourseNumber, value); }

        public System.Int32? NCAAEligibilityInd { get => _NCAAEligibilityInd; set => SetProperty(ref _NCAAEligibilityInd, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditBasisTypeId"/> model
        /// </summary>
        public Guid? RefCourseCreditBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditLevelTypeId"/> model
        /// </summary>
        public Guid? RefCourseCreditLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNCESCollegeCourseMapCodeId"/> model
        /// </summary>
        public Guid? RefNCESCollegeCourseMapCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

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
        public void Load(IPsCourse model)
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
