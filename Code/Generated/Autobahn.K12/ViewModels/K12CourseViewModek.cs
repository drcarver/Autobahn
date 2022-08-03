//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CourseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CourseViewModel
     /// </summary>
    public partial class K12CourseViewModel : BindableBase, IK12Course
    {
#region "Backing Fields"
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
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicabilityId"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkTypeId"/> model
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevelId"/> model
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectAreaId"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerClusterId"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBlendedLearningModelTypeId"/> model
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInteractionModeId"/> model
        /// </summary>
        public Guid? RefCourseInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12EndOfCourseRequirementId"/> model
        /// </summary>
        public Guid? RefK12EndOfCourseRequirementId { get; set; }

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
        public void Load(IK12Course model)
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
