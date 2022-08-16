//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResultPerformanceLevel Model
     /// </summary>
    public partial class AssessmentResultPerformanceLevelModel : AutobahnBase, Interfaces.IAssessmentResultPerformanceLevel
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
