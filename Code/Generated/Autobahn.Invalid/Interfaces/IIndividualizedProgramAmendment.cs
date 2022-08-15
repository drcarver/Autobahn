//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAmendment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAmendment Interface
     /// </summary>
    public partial interface IIndividualizedProgramAmendment : IAutobahnBase
    {
        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        System.String ReasonDescription { get; set; }

    }
}
