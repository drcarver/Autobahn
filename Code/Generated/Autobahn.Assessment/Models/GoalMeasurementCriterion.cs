//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurementCriterion.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The GoalMeasurementCriterion
     /// </summary>
    public partial class GoalMeasurementCriterion : IGoalMeasurementCriterion
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
        /// Defines the GoalMeasurementCriterion.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the GoalMeasurementCriterion.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}