//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPolicy.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPolicy Interface
     /// </summary>
    public partial interface IOrganizationPolicy : IAutobahnBase
    {
        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        System.String PolicyType { get; set; }

        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        System.String Value { get; set; }

    }
}
