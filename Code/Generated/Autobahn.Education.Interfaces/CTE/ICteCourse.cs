//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   ICteCourse.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.CTE
{
     /// <summary>
     /// The ICteCourse Interface
     /// </summary>
    public partial interface ICteCourse : IAutobahnBase
    {
        #region ICteCourse
        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Core Academic Course
        /// <para>
        /// The course meets the state definition of a core academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
        /// </para>
        /// </summary>
        Boolean? CoreAcademicCourse { get; set; }

        /// <summary>
        /// Course Aligned with Standards
        /// <para>
        /// An indication whether a course is aligned with the established standards of a curriculum framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
        /// </para>
        /// </summary>
        Boolean? CourseAlignedWithStandards { get; set; }

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
        /// Reference to an optional instance of the <see cref="ICourse"/> model
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
        Boolean? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// Additional Credit Type
        /// <para>
        /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
        /// </para>
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
        /// </summary>
        Guid? RefCourseGpaapplicabilityId { get; set; }

        /// <summary>
        /// Credit Unit Type
        /// <para>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19072">Credit Unit Type</a>
        /// </para>
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Curriculum Framework Type
        /// <para>
        /// An indication of the standard curriculum used for this course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
        /// </para>
        /// </summary>
        Guid? RefCurriculumFrameworkTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
        /// </summary>
        Guid? RefScedcourseLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
        /// </summary>
        Guid? RefScedcourseSubjectAreaId { get; set; }

        System.String ScedcourseCode { get; set; }

        #endregion
    }
}