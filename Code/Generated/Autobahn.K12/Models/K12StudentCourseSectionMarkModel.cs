//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCourseSectionMark Model
     /// </summary>
    public partial class K12StudentCourseSectionMarkModel : AutobahnBase, Interfaces.IK12StudentCourseSectionMarkModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
