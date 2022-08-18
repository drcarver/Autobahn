//**********************************************************
//* DomainName: Common Models
//* FileName:   IncidentModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Incident Model
     /// </summary>
    public partial class IncidentModel : AutobahnBase, Interfaces.IIncident
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
        public System.String IncidentCost { get; set; }

        /// <summary>
        /// Incident Date
        /// <para>
        /// The year, month and day on which the incident occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19493">Incident Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? IncidentDate { get; set; }

        /// <summary>
        /// Incident Description
        /// <para>
        /// The description for an incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19499">Incident Description</a>
        /// </para>
        /// </summary>
        public System.String IncidentDescription { get; set; }

        /// <summary>
        /// Incident Identifier
        /// <para>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
        /// </para>
        /// </summary>
        public System.String IncidentIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncidentReporter"/> model
        /// </summary>
        public Guid? IncidentReporterId { get; set; }

        /// <summary>
        /// Incident Time
        /// <para>
        /// An indication of the time of day the incident took place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19494">Incident Time</a>
        /// </para>
        /// </summary>
        public System.TimeSpan? IncidentTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFirearmType"/> model
        /// </summary>
        public Guid? RefFirearmTypeId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefIncidentLocation"/> model
        /// </summary>
        public Guid? RefIncidentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentMultipleOffenseType"/> model
        /// </summary>
        public Guid? RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPerpetratorInjuryType"/> model
        /// </summary>
        public Guid? RefIncidentPerpetratorInjuryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentReporterType"/> model
        /// </summary>
        public Guid? RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentTimeDescriptionCode"/> model
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWeaponType"/> model
        /// </summary>
        public Guid? RefWeaponTypeId { get; set; }

        /// <summary>
        /// Incident Regulation Violated Description
        /// <para>
        /// A description of the rule, regulation, or standard that was violated when an incident occurred (e.g., the identification of a relevant law, conduct standard, or acceptable use policy).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20342">Incident Regulation Violated Description</a>
        /// </para>
        /// </summary>
        public System.String RegulationViolatedDescription { get; set; }

        /// <summary>
        /// Incident Related to Disability Manifestation
        /// <para>
        /// An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20343">Incident Related to Disability Manifestation</a>
        /// </para>
        /// </summary>
        public System.Boolean? RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// Incident Reported to Law Enforcement Indicator
        /// <para>
        /// An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20345">Incident Reported to Law Enforcement Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? ReportedToLawEnforcementInd { get; set; }

    }
}
