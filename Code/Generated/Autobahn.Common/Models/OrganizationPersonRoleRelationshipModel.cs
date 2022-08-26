//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleRelationshipModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleRelationship Model
     /// </summary>
    public partial class OrganizationPersonRoleRelationshipModel : AutobahnBase, IOrganizationPersonRoleRelationship
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Int32 OrganizationPersonRoleIdParent { get; set; }

    }
}
