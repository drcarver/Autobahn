//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentSessionStaffRole.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentSessionStaffRole Interface
     /// </summary>
    public partial interface IAssessmentSessionStaffRole : IAutobahnBase
    {
        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The type of role served related to the administration of an assessment session.
        /// </summary>
        Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}
