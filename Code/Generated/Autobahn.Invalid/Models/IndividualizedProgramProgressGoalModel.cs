//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressGoalModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal Model
     /// </summary>
    public partial class IndividualizedProgramProgressGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressGoal
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid IndividualizedProgramProgressReportId { get; set; }

    }
}
