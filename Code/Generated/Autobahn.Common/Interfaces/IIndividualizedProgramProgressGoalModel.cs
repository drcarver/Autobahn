//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramProgressGoalModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressGoalModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressGoalModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalPerformance"/> model
        /// </summary>
        Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReport"/> model
        /// </summary>
        Guid IndividualizedProgramProgressReportId { get; set; }

    }
}
