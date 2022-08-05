//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResult_PerformanceLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentResult_PerformanceLevel
     /// </summary>
    public partial class AssessmentResult_PerformanceLevel : AutobahnBase, Interfaces.IAssessmentResult_PerformanceLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        public Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
