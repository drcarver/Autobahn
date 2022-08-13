//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramGoal.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramGoal Interface
     /// </summary>
    public partial interface IIndividualizedProgramGoal : IAutobahnBase
    {
        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        Guid GoalId { get; set; }

        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </summary>
        Guid? RefIEPGoalTypeId { get; set; }

    }
}
