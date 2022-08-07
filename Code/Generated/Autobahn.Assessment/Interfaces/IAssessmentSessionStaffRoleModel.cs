//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSessionStaffRoleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSessionStaffRoleModel Interface
     /// </summary>
    public partial interface IAssessmentSessionStaffRoleModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleType"/> model
        /// </summary>
        Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        Guid? AssessmentParticipantSessionId { get; set; }

    }
}
