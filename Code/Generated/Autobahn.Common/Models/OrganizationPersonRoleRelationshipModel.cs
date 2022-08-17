//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleRelationshipModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The OrganizationPersonRoleRelationship Model
     /// </summary>
    public partial class OrganizationPersonRoleRelationshipModel : AutobahnBase, Interfaces.IOrganizationPersonRoleRelationship
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Int32 OrganizationPersonRoleId_Parent { get; set; }

    }
}
