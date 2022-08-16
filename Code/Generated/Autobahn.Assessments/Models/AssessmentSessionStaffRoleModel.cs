//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSessionStaffRole Model
     /// </summary>
    public partial class AssessmentSessionStaffRoleModel : AutobahnBase, Interfaces.IAssessmentSessionStaffRole
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
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}
