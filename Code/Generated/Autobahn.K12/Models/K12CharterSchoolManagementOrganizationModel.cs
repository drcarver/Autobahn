//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolManagementOrganizationModel.cs
//**********************************************************

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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    }
}
