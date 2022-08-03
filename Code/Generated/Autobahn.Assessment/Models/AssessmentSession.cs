//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSession.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSession
     /// </summary>
    public partial class AssessmentSession : IAssessmentSession
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        public Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledStartDateTime nullable property
        /// </summary>
        public System.DateTime? ScheduledStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledEndDateTime nullable property
        /// </summary>
        public System.DateTime? ScheduledEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualStartDateTime nullable property
        /// </summary>
        public System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualEndDateTime nullable property
        /// </summary>
        public System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.AllottedTime nullable property
        /// </summary>
        public System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SecurityIssue non nullable property
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SpecialEventDescription non nullable property
        /// </summary>
        public System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.Location non nullable property
        /// </summary>
        public System.String Location { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_Organization"/> model
        /// </summary>
        public Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_Organization"/> model
        /// </summary>
        public Guid? School_OrganizationId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.RecordEndDateTime nullable property
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
