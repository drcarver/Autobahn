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
        /// 
        /// </summary>
        public  PlannedServiceDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? PlannedServiceStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefServiceFrequencyId { get; set; }

    }
}
