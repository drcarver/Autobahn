//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionAssessmentReportingModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionAssessmentReportingModel Interface
     /// </summary>
    public partial interface ICourseSectionAssessmentReportingModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionAssessmentReportingMethod"/> model
        /// </summary>
        Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    }
}
