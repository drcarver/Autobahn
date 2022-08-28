//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResultPerformanceLevel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentResultPerformanceLevel Interface
     /// </summary>
    public partial interface IAssessmentResultPerformanceLevel : IAutobahnBase
    {
        #region IAssessmentResultPerformanceLevel
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        #endregion
    }
}
