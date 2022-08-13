//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IGoalMeasurementCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
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

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        System.Int32? AttemptsCount { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        Guid GoalMeasurementId { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        System.String Metric { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        System.Int32? SuccessCount { get; set; }

    }
}
