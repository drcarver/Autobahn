//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAmendmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramAmendment Model
     /// </summary>
    public partial class IndividualizedProgramAmendmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAmendment
    {
        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        public System.String ReasonDescription { get; set; }

    }
}
