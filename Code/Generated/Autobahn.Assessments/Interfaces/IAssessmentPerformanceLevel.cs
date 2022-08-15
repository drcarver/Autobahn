//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPerformanceLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPerformanceLevel Interface
     /// </summary>
    public partial interface IAssessmentPerformanceLevel : IAutobahnBase
    {
        /// <summary>
        /// The metric or scale used for score reporting.
        /// </summary>
        System.String ScoreMetric { get; set; }

    }
}
