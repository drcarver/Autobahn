//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationRelationship Model
     /// </summary>
    public partial class OrganizationRelationshipModel : AutobahnBase, Interfaces.IOrganizationRelationship
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParent_Organization"/> model
        /// </summary>
        public Guid Parent_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
        /// </summary>
        public Guid? RefOrganizationRelationshipId { get; set; }

    }
}
