//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoalMeasurement.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoalMeasurement
     /// </summary>
    public partial interface IGoalMeasurement
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.Schedule non nullable property
        /// </summary>
        System.String Schedule { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.SuccessCriteria non nullable property
        /// </summary>
        System.String SuccessCriteria { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalMeasurementType"/> model
        /// </summary>
        Guid? RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the GoalMeasurement.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
