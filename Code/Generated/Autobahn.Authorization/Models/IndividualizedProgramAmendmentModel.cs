//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAmendmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramAmendment Model
     /// </summary>
    public partial class IndividualizedProgramAmendmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAmendment
    {
        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        public System.String ReasonDescription { get; set; }

    }
}
