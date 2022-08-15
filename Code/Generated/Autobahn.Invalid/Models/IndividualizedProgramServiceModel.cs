//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramService Model
     /// </summary>
    public partial class IndividualizedProgramServiceModel : AutobahnBase, Interfaces.IIndividualizedProgramService
    {
        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get; set; }

    }
}
