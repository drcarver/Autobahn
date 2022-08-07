//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoalModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal Model
     /// </summary>
    public partial class IndividualizedProgramProgressGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressGoalModel
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
