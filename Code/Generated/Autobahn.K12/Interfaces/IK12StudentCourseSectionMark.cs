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
        /// 
        /// </summary>
         FinalIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? GradeEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GradeValueQualifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MarkingPeriodName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MidTermMark { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StudentCourseSectionGradeNarrative { get; set; }

    }
}
