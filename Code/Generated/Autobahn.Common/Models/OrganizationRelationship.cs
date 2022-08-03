//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationRelationship.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationRelationship
     /// </summary>
    public partial class OrganizationRelationship : IOrganizationRelationship
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Parent_Organization"/> model
        /// </summary>
        public Guid Parent_OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
        /// </summary>
        public Guid? RefOrganizationRelationshipId { get; set; }

        /// <summary>
        /// Defines the OrganizationRelationship.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationRelationship.RecordEndDateTime nullable property
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
