//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolManagementOrganizationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganization Model
     /// </summary>
    public partial class K12CharterSchoolManagementOrganizationModel : AutobahnBase, Interfaces.IK12CharterSchoolManagementOrganization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
        /// </summary>
        public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    }
}
