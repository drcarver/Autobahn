//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleRelationshipModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleRelationship Model
     /// </summary>
    public partial class OrganizationPersonRoleRelationshipModel : AutobahnBase, Interfaces.IOrganizationPersonRoleRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 OrganizationPersonRoleId_Parent { get; set; }

    }
}
