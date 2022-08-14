//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseViewModel
     /// </summary>
    public partial class CourseViewModel : ViewModelBase, Interfaces.ICourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Course";

        // member variable for the CertificationDescription property
        private System.String _CertificationDescription;

        // member variable for the CreditValue property
        private System.Decimal? _CreditValue;

        // member variable for the InstructionalMinutes property
        private System.Int32? _InstructionalMinutes;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefCourseApplicableEducationLevelId property
        private Guid? _RefCourseApplicableEducationLevelId;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefCourseLevelCharacteristicsId property
        private Guid? _RefCourseLevelCharacteristicsId;

        // member variable for the RefInstructionLanguageId property
        private Guid? _RefInstructionLanguageId;

        // member variable for the RepeatabilityMaximumNumber property
        private System.Int32? _RepeatabilityMaximumNumber;

        // member variable for the SCEDSequenceOfCourse property
        private System.String _SCEDSequenceOfCourse;

        // member variable for the SubjectAbbreviation property
        private System.String _SubjectAbbreviation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String CertificationDescription { get => _CertificationDescription; set => SetProperty(ref _CertificationDescription, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? CreditValue { get => _CreditValue; set => SetProperty(ref _CreditValue, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Int32? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevel"/> model
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get => _RefCourseApplicableEducationLevelId; set => SetProperty(ref _RefCourseApplicableEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristics"/> model
        /// </summary>
        public Guid? RefCourseLevelCharacteristicsId { get => _RefCourseLevelCharacteristicsId; set => SetProperty(ref _RefCourseLevelCharacteristicsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Int32? RepeatabilityMaximumNumber { get => _RepeatabilityMaximumNumber; set => SetProperty(ref _RepeatabilityMaximumNumber, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String SCEDSequenceOfCourse { get => _SCEDSequenceOfCourse; set => SetProperty(ref _SCEDSequenceOfCourse, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String SubjectAbbreviation { get => _SubjectAbbreviation; set => SetProperty(ref _SubjectAbbreviation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CertificationDescription = model.CertificationDescription;
            CreditValue = model.CreditValue;
            InstructionalMinutes = model.InstructionalMinutes;
            OrganizationId = model.OrganizationId;
            RefCourseApplicableEducationLevelId = model.RefCourseApplicableEducationLevelId;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            RefCourseLevelCharacteristicsId = model.RefCourseLevelCharacteristicsId;
            RefInstructionLanguageId = model.RefInstructionLanguageId;
            RepeatabilityMaximumNumber = model.RepeatabilityMaximumNumber;
            SCEDSequenceOfCourse = model.SCEDSequenceOfCourse;
            SubjectAbbreviation = model.SubjectAbbreviation;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
