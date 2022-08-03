//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalMeasurement.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The GoalMeasurement
     /// </summary>
    public partial class GoalMeasurement : IGoalMeasurement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Schedule non nullable property
        /// </summary>
        public System.String Schedule { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.SuccessCriteria non nullable property
        /// </summary>
        public System.String SuccessCriteria { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        public Guid? RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.RecordEndDateTime nullable property
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
