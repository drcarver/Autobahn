//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityCompliance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityCompliance Interface
     /// </summary>
    public partial interface IFacilityCompliance : IAutobahnBase
    {
        /// <summary>
        /// Building Institutional Equipment Description
        /// <para>
        /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
        /// </para>
        /// </summary>
        Guid? BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Component or Fixture Check Date
        /// <para>
        /// The month, day, and year that the condition of a system, component, equipment, or fixture was  checked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20879">Component or Fixture Check Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// Facility Compliance Determination Date
        /// <para>
        /// The month, day, and year that the school, building, site, system, component, equipment, or fixture compliance status was determined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20818">Facility Compliance Determination Date</a>
        /// </para>
        /// </summary>
        System.DateTime? FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// Facility Compliance Name
        /// <para>
        /// The name of the inspection or process that indicates conformity to the requirements or standards specified in federal, state, or local standards or codes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20819">Facility Compliance Name</a>
        /// </para>
        /// </summary>
        System.String FacilityComplianceName { get; set; }

        /// <summary>
        /// Facility Component Deficiency Description
        /// <para>
        /// A description of the component, system, or finish that needs replacement, repair, or maintenance to perform at an optimal level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20820">Facility Component Deficiency Description</a>
        /// </para>
        /// </summary>
        System.String FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// Facility Estimated Cost to Eliminate Deferred Maintenance
        /// <para>
        /// The estimated cost to bring systems, components, finishes, fixtures, or equipment to a state of good repair.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20822">Facility Estimated Cost to Eliminate Deferred Maintenance</a>
        /// </para>
        /// </summary>
        System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// Facility Inspection Score Result Description
        /// <para>
        /// The description of a meaningful raw score of statistical expression of the performance on an inspection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20827">Facility Inspection Score Result Description</a>
        /// </para>
        /// </summary>
        System.String FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// Facility Inspection Violation Description
        /// <para>
        /// A description of the standard violation(s) found in the inspection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20828">Facility Inspection Violation Description</a>
        /// </para>
        /// </summary>
        System.String FacilityInspectionViolationDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMandate"/> model
        /// </summary>
        Guid? FacilityMandateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityComplianceStatus"/> model
        /// </summary>
        Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityMaintStandardType"/> model
        /// </summary>
        Guid? RefFacilityMaintStandardTypeId { get; set; }

    }
}
