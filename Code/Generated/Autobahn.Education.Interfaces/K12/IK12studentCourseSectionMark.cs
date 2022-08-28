//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentCourseSectionMark.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12studentCourseSectionMark Interface
     /// </summary>
    public partial interface IK12studentCourseSectionMark : IAutobahnBase
    {
        #region IK12studentCourseSectionMark
        Boolean? FinalIndicator { get; set; }

        System.String GradeEarned { get; set; }

        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
        /// </summary>
        Guid K12studentCourseSectionId { get; set; }

        System.String MarkingPeriodName { get; set; }

        System.String MidTermMark { get; set; }

        System.String StudentCourseSectionGradeNarrative { get; set; }

        #endregion
    }
}
