//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12CharterSchoolManagementOrganization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolManagementOrganization Interface
     /// </summary>
    public partial interface IK12CharterSchoolManagementOrganization : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    }
}
