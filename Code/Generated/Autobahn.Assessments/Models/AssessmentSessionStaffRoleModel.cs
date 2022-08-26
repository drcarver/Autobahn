//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSessionStaffRole Model
     /// </summary>
    public partial class AssessmentSessionStaffRoleModel : AutobahnBase, IAssessmentSessionStaffRole
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Assessment Session Staff Role Type
        /// <para>
        /// The type of role served related to the administration of an assessment session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    }
}
