//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoalPerformance.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoalPerformance
     /// </summary>
    public partial interface IGoalPerformance : IAutobahnBase
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

    }
}
