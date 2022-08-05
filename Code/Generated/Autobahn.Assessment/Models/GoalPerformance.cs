//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   GoalPerformance.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The GoalPerformance
     /// </summary>
    public partial class GoalPerformance : AutobahnBase, Interfaces.IGoalPerformance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.CurrentPerformanceDescription non nullable property
        /// </summary>
        public System.String CurrentPerformanceDescription { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.Date nullable property
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Defines the GoalPerformance.Status non nullable property
        /// </summary>
        public System.String Status { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalStatusType"/> model
        /// </summary>
        public Guid? RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
