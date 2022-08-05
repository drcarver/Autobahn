//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramGoal.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramGoal
     /// </summary>
    public partial interface IIndividualizedProgramGoal : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Goal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// </summary>
        Guid? RefIEPGoalTypeId { get; set; }

    }
}
