//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoal.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal
     /// </summary>
    public partial class IndividualizedProgramProgressGoal : AutobahnBase, Interfaces.IIndividualizedProgramProgressGoal
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
