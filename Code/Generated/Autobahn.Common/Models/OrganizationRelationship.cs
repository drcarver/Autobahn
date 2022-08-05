//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationRelationship.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationRelationship
     /// </summary>
    public partial class OrganizationRelationship : AutobahnBase, Interfaces.IOrganizationRelationship
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
