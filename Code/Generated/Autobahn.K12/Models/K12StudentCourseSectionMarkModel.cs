//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12StudentCourseSectionMark Model
     /// </summary>
    public partial class K12StudentCourseSectionMarkModel : AutobahnBase, Interfaces.IK12StudentCourseSectionMark
    {
        /// <summary>
        /// Student Course Section Mark Final Indicator
        /// <para>
        /// Indicates that the mark is a final mark the learner has earned for the course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20191">Student Course Section Mark Final Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? FinalIndicator { get; set; }

        /// <summary>
        /// Student Course Section Grade Earned
        /// <para>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19124">Student Course Section Grade Earned</a>
        /// </para>
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// Grade Value Qualifier
        /// <para>
        /// The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student's Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19609">Grade Value Qualifier</a>
        /// </para>
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Marking Period Name
        /// <para>
        /// The name or description of the marking period (e.g., fall, first marking period).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19182">Marking Period Name</a>
        /// </para>
        /// </summary>
        public System.String MarkingPeriodName { get; set; }

        /// <summary>
        /// Mid Term Mark
        /// <para>
        /// Indicator of student performance at the mid-point of the marking period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19183">Mid Term Mark</a>
        /// </para>
        /// </summary>
        public System.String MidTermMark { get; set; }

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
