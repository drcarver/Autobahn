//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSection View Model
     /// </summary>
    public partial class PsSectionViewModel : ViewModelBase, Interfaces.IPsSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSection";

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // GradeValueQualifier -- (backing property for Course Academic Grade Scale Code)
        private System.String _GradeValueQualifier;

        // RefCipCodeId -- (backing property for Classification of Instructional Program Code)
        private Guid? _RefCipCodeId;

        // member variable for the RefCourseGPAApplicabilityId property
        private Guid? _RefCourseGPAApplicabilityId;

        // RefCourseHonorsTypeId -- (backing property for Course Honors Type)
        private Guid? _RefCourseHonorsTypeId;

        // RefCourseInstructionMethodId -- (backing property for Course Instruction Method)
        private Guid? _RefCourseInstructionMethodId;

        // RefCourseLevelTypeId -- (backing property for Course Level Type)
        private Guid? _RefCourseLevelTypeId;

        // RefDevelopmentalEducationTypeId -- (backing property for Developmental Education Type)
        private Guid? _RefDevelopmentalEducationTypeId;

        // RefWorkbasedLearningOpportunityTypeId -- (backing property for Work-based Learning Opportunity Type)
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Course Academic Grade Scale Code
        /// <para>
        /// The grading scale used by an academic educational institution for an academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20264">Course Academic Grade Scale Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GradeValueQualifier { get => _GradeValueQualifier; set => SetProperty(ref _GradeValueQualifier, value); }

        /// <summary>
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        public Guid? RefCourseGPAApplicabilityId { get => _RefCourseGPAApplicabilityId; set => SetProperty(ref _RefCourseGPAApplicabilityId, value); }

        /// <summary>
        /// Course Honors Type
        /// <para>
        /// An indication that the course is or can be counted as an honors course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseHonorsTypeId { get => _RefCourseHonorsTypeId; set => SetProperty(ref _RefCourseHonorsTypeId, value); }

        /// <summary>
        /// Course Instruction Method
        /// <para>
        /// The primary method of instruction used for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseInstructionMethodId { get => _RefCourseInstructionMethodId; set => SetProperty(ref _RefCourseInstructionMethodId, value); }

        /// <summary>
        /// Course Level Type
        /// <para>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        /// <summary>
        /// Developmental Education Type
        /// <para>
        /// An indicator of the category of developmental education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDevelopmentalEducationTypeId { get => _RefDevelopmentalEducationTypeId; set => SetProperty(ref _RefDevelopmentalEducationTypeId, value); }

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

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSection model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId; // 
            GradeValueQualifier = model.GradeValueQualifier; // Course Academic Grade Scale Code
            RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
            RefCourseGPAApplicabilityId = model.RefCourseGPAApplicabilityId; // 
            RefCourseHonorsTypeId = model.RefCourseHonorsTypeId; // Course Honors Type
            RefCourseInstructionMethodId = model.RefCourseInstructionMethodId; // Course Instruction Method
            RefCourseLevelTypeId = model.RefCourseLevelTypeId; // Course Level Type
            RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId; // Developmental Education Type
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
