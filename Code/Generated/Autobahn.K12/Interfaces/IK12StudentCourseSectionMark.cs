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
        System.String GradeEarned { get; set; }

    }
}
