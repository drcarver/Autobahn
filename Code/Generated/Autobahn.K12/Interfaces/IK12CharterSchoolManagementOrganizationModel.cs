//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12CharterSchoolManagementOrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolManagementOrganizationModel Interface
     /// </summary>
    public partial interface IK12CharterSchoolManagementOrganizationModel : IAutobahnBase
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
