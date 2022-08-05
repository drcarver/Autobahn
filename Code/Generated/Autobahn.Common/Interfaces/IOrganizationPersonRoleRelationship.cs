//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleRelationship.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleRelationship
     /// </summary>
    public partial interface IOrganizationPersonRoleRelationship : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleRelationship.OrganizationPersonRoleId_Parent non nullable property
        /// </summary>
        System.Int32 OrganizationPersonRoleId_Parent { get; set; }

    }
}
