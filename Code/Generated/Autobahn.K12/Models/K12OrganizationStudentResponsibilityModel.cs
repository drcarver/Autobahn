//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12OrganizationStudentResponsibility Model
     /// </summary>
    public partial class K12OrganizationStudentResponsibilityModel : AutobahnBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefK12ResponsibilityType"/> model
        /// </summary>
        public Guid RefK12ResponsibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
