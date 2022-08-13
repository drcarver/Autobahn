//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   GoalMeasurementCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The GoalMeasurementCriterion Model
     /// </summary>
    public partial class GoalMeasurementCriterionModel : AutobahnBase, Interfaces.IGoalMeasurementCriterion
    {
        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Decimal? AccuracyPercent { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Int32? AttemptsCount { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public Guid GoalMeasurementId { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.String Metric { get; set; }

        /// <summary>
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Int32? SuccessCount { get; set; }

    }
}
