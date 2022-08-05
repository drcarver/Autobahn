//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionAssessmentReporting.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionAssessmentReporting
     /// </summary>
    public partial interface ICourseSectionAssessmentReporting : IAutobahnBase
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
