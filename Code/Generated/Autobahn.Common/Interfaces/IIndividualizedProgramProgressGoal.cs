//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramProgressGoal.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressGoal
     /// </summary>
    public partial interface IIndividualizedProgramProgressGoal
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalPerformance"/> model
        /// </summary>
        Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReport"/> model
        /// </summary>
        Guid IndividualizedProgramProgressReportId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressGoal.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressGoal.RecordEndDateTime nullable property
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
