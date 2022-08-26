//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolManagementOrganizationModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12charterSchoolManagementOrganization Model
     /// </summary>
    public partial class K12charterSchoolManagementOrganizationModel : AutobahnBase, IK12charterSchoolManagementOrganization
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
