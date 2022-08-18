//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramGoal.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramGoal Interface
     /// </summary>
    public partial interface IIndividualizedProgramGoal : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// </summary>
        Guid? RefIEPGoalTypeId { get; set; }

    }
}
