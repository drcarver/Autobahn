//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSession.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSession
     /// </summary>
    public partial interface IAssessmentSession
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentAdministration"/> model
        /// </summary>
        Guid? AssessmentAdministrationId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledStartDateTime nullable property
        /// </summary>
        System.DateTime? ScheduledStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ScheduledEndDateTime nullable property
        /// </summary>
        System.DateTime? ScheduledEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualStartDateTime nullable property
        /// </summary>
        System.DateTime? ActualStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.ActualEndDateTime nullable property
        /// </summary>
        System.DateTime? ActualEndDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.AllottedTime nullable property
        /// </summary>
        System.TimeSpan? AllottedTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionType"/> model
        /// </summary>
        Guid? RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SecurityIssue non nullable property
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionSpecialCircumstanceType"/> model
        /// </summary>
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.SpecialEventDescription non nullable property
        /// </summary>
        System.String SpecialEventDescription { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.Location non nullable property
        /// </summary>
        System.String Location { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Lea_Organization"/> model
        /// </summary>
        Guid? Lea_OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="School_Organization"/> model
        /// </summary>
        Guid? School_OrganizationId { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSession.RecordEndDateTime nullable property
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
