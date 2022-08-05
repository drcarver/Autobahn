//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSessionStaffRole.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSessionStaffRole
     /// </summary>
    public partial interface IAssessmentSessionStaffRole : IAutobahnBase
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
