//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionViewModel
     /// </summary>
    public partial class PsSectionViewModel : ViewModelBase, Interfaces.IPsSectionViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSection";

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // member variable for the GradeValueQualifier property
        private System.String _GradeValueQualifier;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // member variable for the RefCourseHonorsTypeId property
        private Guid? _RefCourseHonorsTypeId;

        // member variable for the RefCourseInstructionMethodId property
        private Guid? _RefCourseInstructionMethodId;

        // member variable for the RefCourseLevelTypeId property
        private Guid? _RefCourseLevelTypeId;

        // member variable for the RefDevelopmentalEducationTypeId property
        private Guid? _RefDevelopmentalEducationTypeId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

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
        /// The title of the PsSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        public System.String GradeValueQualifier  { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsTypeId"/> model
        /// </summary>
        public Guid? RefCourseHonorsTypeId { get => _RefCourseHonorsTypeId; set => SetProperty(ref _RefCourseHonorsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethodId"/> model
        /// </summary>
        public Guid? RefCourseInstructionMethodId { get => _RefCourseInstructionMethodId; set => SetProperty(ref _RefCourseInstructionMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelTypeId"/> model
        /// </summary>
        public Guid? RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationTypeId"/> model
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get => _RefDevelopmentalEducationTypeId; set => SetProperty(ref _RefDevelopmentalEducationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSection model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
