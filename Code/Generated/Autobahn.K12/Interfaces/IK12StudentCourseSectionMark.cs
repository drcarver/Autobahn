//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentCourseSectionMark.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCourseSectionMark
     /// </summary>
    public partial interface IK12StudentCourseSectionMark
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

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
