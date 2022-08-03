//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionMark.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSectionMark
     /// </summary>
    public partial class K12StudentCourseSectionMark : IK12StudentCourseSectionMark
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.MarkingPeriodName non nullable property
        /// </summary>
        public System.String MarkingPeriodName { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.FinalIndicator nullable property
        /// </summary>
        public System.Boolean? FinalIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.GradeEarned non nullable property
        /// </summary>
        public System.String GradeEarned { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.MidTermMark non nullable property
        /// </summary>
        public System.String MidTermMark { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.GradeValueQualifier non nullable property
        /// </summary>
        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.StudentCourseSectionGradeNarrative non nullable property
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentCourseSectionMark.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
