//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   Incident.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The Incident
     /// </summary>
    public partial class Incident : IIncident
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Incident"/> model
        /// </summary>
        public Guid IncidentId { get; set; }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </summary>
    public System.String IncidentIdentifier { get; set; }

        /// <summary>
        /// The year, month and day on which the incident occurred.
        /// </summary>
    public System.DateTime? IncidentDate { get; set; }

        /// <summary>
        /// An indication of the time of day the incident took place.
        /// </summary>
    public System.TimeSpan? IncidentTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// The description for an incident.
        /// </summary>
    public System.String IncidentDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehavior"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorSecondary"/> model
        /// </summary>
        public Guid? RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentInjuryType"/> model
        /// </summary>
        public Guid? RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponType"/> model
        /// </summary>
        public Guid? RefWeaponTypeId { get; set; }

        /// <summary>
        /// The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident, the value of stolen items, and the value of time consumed by an incident (e.g., instructional time involved in evacuating a school during a false fire alarm). Cost may be reported by specific monetary amount or range.
        /// </summary>
    public System.String IncidentCost { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentReporter"/> model
        /// </summary>
        public Guid? IncidentReporterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterType"/> model
        /// </summary>
        public Guid? RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentLocation"/> model
        /// </summary>
        public Guid? RefIncidentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmType"/> model
        /// </summary>
        public Guid? RefFirearmTypeId { get; set; }

        /// <summary>
        /// Defines the Incident.RegulationViolatedDescription non nullable property
        /// </summary>
        public System.String RegulationViolatedDescription { get; set; }

        /// <summary>
        /// Defines the Incident.RelatedToDisabilityManifestationInd nullable property
        /// </summary>
        public System.Boolean? RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// Defines the Incident.ReportedToLawEnforcementInd nullable property
        /// </summary>
        public System.Boolean? ReportedToLawEnforcementInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseType"/> model
        /// </summary>
        public Guid? RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        public Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

        /// <summary>
        /// Defines the Incident.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Incident.RecordEndDateTime nullable property
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
