//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalMeasurementCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalMeasurementCriterion Interface
     /// </summary>
    public partial interface IGoalMeasurementCriterion : IAutobahnBase
    {
        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        System.Decimal? AccuracyPercent { get; set; }

    }
}
