//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CourseViewModel.cs
//* Name:       Available Carnegie Unit Credit
//* Definition: Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
     /// </summary>
    public partial class K12CourseViewModel : ViewModelBase, Interfaces.IK12Course
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Course";

        // AvailableCarnegieUnitCredit -- (backing property for Available Carnegie Unit Credit)
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // CoreAcademicCourse -- (backing property for Core Academic Course)
        private System.Boolean? _CoreAcademicCourse;

        // CourseAlignedWithStandards -- (backing property for Course Aligned with Standards)
        private System.Boolean? _CourseAlignedWithStandards;

        // CourseDepartmentName -- (backing property for Course Department Name)
        private System.String _CourseDepartmentName;

        // member variable for the CourseId property
        private Guid _CourseId;

        // FamilyConsumerSciencesCourseInd -- (backing property for Family and Consumer Sciences Course Indicator)
        private System.Boolean? _FamilyConsumerSciencesCourseInd;

        // FundingProgram -- (backing property for Course Funding Program)
        private System.String _FundingProgram;

        // HighSchoolCourseRequirement -- (backing property for High School Course Requirement)
        private System.Boolean? _HighSchoolCourseRequirement;

        // RefAdditionalCreditTypeId -- (backing property for Additional Credit Type)
        private Guid? _RefAdditionalCreditTypeId;

        // RefBlendedLearningModelTypeId -- (backing property for Blended Learning Model Type)
        private Guid? _RefBlendedLearningModelTypeId;

        // RefCareerClusterId -- (backing property for Career Cluster)
        private Guid? _RefCareerClusterId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // RefCourseInteractionModeId -- (backing property for Course Interaction Mode)
        private Guid? _RefCourseInteractionModeId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // RefCurriculumFrameworkTypeId -- (backing property for Curriculum Framework Type)
        private Guid? _RefCurriculumFrameworkTypeId;

        // RefK12EndOfCourseRequirementId -- (backing property for K12 End of Course Requirement)
        private Guid? _RefK12EndOfCourseRequirementId;

        // RefSCEDCourseLevelId -- (backing property for School Courses for the Exchange of Data Course Level)
        private Guid? _RefSCEDCourseLevelId;

        // RefSCEDCourseSubjectAreaId -- (backing property for School Courses for the Exchange of Data Course Subject Area)
        private Guid? _RefSCEDCourseSubjectAreaId;

        // RefWorkbasedLearningOpportunityTypeId -- (backing property for Work-based Learning Opportunity Type)
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        // SCEDCourseCode -- (backing property for School Courses for the Exchange of Data Course Code)
        private System.String _SCEDCourseCode;

        // SCEDGradeSpan -- (backing property for School Courses for the Exchange of Data Grade Span)
        private System.String _SCEDGradeSpan;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        /// <summary>
        /// Core Academic Course
        /// <para>
        /// The course meets the state definition of a core academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CoreAcademicCourse { get => _CoreAcademicCourse; set => SetProperty(ref _CoreAcademicCourse, value); }

        /// <summary>
        /// Course Aligned with Standards
        /// <para>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CourseAlignedWithStandards { get => _CourseAlignedWithStandards; set => SetProperty(ref _CourseAlignedWithStandards, value); }

        /// <summary>
        /// Course Department Name
        /// <para>
        /// Department with jurisdiction over this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20525">Course Department Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseDepartmentName { get => _CourseDepartmentName; set => SetProperty(ref _CourseDepartmentName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Family and Consumer Sciences Course Indicator
        /// <para>
        /// An indication that the course is associated with the Family and Consumer Sciences plan of study.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20311">Family and Consumer Sciences Course Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FamilyConsumerSciencesCourseInd { get => _FamilyConsumerSciencesCourseInd; set => SetProperty(ref _FamilyConsumerSciencesCourseInd, value); }

        /// <summary>
        /// Course Funding Program
        /// <para>
        /// A program through which the course is funded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20272">Course Funding Program</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FundingProgram { get => _FundingProgram; set => SetProperty(ref _FundingProgram, value); }

        /// <summary>
        /// High School Course Requirement
        /// <para>
        /// An indication that this course credit is required for a high school diploma.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19137">High School Course Requirement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? HighSchoolCourseRequirement { get => _HighSchoolCourseRequirement; set => SetProperty(ref _HighSchoolCourseRequirement, value); }

        /// <summary>
        /// Additional Credit Type
        /// <para>
        /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Blended Learning Model Type
        /// <para>
        /// A type of formal education program in which a student learns at least in part through online learning, with some element of student control over time, place, path, and/or pace; at least in part in a supervised brick-and-mortar location away from home; and the modalities along each student's learning path within a course or subject are connected to provide an integrated learning experience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20253">Blended Learning Model Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBlendedLearningModelTypeId { get => _RefBlendedLearningModelTypeId; set => SetProperty(ref _RefBlendedLearningModelTypeId, value); }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Course Interaction Mode
        /// <para>
        /// The primary type of interaction, synchronous or asynchronous, defined for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20277">Course Interaction Mode</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseInteractionModeId { get => _RefCourseInteractionModeId; set => SetProperty(ref _RefCourseInteractionModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Curriculum Framework Type
        /// <para>
        /// An indication of the standard curriculum used for this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCurriculumFrameworkTypeId { get => _RefCurriculumFrameworkTypeId; set => SetProperty(ref _RefCurriculumFrameworkTypeId, value); }

        /// <summary>
        /// K12 End of Course Requirement
        /// <para>
        /// An indication that this course has an end of course examination required by the SEA or LEA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20355">K12 End of Course Requirement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefK12EndOfCourseRequirementId { get => _RefK12EndOfCourseRequirementId; set => SetProperty(ref _RefK12EndOfCourseRequirementId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Level
        /// <para>
        ///  The course's level of rigor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20488">School Courses for the Exchange of Data Course Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSCEDCourseLevelId { get => _RefSCEDCourseLevelId; set => SetProperty(ref _RefSCEDCourseLevelId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Subject Area
        /// <para>
        /// The intended major subject area of the education course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20491">School Courses for the Exchange of Data Course Subject Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        /// <summary>
        /// Work-based Learning Opportunity Type
        /// <para>
        /// The type of work-based learning opportunity a student participated in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Code
        /// <para>
        /// The five-digit SCED code. The first two-digits of the code represent the Course Subject Area and the next three digits identify the course number. These identifiers are fairly general but provide enough specificity to identify the course's topic and to distinguish it from other courses in that subject area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20490">School Courses for the Exchange of Data Course Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SCEDCourseCode { get => _SCEDCourseCode; set => SetProperty(ref _SCEDCourseCode, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Grade Span
        /// <para>
        /// The grade span for which the course is appropriate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20452">School Courses for the Exchange of Data Grade Span</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SCEDGradeSpan { get => _SCEDGradeSpan; set => SetProperty(ref _SCEDGradeSpan, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Course model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // Available Carnegie Unit Credit
            CoreAcademicCourse = model.CoreAcademicCourse; // Core Academic Course
            CourseAlignedWithStandards = model.CourseAlignedWithStandards; // Course Aligned with Standards
            CourseDepartmentName = model.CourseDepartmentName; // Course Department Name
            CourseId = model.CourseId; // 
            FamilyConsumerSciencesCourseInd = model.FamilyConsumerSciencesCourseInd; // Family and Consumer Sciences Course Indicator
            FundingProgram = model.FundingProgram; // Course Funding Program
            HighSchoolCourseRequirement = model.HighSchoolCourseRequirement; // High School Course Requirement
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
            RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // Blended Learning Model Type
            RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId; // 
            RefCourseInteractionModeId = model.RefCourseInteractionModeId; // Course Interaction Mode
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
            RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId; // Curriculum Framework Type
            RefK12EndOfCourseRequirementId = model.RefK12EndOfCourseRequirementId; // K12 End of Course Requirement
            RefSCEDCourseLevelId = model.RefSCEDCourseLevelId; // School Courses for the Exchange of Data Course Level
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // School Courses for the Exchange of Data Course Subject Area
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
            SCEDCourseCode = model.SCEDCourseCode; // School Courses for the Exchange of Data Course Code
            SCEDGradeSpan = model.SCEDGradeSpan; // School Courses for the Exchange of Data Grade Span
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefCourseGpaApplicability List
        /// <summary>
        /// The complete Available Carnegie Unit Credit List
        /// </summary>
        private static List<ReferenceModelBase> RefCourseGpaApplicabilityList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a579c0ad-c4c9-4c12-8ff8-b2ef77421dc3"), Code="Applicable", Description="Applicable in GPA", Definition="The course being described is included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c47dc3a5-05c7-4c71-9284-ecc2f9ab452f"), Code="NotApplicable", Description="Not Applicable in GPA", Definition="The course being described is not included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6a717114-6a55-4b28-9948-050c9fde319e"), Code="Weighted", Description="Weighted in GPA", Definition="The course being described is weighted in the computation of the student's Grade Point Average (GPA)", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefK12EndOfCourseRequirement List
        /// <summary>
        /// The complete Available Carnegie Unit Credit List
        /// </summary>
        private static List<ReferenceModelBase> RefK12EndOfCourseRequirementList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("7458a5cd-d897-4ed4-badd-2fdd5128d57c"), Code="LEAOnly", Description="LEA only", Definition="This course has an end of course examination required by the LEA only.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("11915b8a-9384-4447-a4c2-8b23c7b74219"), Code="SEAOnly", Description="SEA only", Definition="This course has an end of course examination required by the SEA only.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("105a977f-fa8d-4ded-a845-e7e5a9160e4b"), Code="Both", Description="LEA and SEA", Definition="This course has an end of course examination required by the LEA and SEA.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d528ad1-a2e5-4f16-809b-762a064ccebd"), Code="Neither", Description="Neither LEA or SEA", Definition="This course has an end of course examination required by neither the LEA or SEA.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefSCEDCourseLevel List
        /// <summary>
        /// The complete Available Carnegie Unit Credit List
        /// </summary>
        private static List<ReferenceModelBase> RefSCEDCourseLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2416c929-31b1-43b4-a186-63701c1020ca"), Code="B", Description="Basic or remedial", Definition="The course's level of rigor is basic or remedial.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("82bb7cf4-7dce-4f49-ae02-32db511d5329"), Code="E", Description="Enriched or advanced", Definition="The course's level of rigor is enriched or advanced.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c7b0e632-825e-4096-bb32-659e8c4b34fb"), Code="G", Description="General or regular", Definition="The course's level of rigor is general or regular.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("a91f2810-57f3-44ad-9545-5f924e417de8"), Code="H", Description="Honors", Definition="The course's level of rigor is honors.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("83208056-8f32-42ae-85e3-633a904feb3e"), Code="C", Description="College", Definition="The course's level of rigor is college.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("c4c25c8a-8963-4c39-a66d-d39990aa9110"), Code="X", Description="No specified level of rigor", Definition="The course has no specified level of rigor.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion

        #region RefWorkbasedLearningOpportunityType List
        /// <summary>
        /// The complete Available Carnegie Unit Credit List
        /// </summary>
        private static List<ReferenceModelBase> RefWorkbasedLearningOpportunityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("995f8141-50c4-4257-ba9b-0cd46e021100"), Code="Apprenticeship", Description="Apprenticeship", Definition="Apprenticeship is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("29600457-b19d-4bbd-b268-11437b78744e"), Code="ClinicalWork", Description="Clinical work experience", Definition="Clinical work experience is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("5178e797-edbc-4f79-b358-688c565a84ef"), Code="CooperativeEducation", Description="Cooperative education", Definition="Cooperative education is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("112a6de0-8ee8-47c7-8c40-a1a6f1b81868"), Code="JobShadowing", Description="Job shadowing", Definition="Job shadowing is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("244f26c8-bdb8-46a9-aff4-47c8707faae7"), Code="Mentorship", Description="Mentorship", Definition="Mentorship is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("bafa480f-f4f4-4ea6-af86-01edd35c1063"), Code="NonPaidInternship", Description="Non-Paid Internship", Definition="Non-Paid Internship is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c7daf32-9d94-4243-ad06-a31ceb8667ed"), Code="OnTheJob", Description="On-the-Job", Definition="On-the-Job is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("42bf8e0b-e6ba-4c2d-aed4-f7a13369f24f"), Code="PaidInternship", Description="Paid internship", Definition="Paid internship is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("66e8fa52-b8e0-4137-8fe5-ba2b07944445"), Code="ServiceLearning", Description="Service learning", Definition="Service learning is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("4140fd52-2f6a-42f0-9e64-63952fe80d1f"), Code="SupervisedAgricultural", Description="Supervised agricultural experience", Definition="Supervised agricultural experience is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("2bf5bf29-f3fd-4a97-8333-bf11b1f4cca9"), Code="UnpaidInternship", Description="Unpaid internship", Definition="Unpaid internship is the type of work-based learning opportunity the student participated in.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("a56c4c73-bb35-4990-be94-432042d54ab6"), Code="Other", Description="Other", Definition="The type of work-based learning opportunity the student participated in is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
