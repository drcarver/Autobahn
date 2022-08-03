//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionViewModel
     /// </summary>
    public partial class PsSectionViewModel : BindableBase, IPsSection
    {
#region "Backing Fields"
        // member variable for the GradeValueQualifier property
        private System.String _GradeValueQualifier;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsTypeId"/> model
        /// </summary>
        public Guid? RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethodId"/> model
        /// </summary>
        public Guid? RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelTypeId"/> model
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationTypeId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

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
        public void Load(IPsSection model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            GradeValueQualifier = model.GradeValueQualifier;
            RefCipCodeId = model.RefCipCodeId;
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId;
            RefCourseHonorsTypeId = model.RefCourseHonorsTypeId;
            RefCourseInstructionMethodId = model.RefCourseInstructionMethodId;
            RefCourseLevelTypeId = model.RefCourseLevelTypeId;
            RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
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
