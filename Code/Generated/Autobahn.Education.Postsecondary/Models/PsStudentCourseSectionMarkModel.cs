//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Postsecondary;

namespace Autobahn.Education.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCourseSectionMark Model
     /// </summary>
    public partial class PsStudentCourseSectionMarkModel : IPsStudentCourseSectionMark
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IPsStudentCourseSectionMark
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
        /// Reference to an optional instance of the <see cref="IPsStudentSection"/> model
        /// </summary>
        public Guid PsStudentSectionId { get; set; }

        /// <summary>
        /// Course Academic Grade Status Code
        /// <para>
        /// Additional information regarding the context of the given grade.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
        /// </para>
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

        #endregion
    }
}
