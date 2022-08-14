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
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        public Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}
