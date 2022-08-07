//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The GoalMeasurementCriterion Model
     /// </summary>
    public partial class GoalMeasurementCriterionModel : AutobahnBase, Interfaces.IGoalMeasurementCriterionModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalMeasurement"/> model
        /// </summary>
        public Guid GoalMeasurementId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.AccuracyPercent nullable property
        /// </summary>
        public System.Decimal? AccuracyPercent { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.AttemptsCount nullable property
        /// </summary>
        public System.Int32? AttemptsCount { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.Metric non nullable property
        /// </summary>
        public System.String Metric { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.SuccessCount nullable property
        /// </summary>
        public System.Int32? SuccessCount { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
