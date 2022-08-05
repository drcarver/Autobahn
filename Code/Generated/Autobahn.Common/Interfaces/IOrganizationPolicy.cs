//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPolicy.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPolicy
     /// </summary>
    public partial interface IOrganizationPolicy : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.PolicyType non nullable property
        /// </summary>
        System.String PolicyType { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

    }
}
