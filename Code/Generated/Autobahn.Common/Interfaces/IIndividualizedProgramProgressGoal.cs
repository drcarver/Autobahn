//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramProgressGoal.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressGoal
     /// </summary>
    public partial interface IIndividualizedProgramProgressGoal : IAutobahnBase
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
