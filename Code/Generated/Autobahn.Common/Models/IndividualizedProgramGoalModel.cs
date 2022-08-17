//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramGoalModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramGoal Model
     /// </summary>
    public partial class IndividualizedProgramGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramGoal
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIEPGoalType"/> model
        /// </summary>
        public Guid? RefIEPGoalTypeId { get; set; }

    }
}
