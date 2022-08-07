//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIncidentModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIncidentModel Interface
     /// </summary>
    public partial interface IIncidentModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the Incident.IncidentIdentifier non nullable property
        /// </summary>
        System.String IncidentIdentifier { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentDate nullable property
        /// </summary>
        System.DateTime? IncidentDate { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentTime nullable property
        /// </summary>
        System.TimeSpan? IncidentTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentDescription non nullable property
        /// </summary>
        System.String IncidentDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehavior"/> model
        /// </summary>
        Guid? RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentBehaviorSecondary"/> model
        /// </summary>
        Guid? RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentInjuryType"/> model
        /// </summary>
        Guid? RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponType"/> model
        /// </summary>
        Guid? RefWeaponTypeId { get; set; }

        /// <summary>
        /// Defines the Incident.IncidentCost non nullable property
        /// </summary>
        System.String IncidentCost { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentReporter"/> model
        /// </summary>
        Guid? IncidentReporterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterType"/> model
        /// </summary>
        Guid? RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentLocation"/> model
        /// </summary>
        Guid? RefIncidentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmType"/> model
        /// </summary>
        Guid? RefFirearmTypeId { get; set; }

        /// <summary>
        /// Defines the Incident.RegulationViolatedDescription non nullable property
        /// </summary>
        System.String RegulationViolatedDescription { get; set; }

        /// <summary>
        /// Defines the Incident.RelatedToDisabilityManifestationInd nullable property
        /// </summary>
        System.Boolean? RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// Defines the Incident.ReportedToLawEnforcementInd nullable property
        /// </summary>
        System.Boolean? ReportedToLawEnforcementInd { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseType"/> model
        /// </summary>
        Guid? RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

    }
}
