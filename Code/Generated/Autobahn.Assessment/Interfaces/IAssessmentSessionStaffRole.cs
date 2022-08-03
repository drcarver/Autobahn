//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSessionStaffRole.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSessionStaffRole
     /// </summary>
    public partial interface IAssessmentSessionStaffRole
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

        /// <summary>
        /// Defines the AssessmentSessionStaffRole.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSessionStaffRole.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
