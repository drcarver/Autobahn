//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoal.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal
     /// </summary>
    public partial class IndividualizedProgramProgressGoal : IIndividualizedProgramProgressGoal
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalPerformance"/> model
        /// </summary>
        public Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReport"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressGoal.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressGoal.RecordEndDateTime nullable property
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
