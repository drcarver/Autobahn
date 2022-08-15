//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationRelationship Model
     /// </summary>
    public partial class OrganizationRelationshipModel : AutobahnBase, Interfaces.IOrganizationRelationship
    {
        /// <summary>
        /// The nature of one organization's relationship to another.
        /// </summary>
        public Guid? RefOrganizationRelationshipId { get; set; }

    }
}
