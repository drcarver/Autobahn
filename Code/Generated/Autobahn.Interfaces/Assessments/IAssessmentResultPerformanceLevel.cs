//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResultPerformanceLevel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentResultPerformanceLevel Interface
     /// </summary>
    public partial interface IAssessmentResultPerformanceLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

    }
}
