//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramService Model
     /// </summary>
    public partial class IndividualizedProgramServiceModel : AutobahnBase, Interfaces.IIndividualizedProgramService
    {
        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public System.Decimal? PlannedServiceDuration { get; set; }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get; set; }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public Guid? RefServiceFrequencyId { get; set; }

    }
}
