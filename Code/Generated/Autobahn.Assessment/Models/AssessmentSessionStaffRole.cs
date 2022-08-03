//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionStaffRole.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSessionStaffRole
     /// </summary>
    public partial class AssessmentSessionStaffRole : IAssessmentSessionStaffRole
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSession"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Defines the AssessmentSessionStaffRole.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSessionStaffRole.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
