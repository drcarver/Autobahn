//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CourseViewModel
     /// </summary>
    public partial class K12CourseViewModel : ViewModelBase, Interfaces.IK12Course
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Course";

        // member variable for the AvailableCarnegieUnitCredit property
        private  _AvailableCarnegieUnitCredit;

        // member variable for the CoreAcademicCourse property
        private  _CoreAcademicCourse;

        // member variable for the CourseAlignedWithStandards property
        private Guid? _CourseAlignedWithStandards;

        // member variable for the CourseDepartmentName property
        private  _CourseDepartmentName;

        // member variable for the FamilyConsumerSciencesCourseInd property
        private  _FamilyConsumerSciencesCourseInd;

        // member variable for the FundingProgram property
        private  _FundingProgram;

        // member variable for the HighSchoolCourseRequirement property
        private  _HighSchoolCourseRequirement;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdditionalCreditTypeId property
        private  _RefAdditionalCreditTypeId;

        // member variable for the RefBlendedLearningModelTypeId property
        private  _RefBlendedLearningModelTypeId;

        // member variable for the RefCareerClusterId property
        private  _RefCareerClusterId;

        // member variable for the RefCourseGpaApplicabilityId property
        private  _RefCourseGpaApplicabilityId;

        // member variable for the RefCourseInteractionModeId property
        private  _RefCourseInteractionModeId;

        // member variable for the RefCurriculumFrameworkTypeId property
        private  _RefCurriculumFrameworkTypeId;

        // member variable for the RefK12EndOfCourseRequirementId property
        private  _RefK12EndOfCourseRequirementId;

        // member variable for the RefSCEDCourseLevelId property
        private  _RefSCEDCourseLevelId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private  _RefSCEDCourseSubjectAreaId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private  _RefWorkbasedLearningOpportunityTypeId;

        // member variable for the SCEDCourseCode property
        private  _SCEDCourseCode;

        // member variable for the SCEDGradeSpan property
        private  _SCEDGradeSpan;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        /// <summary>
        /// </summary>
        public  CoreAcademicCourse { get => _CoreAcademicCourse; set => SetProperty(ref _CoreAcademicCourse, value); }

        /// <summary>
        /// </summary>
        public Guid? CourseAlignedWithStandards { get => _CourseAlignedWithStandards; set => SetProperty(ref _CourseAlignedWithStandards, value); }

        /// <summary>
        /// </summary>
        public  CourseDepartmentName { get => _CourseDepartmentName; set => SetProperty(ref _CourseDepartmentName, value); }

        /// <summary>
        /// </summary>
        public  FamilyConsumerSciencesCourseInd { get => _FamilyConsumerSciencesCourseInd; set => SetProperty(ref _FamilyConsumerSciencesCourseInd, value); }

        /// <summary>
        /// </summary>
        public  FundingProgram { get => _FundingProgram; set => SetProperty(ref _FundingProgram, value); }

        /// <summary>
        /// </summary>
        public  HighSchoolCourseRequirement { get => _HighSchoolCourseRequirement; set => SetProperty(ref _HighSchoolCourseRequirement, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public  RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
        /// </summary>
        public  RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public  RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGpaApplicability"/> model
        /// </summary>
        public  RefCourseGpaApplicabilityId { get => _RefCourseGpaApplicabilityId; set => SetProperty(ref _RefCourseGpaApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
        /// </summary>
        public  RefCourseInteractionModeId { get => _RefCourseInteractionModeId; set => SetProperty(ref _RefCourseInteractionModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
        /// </summary>
        public  RefCurriculumFrameworkTypeId { get => _RefCurriculumFrameworkTypeId; set => SetProperty(ref _RefCurriculumFrameworkTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirement"/> model
        /// </summary>
        public  RefK12EndOfCourseRequirementId { get => _RefK12EndOfCourseRequirementId; set => SetProperty(ref _RefK12EndOfCourseRequirementId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevel"/> model
        /// </summary>
        public  RefSCEDCourseLevelId { get => _RefSCEDCourseLevelId; set => SetProperty(ref _RefSCEDCourseLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public  RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        /// <summary>
        /// </summary>
        public  SCEDCourseCode { get => _SCEDCourseCode; set => SetProperty(ref _SCEDCourseCode, value); }

        /// <summary>
        /// </summary>
        public  SCEDGradeSpan { get => _SCEDGradeSpan; set => SetProperty(ref _SCEDGradeSpan, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Course model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // 
            CoreAcademicCourse = model.CoreAcademicCourse; // 
            CourseAlignedWithStandards = model.CourseAlignedWithStandards; // 
            CourseDepartmentName = model.CourseDepartmentName; // 
            FamilyConsumerSciencesCourseInd = model.FamilyConsumerSciencesCourseInd; // 
            FundingProgram = model.FundingProgram; // 
            HighSchoolCourseRequirement = model.HighSchoolCourseRequirement; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // 
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // 
            RefCareerClusterId = model.RefCareerClusterId; // 
            RefCourseGpaApplicabilityId = model.RefCourseGpaApplicabilityId; // 
            RefCourseInteractionModeId = model.RefCourseInteractionModeId; // 
            RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId; // 
            RefK12EndOfCourseRequirementId = model.RefK12EndOfCourseRequirementId; // 
            RefSCEDCourseLevelId = model.RefSCEDCourseLevelId; // 
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // 
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
            SCEDCourseCode = model.SCEDCourseCode; // 
            SCEDGradeSpan = model.SCEDGradeSpan; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
