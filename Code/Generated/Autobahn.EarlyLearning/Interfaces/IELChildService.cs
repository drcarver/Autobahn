//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildService
     /// </summary>
    public partial interface IELChildService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELChildService.ECEAPEligibility nullable property
        /// </summary>
        System.Boolean? ECEAPEligibility { get; set; }

        /// <summary>
        /// Defines the ELChildService.EligibilityPriorityPoints non nullable property
        /// </summary>
        System.String EligibilityPriorityPoints { get; set; }

        /// <summary>
        /// Defines the ELChildService.ServiceDate nullable property
        /// </summary>
        System.DateTime? ServiceDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
        /// </summary>
        Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
        /// </summary>
        Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceType"/> model
        /// </summary>
        Guid? RefELServiceTypeId { get; set; }

    }
}
