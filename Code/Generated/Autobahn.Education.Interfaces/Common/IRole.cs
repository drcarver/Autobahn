//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRole.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IRole Interface
     /// </summary>
    public partial interface IRole : IAutobahnBase
    {
        #region IRole
        System.String Name { get; set; }

        /// <summary>
        /// Role
        /// <para>
        /// A description of the way in which a person relates to an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20959">Role</a>
        /// </para>
        /// </summary>
        Guid? RefRoleId { get; set; }

        #endregion
    }
}
