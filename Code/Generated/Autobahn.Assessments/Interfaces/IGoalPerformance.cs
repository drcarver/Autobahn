//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalPerformance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalPerformance Interface
     /// </summary>
    public partial interface IGoalPerformance : IAutobahnBase
    {
        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </summary>
        System.String CurrentPerformanceDescription { get; set; }

    }
}
