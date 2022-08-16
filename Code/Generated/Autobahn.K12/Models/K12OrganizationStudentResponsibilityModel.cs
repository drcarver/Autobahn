//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12OrganizationStudentResponsibility Model
     /// </summary>
    public partial class K12OrganizationStudentResponsibilityModel : AutobahnBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefK12ResponsibilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
