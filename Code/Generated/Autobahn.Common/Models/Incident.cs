//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Incident.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Incident
     /// </summary>
    public partial class Incident : AutobahnBase, Interfaces.IIncident
    {
        /// <summary>
        /// Defines the Incident.IncidentIdentifier non nullable property
        /// </summary>
        public System.String IncidentIdentifier { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentDate nullable property
        /// </summary>
        public System.DateTime? IncidentDate { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentTime nullable property
        /// </summary>
        public System.TimeSpan? IncidentTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentDescription non nullable property
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
        /// Defines the Incident.IncidentCost non nullable property
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
