//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolManagementOrganization.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganization
     /// </summary>
    public partial class K12CharterSchoolManagementOrganization : AutobahnBase, Interfaces.IK12CharterSchoolManagementOrganization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
        /// </summary>
        public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
