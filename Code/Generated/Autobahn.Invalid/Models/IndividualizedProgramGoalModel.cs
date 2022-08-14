//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramGoalModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramGoal Model
     /// </summary>
    public partial class IndividualizedProgramGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramGoal
    {
        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        public Guid? RefIEPGoalTypeId { get; set; }

    }
}
