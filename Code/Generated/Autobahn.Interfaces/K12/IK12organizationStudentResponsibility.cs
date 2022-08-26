//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12organizationStudentResponsibility.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12organizationStudentResponsibility Interface
     /// </summary>
    public partial interface IK12organizationStudentResponsibility : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12responsibilityType"/> model
        /// </summary>
        Guid RefK12responsibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
