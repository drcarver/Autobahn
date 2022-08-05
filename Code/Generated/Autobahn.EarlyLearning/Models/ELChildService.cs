//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildService.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildService
     /// </summary>
    public partial class ELChildService : AutobahnBase, Interfaces.IELChildService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildService.ECEAPEligibility nullable property
        /// </summary>
        public System.Boolean? ECEAPEligibility { get; set; }

        /// <summary>
        /// Defines the ELChildService.EligibilityPriorityPoints non nullable property
        /// </summary>
        public System.String EligibilityPriorityPoints { get; set; }

        /// <summary>
        /// Defines the ELChildService.ServiceDate nullable property
        /// </summary>
        public System.DateTime? ServiceDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceType"/> model
        /// </summary>
        public Guid? RefELServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
