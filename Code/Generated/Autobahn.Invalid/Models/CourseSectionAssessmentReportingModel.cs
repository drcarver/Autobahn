//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionAssessmentReportingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CourseSectionAssessmentReporting Model
     /// </summary>
    public partial class CourseSectionAssessmentReportingModel : AutobahnBase, Interfaces.ICourseSectionAssessmentReporting
    {
        /// <summary>
        /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
        /// </summary>
        public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    }
}
