//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12OrganizationStudentResponsibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12OrganizationStudentResponsibility Interface
     /// </summary>
    public partial interface IK12OrganizationStudentResponsibility : IAutobahnBase
    {
        /// <summary>
        /// The type of responsibility the district has for the student.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The type of responsibility the district has for the student.
        /// </summary>
        Guid RefK12ResponsibilityTypeId { get; set; }

        /// <summary>
        /// The type of responsibility the district has for the student.
        /// </summary>
        Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
