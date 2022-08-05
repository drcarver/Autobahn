//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleRelationship.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleRelationship
     /// </summary>
    public partial class OrganizationPersonRoleRelationship : AutobahnBase, Interfaces.IOrganizationPersonRoleRelationship
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleRelationship.OrganizationPersonRoleId_Parent non nullable property
        /// </summary>
        public System.Int32 OrganizationPersonRoleId_Parent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
