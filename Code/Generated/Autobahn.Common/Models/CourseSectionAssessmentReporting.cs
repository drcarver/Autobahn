//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionAssessmentReporting.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionAssessmentReporting
     /// </summary>
    public partial class CourseSectionAssessmentReporting : AutobahnBase, Interfaces.ICourseSectionAssessmentReporting
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
