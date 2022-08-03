//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionAssessmentReporting.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionAssessmentReporting
     /// </summary>
    public partial class CourseSectionAssessmentReporting : ICourseSectionAssessmentReporting
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionAssessmentReportingMethod"/> model
        /// </summary>
        public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

        /// <summary>
        /// Defines the CourseSectionAssessmentReporting.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionAssessmentReporting.RecordEndDateTime nullable property
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
