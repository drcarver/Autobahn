//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramServicesReceivedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramServicesReceived Model
     /// </summary>
    public partial class IndividualizedProgramServicesReceivedModel : AutobahnBase, Interfaces.IIndividualizedProgramServicesReceived
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

    }
}
