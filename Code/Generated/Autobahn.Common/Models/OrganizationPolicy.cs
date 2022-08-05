//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPolicy.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy
     /// </summary>
    public partial class OrganizationPolicy : AutobahnBase, Interfaces.IOrganizationPolicy
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
