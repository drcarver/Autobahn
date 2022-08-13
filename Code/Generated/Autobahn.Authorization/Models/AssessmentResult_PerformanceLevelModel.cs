//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResult_PerformanceLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevel Model
     /// </summary>
    public partial class AssessmentResult_PerformanceLevelModel : AutobahnBase, Interfaces.IAssessmentResult_PerformanceLevel
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
