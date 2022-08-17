//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIncident.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIncident Interface
     /// </summary>
    public partial interface IIncident : IAutobahnBase
    {
        /// <summary>
        /// Incident Cost
        /// <para>
        /// The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident, the value of stolen items, and the value of time consumed by an incident (e.g., instructional time involved in evacuating a school during a false fire alarm).  Cost may be reported by specific monetary amount or range.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19496">Incident Cost</a>
        /// </para>
        /// </summary>
        System.String IncidentCost { get; set; }

        /// <summary>
        /// Incident Date
        /// <para>
        /// The year, month and day on which the incident occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19493">Incident Date</a>
        /// </para>
        /// </summary>
        System.DateTime? IncidentDate { get; set; }

        /// <summary>
        /// Incident Description
        /// <para>
        /// The description for an incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19499">Incident Description</a>
        /// </para>
        /// </summary>
        System.String IncidentDescription { get; set; }

        /// <summary>
        /// Incident Identifier
        /// <para>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
        /// </para>
        /// </summary>
        System.String IncidentIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncidentReporter"/> model
        /// </summary>
        Guid? IncidentReporterId { get; set; }

        /// <summary>
        /// Incident Time
        /// <para>
        /// An indication of the time of day the incident took place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19494">Incident Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? IncidentTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFirearmType"/> model
        /// </summary>
        Guid? RefFirearmTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentBehavior"/> model
        /// </summary>
        Guid? RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentBehaviorSecondary"/> model
        /// </summary>
        Guid? RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentInjuryType"/> model
        /// </summary>
        Guid? RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentLocation"/> model
        /// </summary>
        Guid? RefIncidentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentMultipleOffenseType"/> model
        /// </summary>
        Guid? RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentReporterType"/> model
        /// </summary>
        Guid? RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncidentTimeDescriptionCode"/> model
        /// </summary>
        Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefWeaponType"/> model
        /// </summary>
        Guid? RefWeaponTypeId { get; set; }

        /// <summary>
        /// Incident Regulation Violated Description
        /// <para>
        /// A description of the rule, regulation, or standard that was violated when an incident occurred (e.g., the identification of a relevant law, conduct standard, or acceptable use policy).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20342">Incident Regulation Violated Description</a>
        /// </para>
        /// </summary>
        System.String RegulationViolatedDescription { get; set; }

        /// <summary>
        /// Incident Related to Disability Manifestation
        /// <para>
        /// An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20343">Incident Related to Disability Manifestation</a>
        /// </para>
        /// </summary>
        System.Boolean? RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// Incident Reported to Law Enforcement Indicator
        /// <para>
        /// An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20345">Incident Reported to Law Enforcement Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? ReportedToLawEnforcementInd { get; set; }

    }
}
