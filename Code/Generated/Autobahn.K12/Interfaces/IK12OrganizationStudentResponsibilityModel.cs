//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12OrganizationStudentResponsibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12OrganizationStudentResponsibilityModel Interface
     /// </summary>
    public partial interface IK12OrganizationStudentResponsibilityModel : IAutobahnBase
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
