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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentResultId { get; set; }

    }
}
