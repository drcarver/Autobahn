//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy Model
     /// </summary>
    public partial class OrganizationPolicyModel : AutobahnBase, Interfaces.IOrganizationPolicy
    {
        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        public System.String PolicyType { get; set; }

        /// <summary>
        /// Policies related to personnel in the organization.
        /// </summary>
        public System.String Value { get; set; }

    }
}
