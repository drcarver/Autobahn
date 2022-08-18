//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionViewModel.cs
//* Name:       Available Carnegie Unit Credit
//* Definition: Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
     /// </summary>
    public partial class CourseSectionViewModel : ViewModelBase, Interfaces.ICourseSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSection";

        // AvailableCarnegieUnitCredit -- (backing property for Available Carnegie Unit Credit)
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // member variable for the CourseId property
        private Guid _CourseId;

        // MaximumCapacity -- (backing property for Course Section Maximum Capacity)
        private System.Int32? _MaximumCapacity;

        // OrganizationCalendarSessionId -- (backing property for Course Begin Date)
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefAdditionalCreditTypeId -- (backing property for Additional Credit Type)
        private Guid? _RefAdditionalCreditTypeId;

        // RefAdvancedPlacementCourseCodeId -- (backing property for Advanced Placement Course Code)
        private Guid? _RefAdvancedPlacementCourseCodeId;

        // RefCourseSectionDeliveryModeId -- (backing property for Course Section Instructional Delivery Mode)
        private Guid? _RefCourseSectionDeliveryModeId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // RefInstructionLanguageId -- (backing property for Instruction Language)
        private Guid? _RefInstructionLanguageId;

        // RefSingleSexClassStatusId -- (backing property for Course Section Single Sex Class Status)
        private Guid? _RefSingleSexClassStatusId;

        // RelatedCompetencyDefinitions -- (backing property for Related Competency Definitions)
        private System.String _RelatedCompetencyDefinitions;

        // TimeRequiredForCompletion -- (backing property for Course Section Time Required for Completion)
        private System.Decimal? _TimeRequiredForCompletion;

        // VirtualIndicator -- (backing property for Virtual Indicator)
        private System.Boolean? _VirtualIndicator;

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
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Course Section Maximum Capacity
        /// <para>
        /// The maximum number of students the Course Section can maintain.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20636">Course Section Maximum Capacity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? MaximumCapacity { get => _MaximumCapacity; set => SetProperty(ref _MaximumCapacity, value); }

        /// <summary>
        /// Course Begin Date
        /// <para>
        /// The year, month and day an instance of a course officially began.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

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
        /// Advanced Placement Course Code
        /// <para>
        /// Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20244">Advanced Placement Course Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get => _RefAdvancedPlacementCourseCodeId; set => SetProperty(ref _RefAdvancedPlacementCourseCodeId, value); }

        /// <summary>
        /// Course Section Instructional Delivery Mode
        /// <para>
        /// The primary setting or medium of delivery for the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20168">Course Section Instructional Delivery Mode</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get => _RefCourseSectionDeliveryModeId; set => SetProperty(ref _RefCourseSectionDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Instruction Language
        /// <para>
        /// The language of instruction, other than English, used in the program or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Course Section Single Sex Class Status
        /// <para>
        /// Section in a co-educational school where only male or only female students are permitted to take the course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19258">Course Section Single Sex Class Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get => _RefSingleSexClassStatusId; set => SetProperty(ref _RefSingleSexClassStatusId, value); }

        /// <summary>
        /// Related Competency Definitions
        /// <para>
        /// An indication of the competency definition(s) addressed in the Course Section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19231">Related Competency Definitions</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RelatedCompetencyDefinitions { get => _RelatedCompetencyDefinitions; set => SetProperty(ref _RelatedCompetencyDefinitions, value); }

        /// <summary>
        /// Course Section Time Required for Completion
        /// <para>
        /// The actual or estimated number of clock minutes required for course completion. This number is especially important for career and technical education course and may represent (in minutes) the clock hour requirement of the course, the number of minutes (or clock hours) of class time per week, times the number of equivalent weeks the class typically meets.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19101">Course Section Time Required for Completion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? TimeRequiredForCompletion { get => _TimeRequiredForCompletion; set => SetProperty(ref _TimeRequiredForCompletion, value); }

        /// <summary>
        /// Virtual Indicator
        /// <para>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // Available Carnegie Unit Credit
            CourseId = model.CourseId; // 
            MaximumCapacity = model.MaximumCapacity; // Course Section Maximum Capacity
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // Course Begin Date
            OrganizationId = model.OrganizationId; // 
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
            RefAdvancedPlacementCourseCodeId = model.RefAdvancedPlacementCourseCodeId; // Advanced Placement Course Code
            RefCourseSectionDeliveryModeId = model.RefCourseSectionDeliveryModeId; // Course Section Instructional Delivery Mode
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
            RefInstructionLanguageId = model.RefInstructionLanguageId; // Instruction Language
            RefSingleSexClassStatusId = model.RefSingleSexClassStatusId; // Course Section Single Sex Class Status
            RelatedCompetencyDefinitions = model.RelatedCompetencyDefinitions; // Related Competency Definitions
            TimeRequiredForCompletion = model.TimeRequiredForCompletion; // Course Section Time Required for Completion
            VirtualIndicator = model.VirtualIndicator; // Virtual Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSingleSexClassStatus List
        /// <summary>
        /// The complete Available Carnegie Unit Credit List
        /// </summary>
        private static List<ReferenceModelBase> RefSingleSexClassStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8454c0c0-b6ab-41fe-8376-4d2d844ddd0e"), Code="MaleOnly", Description="Male-only", Definition="Male-only is specified for a section in a co-educational school where only male or only female students are permitted to take the course.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e36e9f4-215f-4558-933e-55eba94250bc"), Code="FemaleOnly", Description="Female-only", Definition="Female-only is specified for a section in a co-educational school where only male or only female students are permitted to take the course.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f946e35f-ddee-4f99-901e-05d42e2cfbce"), Code="NotSingleSex", Description="Not a single-sex class", Definition="Not a single-sex class is specified for a section in a co-educational school where only male or only female students are permitted to take the course.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
