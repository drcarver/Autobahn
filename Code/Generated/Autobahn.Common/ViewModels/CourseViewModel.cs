//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseViewModel
     /// </summary>
    public partial class CourseViewModel : ViewModelBase, Interfaces.ICourse
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Course";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the SubjectAbbreviation property
        private System.String _SubjectAbbreviation;

        // member variable for the SCEDSequenceOfCourse property
        private System.String _SCEDSequenceOfCourse;

        // member variable for the InstructionalMinutes property
        private System.Int32? _InstructionalMinutes;

        // member variable for the CreditValue property
        private System.Decimal? _CreditValue;

        // member variable for the CertificationDescription property
        private System.String _CertificationDescription;

        // member variable for the RepeatabilityMaximumNumber property
        private System.Int32? _RepeatabilityMaximumNumber;

        // member variable for the RefCourseLevelCharacteristicsId property
        private Guid? _RefCourseLevelCharacteristicsId;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefInstructionLanguageId property
        private Guid? _RefInstructionLanguageId;

        // member variable for the RefCourseApplicableEducationLevelId property
        private Guid? _RefCourseApplicableEducationLevelId;

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
        /// The title of the CourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String SubjectAbbreviation  { get => _SubjectAbbreviation; set => SetProperty(ref _SubjectAbbreviation, value); }

        public System.String SCEDSequenceOfCourse  { get => _SCEDSequenceOfCourse; set => SetProperty(ref _SCEDSequenceOfCourse, value); }

        public System.Int32? InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        public System.Decimal? CreditValue { get => _CreditValue; set => SetProperty(ref _CreditValue, value); }

        public System.String CertificationDescription  { get => _CertificationDescription; set => SetProperty(ref _CertificationDescription, value); }

        public System.Int32? RepeatabilityMaximumNumber { get => _RepeatabilityMaximumNumber; set => SetProperty(ref _RepeatabilityMaximumNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristicsId"/> model
        /// </summary>
        public Guid? RefCourseLevelCharacteristicsId { get => _RefCourseLevelCharacteristicsId; set => SetProperty(ref _RefCourseLevelCharacteristicsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnitId"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguageId"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevelId"/> model
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get => _RefCourseApplicableEducationLevelId; set => SetProperty(ref _RefCourseApplicableEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourse model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            Description = model.Description;
            SubjectAbbreviation = model.SubjectAbbreviation;
            SCEDSequenceOfCourse = model.SCEDSequenceOfCourse;
            InstructionalMinutes = model.InstructionalMinutes;
            CreditValue = model.CreditValue;
            CertificationDescription = model.CertificationDescription;
            RepeatabilityMaximumNumber = model.RepeatabilityMaximumNumber;
            RefCourseLevelCharacteristicsId = model.RefCourseLevelCharacteristicsId;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            RefInstructionLanguageId = model.RefInstructionLanguageId;
            RefCourseApplicableEducationLevelId = model.RefCourseApplicableEducationLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
