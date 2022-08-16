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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
