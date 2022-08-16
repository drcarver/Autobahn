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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    }
}
