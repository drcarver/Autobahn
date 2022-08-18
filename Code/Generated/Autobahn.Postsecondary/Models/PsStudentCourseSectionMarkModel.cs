//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkModel.cs
//* Name:       Course Narrative Explanation Grade
//* Definition: The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
     /// </summary>
    public partial class PsStudentCourseSectionMarkModel : AutobahnBase, Interfaces.IPsStudentCourseSectionMark
    {
        /// <summary>
        /// Course Narrative Explanation Grade
        /// <para>
        /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20279">Course Narrative Explanation Grade</a>
        /// </para>
        /// </summary>
        public System.String CourseNarrativeExplanationGrade { get; set; }

        /// <summary>
        /// Course Academic Grade
        /// <para>
        /// The final grade awarded for participation in the course. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
        /// </para>
        /// </summary>
        public Guid PsStudentSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// Student Course Section Grade Narrative
        /// <para>
        /// The narrative of the student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
        /// </para>
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get; set; }

    }
}
