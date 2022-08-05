//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12OrganizationStudentResponsibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12OrganizationStudentResponsibility
     /// </summary>
    public partial interface IK12OrganizationStudentResponsibility : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12ResponsibilityType"/> model
        /// </summary>
        Guid RefK12ResponsibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
