//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   ICteCourse.cs
//* Name:       Available Carnegie Unit Credit
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CTE.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface ICteCourse : IAutobahnBase
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
        System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Core Academic Course
        /// <para>
        /// The course meets the state definition of a core academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
        /// </para>
        /// </summary>
        System.Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Course Aligned with Standards
        /// <para>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
        /// </para>
        /// </summary>
        System.Boolean? CourseAlignedWithStandards { get; set; }

        /// <summary>
        /// Course Department Name
        /// <para>
        /// Department with jurisdiction over this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20525">Course Department Name</a>
        /// </para>
        /// </summary>
        System.String CourseDepartmentName { get; set; }

        /// <summary>
        /// Course Certification Description
        /// <para>
        /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
        /// </para>
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// High School Course Requirement
        /// <para>
        /// An indication that this course credit is required for a high school diploma.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19137">High School Course Requirement</a>
        /// </para>
        /// </summary>
        System.Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
        /// </summary>
        Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseLevel"/> model
        /// </summary>
        Guid? RefSCEDCourseLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// School Courses for the Exchange of Data Course Code
        /// <para>
        /// The five-digit SCED code. The first two-digits of the code represent the Course Subject Area and the next three digits identify the course number. These identifiers are fairly general but provide enough specificity to identify the course's topic and to distinguish it from other courses in that subject area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20490">School Courses for the Exchange of Data Course Code</a>
        /// </para>
        /// </summary>
        System.String SCEDCourseCode { get; set; }

    }
}
