//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseViewModel
     /// </summary>
    public partial class CourseViewModel : BindableBase, ICourse
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

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
        public Guid? RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnitId"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguageId"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevelId"/> model
        /// </summary>
        public Guid? RefCourseApplicableEducationLevelId { get; set; }

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
        public void Load(ICourse model)
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
