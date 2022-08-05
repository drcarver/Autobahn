//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentCourseSectionMark.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCourseSectionMark
     /// </summary>
    public partial interface IK12StudentCourseSectionMark : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.MarkingPeriodName non nullable property
        /// </summary>
        System.String MarkingPeriodName { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.FinalIndicator nullable property
        /// </summary>
        System.Boolean? FinalIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.GradeEarned non nullable property
        /// </summary>
        System.String GradeEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.MidTermMark non nullable property
        /// </summary>
        System.String MidTermMark { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.GradeValueQualifier non nullable property
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.StudentCourseSectionGradeNarrative non nullable property
        /// </summary>
        System.String StudentCourseSectionGradeNarrative { get; set; }

    }
}
