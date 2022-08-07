//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPolicyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy Model
     /// </summary>
    public partial class OrganizationPolicyModel : AutobahnBase, Interfaces.IOrganizationPolicyModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.PolicyType non nullable property
        /// </summary>
        public System.String PolicyType { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
