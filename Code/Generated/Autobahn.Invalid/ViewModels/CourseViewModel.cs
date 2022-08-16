//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _CertificationDescription;

        // member variable for the CreditValue property
        private  _CreditValue;

        // member variable for the Description property
        private  _Description;

        // member variable for the InstructionalMinutes property
        private  _InstructionalMinutes;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseApplicableEducationLevelId property
        private  _RefCourseApplicableEducationLevelId;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefCourseLevelCharacteristicsId property
        private  _RefCourseLevelCharacteristicsId;

        // member variable for the RefInstructionLanguageId property
        private  _RefInstructionLanguageId;

        // member variable for the RepeatabilityMaximumNumber property
        private  _RepeatabilityMaximumNumber;

        // member variable for the SCEDSequenceOfCourse property
        private  _SCEDSequenceOfCourse;

        // member variable for the SubjectAbbreviation property
        private  _SubjectAbbreviation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CertificationDescription { get => _CertificationDescription; set => SetProperty(ref _CertificationDescription, value); }

        /// <summary>
        /// </summary>
        public  CreditValue { get => _CreditValue; set => SetProperty(ref _CreditValue, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  InstructionalMinutes { get => _InstructionalMinutes; set => SetProperty(ref _InstructionalMinutes, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevel"/> model
        /// </summary>
        public  RefCourseApplicableEducationLevelId { get => _RefCourseApplicableEducationLevelId; set => SetProperty(ref _RefCourseApplicableEducationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristics"/> model
        /// </summary>
        public  RefCourseLevelCharacteristicsId { get => _RefCourseLevelCharacteristicsId; set => SetProperty(ref _RefCourseLevelCharacteristicsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public  RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// </summary>
        public  RepeatabilityMaximumNumber { get => _RepeatabilityMaximumNumber; set => SetProperty(ref _RepeatabilityMaximumNumber, value); }

        /// <summary>
        /// </summary>
        public  SCEDSequenceOfCourse { get => _SCEDSequenceOfCourse; set => SetProperty(ref _SCEDSequenceOfCourse, value); }

        /// <summary>
        /// </summary>
        public  SubjectAbbreviation { get => _SubjectAbbreviation; set => SetProperty(ref _SubjectAbbreviation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CertificationDescription = model.CertificationDescription; // 
            CreditValue = model.CreditValue; // 
            Description = model.Description; // 
            InstructionalMinutes = model.InstructionalMinutes; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseApplicableEducationLevelId = model.RefCourseApplicableEducationLevelId; // 
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // 
            RefCourseLevelCharacteristicsId = model.RefCourseLevelCharacteristicsId; // 
            RefInstructionLanguageId = model.RefInstructionLanguageId; // 
            RepeatabilityMaximumNumber = model.RepeatabilityMaximumNumber; // 
            SCEDSequenceOfCourse = model.SCEDSequenceOfCourse; // 
            SubjectAbbreviation = model.SubjectAbbreviation; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
