//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionAssessmentReportingModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionAssessmentReporting Model
     /// </summary>
    public partial class CourseSectionAssessmentReportingModel : AutobahnBase, Interfaces.ICourseSectionAssessmentReportingModel
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
