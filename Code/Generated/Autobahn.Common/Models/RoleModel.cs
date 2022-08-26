//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Role Model
     /// </summary>
    public partial class RoleModel : AutobahnBase, IRole
    {
        public System.String Name { get; set; }

        /// <summary>
        /// Role
        /// <para>
        /// A description of the way in which a person relates to an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20959">Role</a>
        /// </para>
        /// </summary>
        public Guid? RefRoleId { get; set; }

    }
}
