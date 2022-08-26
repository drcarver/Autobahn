//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12organizationStudentResponsibilityModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12organizationStudentResponsibility Model
     /// </summary>
    public partial class K12organizationStudentResponsibilityModel : AutobahnBase, IK12organizationStudentResponsibility
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12responsibilityType"/> model
        /// </summary>
        public Guid RefK12responsibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
