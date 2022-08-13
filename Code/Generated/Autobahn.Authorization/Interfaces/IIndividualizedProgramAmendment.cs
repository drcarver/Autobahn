//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAmendment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAmendment Interface
     /// </summary>
    public partial interface IIndividualizedProgramAmendment : IAutobahnBase
    {
        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        System.String ReasonDescription { get; set; }

    }
}
