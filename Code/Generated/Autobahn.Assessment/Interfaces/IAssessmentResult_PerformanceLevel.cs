//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResult_PerformanceLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResult_PerformanceLevel
     /// </summary>
    public partial interface IAssessmentResult_PerformanceLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

    }
}
