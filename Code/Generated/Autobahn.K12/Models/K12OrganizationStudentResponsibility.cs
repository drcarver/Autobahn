//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12OrganizationStudentResponsibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12OrganizationStudentResponsibility
     /// </summary>
    public partial class K12OrganizationStudentResponsibility : AutobahnBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12ResponsibilityType"/> model
        /// </summary>
        public Guid RefK12ResponsibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
