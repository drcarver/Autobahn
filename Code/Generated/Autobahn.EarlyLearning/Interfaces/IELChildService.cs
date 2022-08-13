//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildService Interface
     /// </summary>
    public partial interface IELChildService : IAutobahnBase
    {
        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        System.Boolean? ECEAPEligibility { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        System.String EligibilityPriorityPoints { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        Guid? RefELServiceTypeId { get; set; }

        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        System.DateTime? ServiceDate { get; set; }

    }
}
