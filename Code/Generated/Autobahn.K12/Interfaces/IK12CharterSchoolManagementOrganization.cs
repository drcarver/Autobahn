//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12CharterSchoolManagementOrganization.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolManagementOrganization
     /// </summary>
    public partial interface IK12CharterSchoolManagementOrganization : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
        /// </summary>
        Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    }
}
