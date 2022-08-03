//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoalPerformance.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoalPerformance
     /// </summary>
    public partial interface IGoalPerformance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.CurrentPerformanceDescription non nullable property
        /// </summary>
        System.String CurrentPerformanceDescription { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.Date nullable property
        /// </summary>
        System.DateTime? Date { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.Status non nullable property
        /// </summary>
        System.String Status { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusType"/> model
        /// </summary>
        Guid? RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.RecordEndDateTime nullable property
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
