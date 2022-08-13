//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSectionMark Model
     /// </summary>
    public partial class K12StudentCourseSectionMarkModel : AutobahnBase, Interfaces.IK12StudentCourseSectionMark
    {
        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.Boolean? FinalIndicator { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.String MarkingPeriodName { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.String MidTermMark { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get; set; }

    }
}
