//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramGoal.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramGoal
     /// </summary>
    public partial class IndividualizedProgramGoal : AutobahnBase, Interfaces.IIndividualizedProgramGoal
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// </summary>
        public Guid? RefIEPGoalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
