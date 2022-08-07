//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramGoalModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramGoalModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramGoalModel : IAutobahnBase
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
