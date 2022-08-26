//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFteModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleFte Model
     /// </summary>
    public partial class OrganizationPersonRoleFteModel : AutobahnBase, IOrganizationPersonRoleFte
    {
        public System.Decimal FullTimeEquivalency { get; set; }

        public System.Int32 OrganizationPersonRoleFteid { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
