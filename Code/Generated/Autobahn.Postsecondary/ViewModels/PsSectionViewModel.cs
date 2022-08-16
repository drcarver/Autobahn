//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionViewModel
     /// </summary>
    public partial class PsSectionViewModel : ViewModelBase, Interfaces.IPsSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSection";

        // member variable for the GradeValueQualifier property
        private  _GradeValueQualifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCourseGpaApplicabilityId property
        private  _RefCourseGpaApplicabilityId;

        // member variable for the RefCourseHonorsTypeId property
        private  _RefCourseHonorsTypeId;

        // member variable for the RefCourseInstructionMethodId property
        private  _RefCourseInstructionMethodId;

        // member variable for the RefCourseLevelTypeId property
        private  _RefCourseLevelTypeId;

        // member variable for the RefDevelopmentalEducationTypeId property
        private  _RefDevelopmentalEducationTypeId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private  _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

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
        /// Reference to an optional instance of the <see cref="RefCourseGpaApplicability"/> model
        /// </summary>
        public  RefCourseGpaApplicabilityId { get => _RefCourseGpaApplicabilityId; set => SetProperty(ref _RefCourseGpaApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsType"/> model
        /// </summary>
        public  RefCourseHonorsTypeId { get => _RefCourseHonorsTypeId; set => SetProperty(ref _RefCourseHonorsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethod"/> model
        /// </summary>
        public  RefCourseInstructionMethodId { get => _RefCourseInstructionMethodId; set => SetProperty(ref _RefCourseInstructionMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public  RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        public  RefDevelopmentalEducationTypeId { get => _RefDevelopmentalEducationTypeId; set => SetProperty(ref _RefDevelopmentalEducationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSection model)
        {
            IsBusy = true;
            Id = model.Id;
            GradeValueQualifier = model.GradeValueQualifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCipCodeId = model.RefCipCodeId; // 
            RefCourseGpaApplicabilityId = model.RefCourseGpaApplicabilityId; // 
            RefCourseHonorsTypeId = model.RefCourseHonorsTypeId; // 
            RefCourseInstructionMethodId = model.RefCourseInstructionMethodId; // 
            RefCourseLevelTypeId = model.RefCourseLevelTypeId; // 
            RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId; // 
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
