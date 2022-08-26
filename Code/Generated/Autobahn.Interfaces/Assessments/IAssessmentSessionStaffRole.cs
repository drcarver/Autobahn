//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSessionStaffRole.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentSessionStaffRole Interface
     /// </summary>
    public partial interface IAssessmentSessionStaffRole : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
        /// </summary>
        Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
        /// </summary>
        Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Assessment Session Staff Role Type
        /// <para>
        /// The type of role served related to the administration of an assessment session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
        /// </para>
        /// </summary>
        Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}
