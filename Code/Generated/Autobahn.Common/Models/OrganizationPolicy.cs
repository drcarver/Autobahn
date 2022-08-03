//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPolicy.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy
     /// </summary>
    public partial class OrganizationPolicy : IOrganizationPolicy
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
        /// Defines the OrganizationPolicy.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
