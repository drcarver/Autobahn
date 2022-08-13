//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleRelationship.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleRelationship Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleRelationship : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Int32 OrganizationPersonRoleId_Parent { get; set; }

    }
}
