//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoalMeasurementCriterion.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoalMeasurementCriterion
     /// </summary>
    public partial interface IGoalMeasurementCriterion : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalMeasurement"/> model
        /// </summary>
        Guid GoalMeasurementId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.AccuracyPercent nullable property
        /// </summary>
        System.Decimal? AccuracyPercent { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.AttemptsCount nullable property
        /// </summary>
        System.Int32? AttemptsCount { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.Metric non nullable property
        /// </summary>
        System.String Metric { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.SuccessCount nullable property
        /// </summary>
        System.Int32? SuccessCount { get; set; }

    }
}
