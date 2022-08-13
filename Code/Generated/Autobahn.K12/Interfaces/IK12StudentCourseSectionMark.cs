//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentCourseSectionMark.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCourseSectionMark Interface
     /// </summary>
    public partial interface IK12StudentCourseSectionMark : IAutobahnBase
    {
        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.Boolean? FinalIndicator { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.String GradeEarned { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.String MarkingPeriodName { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.String MidTermMark { get; set; }

        /// <summary>
        /// A final indicator of student performance in a course section as submitted by the instructor.
        /// </summary>
        System.String StudentCourseSectionGradeNarrative { get; set; }

    }
}
