//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourseSectionAssessmentReporting.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourseSectionAssessmentReporting Interface
     /// </summary>
    public partial interface ICourseSectionAssessmentReporting : IAutobahnBase
    {
        /// <summary>
        /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
        /// </summary>
        Guid? CourseSectionId { get; set; }

        /// <summary>
        /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
        /// </summary>
        Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    }
}
