//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleRelationship.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationPersonRoleRelationship Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleRelationship : IAutobahnBase
    {
        #region IOrganizationPersonRoleRelationship
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        System.Int32 OrganizationPersonRoleIdParent { get; set; }

        #endregion
    }
}
