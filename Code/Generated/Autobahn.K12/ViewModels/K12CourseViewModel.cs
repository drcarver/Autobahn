//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the HighSchoolCourseRequirement property
        private System.Boolean? _HighSchoolCourseRequirement;

        // member variable for the AvailableCarnegieUnitCredit property
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // member variable for the CoreAcademicCourse property
        private System.Boolean? _CoreAcademicCourse;

        // member variable for the CourseAlignedWithStandards property
        private System.Boolean? _CourseAlignedWithStandards;

        // member variable for the FundingProgram property
        private System.String _FundingProgram;

        // member variable for the FamilyConsumerSciencesCourseInd property
        private System.Boolean? _FamilyConsumerSciencesCourseInd;

        // member variable for the SCEDCourseCode property
        private System.String _SCEDCourseCode;

        // member variable for the SCEDGradeSpan property
        private System.String _SCEDGradeSpan;

        // member variable for the CourseDepartmentName property
        private System.String _CourseDepartmentName;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // member variable for the RefAdditionalCreditTypeId property
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // member variable for the RefCurriculumFrameworkTypeId property
        private Guid? _RefCurriculumFrameworkTypeId;

        // member variable for the RefSCEDCourseLevelId property
        private Guid? _RefSCEDCourseLevelId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private Guid? _RefSCEDCourseSubjectAreaId;

        // member variable for the RefCareerClusterId property
        private Guid? _RefCareerClusterId;

        // member variable for the RefBlendedLearningModelTypeId property
        private Guid? _RefBlendedLearningModelTypeId;

        // member variable for the RefCourseInteractionModeId property
        private Guid? _RefCourseInteractionModeId;

        // member variable for the RefK12EndOfCourseRequirementId property
        private Guid? _RefK12EndOfCourseRequirementId;

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
        /// The title of the K12CourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        public System.Boolean? HighSchoolCourseRequirement { get => _HighSchoolCourseRequirement; set => SetProperty(ref _HighSchoolCourseRequirement, value); }

        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        public System.Boolean? CoreAcademicCourse { get => _CoreAcademicCourse; set => SetProperty(ref _CoreAcademicCourse, value); }

        public System.Boolean? CourseAlignedWithStandards { get => _CourseAlignedWithStandards; set => SetProperty(ref _CourseAlignedWithStandards, value); }

        public System.String FundingProgram  { get => _FundingProgram; set => SetProperty(ref _FundingProgram, value); }

        public System.Boolean? FamilyConsumerSciencesCourseInd { get => _FamilyConsumerSciencesCourseInd; set => SetProperty(ref _FamilyConsumerSciencesCourseInd, value); }

        public System.String SCEDCourseCode  { get => _SCEDCourseCode; set => SetProperty(ref _SCEDCourseCode, value); }

        public System.String SCEDGradeSpan  { get => _SCEDGradeSpan; set => SetProperty(ref _SCEDGradeSpan, value); }

        public System.String CourseDepartmentName  { get => _CourseDepartmentName; set => SetProperty(ref _CourseDepartmentName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarnedId"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkTypeId"/> model
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get => _RefCurriculumFrameworkTypeId; set => SetProperty(ref _RefCurriculumFrameworkTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevelId"/> model
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get => _RefSCEDCourseLevelId; set => SetProperty(ref _RefSCEDCourseLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectAreaId"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerClusterId"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelTypeId"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionModeId"/> model
        /// </summary>
        public Guid? RefCourseInteractionModeId { get => _RefCourseInteractionModeId; set => SetProperty(ref _RefCourseInteractionModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirementId"/> model
        /// </summary>
        public Guid? RefK12EndOfCourseRequirementId { get => _RefK12EndOfCourseRequirementId; set => SetProperty(ref _RefK12EndOfCourseRequirementId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Course model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseId = model.CourseId;
            HighSchoolCourseRequirement = model.HighSchoolCourseRequirement;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit;
            CoreAcademicCourse = model.CoreAcademicCourse;
            CourseAlignedWithStandards = model.CourseAlignedWithStandards;
            FundingProgram = model.FundingProgram;
            FamilyConsumerSciencesCourseInd = model.FamilyConsumerSciencesCourseInd;
            SCEDCourseCode = model.SCEDCourseCode;
            SCEDGradeSpan = model.SCEDGradeSpan;
            CourseDepartmentName = model.CourseDepartmentName;
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId;
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId;
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId;
            RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId;
            RefSCEDCourseLevelId = model.RefSCEDCourseLevelId;
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId;
            RefCareerClusterId = model.RefCareerClusterId;
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId;
            RefCourseInteractionModeId = model.RefCourseInteractionModeId;
            RefK12EndOfCourseRequirementId = model.RefK12EndOfCourseRequirementId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}