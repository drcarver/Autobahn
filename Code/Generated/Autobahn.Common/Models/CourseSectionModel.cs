//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionModel.cs
//* Name:       Available Carnegie Unit Credit
//* Definition: Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
     /// </summary>
    public partial class CourseSectionModel : AutobahnBase, Interfaces.ICourseSection
    {
        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Course Section Maximum Capacity
        /// <para>
        /// The maximum number of students the Course Section can maintain.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20636">Course Section Maximum Capacity</a>
        /// </para>
        /// </summary>
        public System.Int32? MaximumCapacity { get; set; }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdvancedPlacementCourseCode"/> model
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseSectionDeliveryMode"/> model
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSingleSexClassStatus"/> model
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// Related Competency Definitions
        /// <para>
        /// An indication of the competency definition(s) addressed in the Course Section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19231">Related Competency Definitions</a>
        /// </para>
        /// </summary>
        public System.String RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// Course Section Time Required for Completion
        /// <para>
        /// The actual or estimated number of clock minutes required for course completion. This number is especially important for career and technical education course and may represent (in minutes) the clock hour requirement of the course, the number of minutes (or clock hours) of class time per week, times the number of equivalent weeks the class typically meets.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19101">Course Section Time Required for Completion</a>
        /// </para>
        /// </summary>
        public System.Decimal? TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// Virtual Indicator
        /// <para>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? VirtualIndicator { get; set; }

    }
}
