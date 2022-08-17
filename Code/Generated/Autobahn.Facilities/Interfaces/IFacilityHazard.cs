//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityHazard.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityHazard Interface
     /// </summary>
    public partial interface IFacilityHazard : IAutobahnBase
    {
        /// <summary>
        /// Facility Hazardous Condition Expected Remediation Date
        /// <para>
        /// The month, day, and year by which a hazardous condition of a site or building is expected to be remediated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20823">Facility Hazardous Condition Expected Remediation Date</a>
        /// </para>
        /// </summary>
        System.DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Location of Hazardous Materials
        /// <para>
        /// The location at which the identified hazardous material is found.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20789">Facility Location of Hazardous Materials</a>
        /// </para>
        /// </summary>
        System.String FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// Facility Nearby Environmental Hazard Description
        /// <para>
        /// Description of any type of environmental hazards within range of the facility that has the potential to seriously affect the health, safety and operation of school facilities and their occupants.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20791">Facility Nearby Environmental Hazard Description</a>
        /// </para>
        /// </summary>
        System.String FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// Hazardous Material or Condition Description
        /// <para>
        /// A description of the seriousness a threat or hazardous material poses.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20825">Hazardous Material or Condition Description</a>
        /// </para>
        /// </summary>
        System.String HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// Hazardous Material or Condition Testing Date
        /// <para>
        /// The month, day, and year that the site or building is tested for a specific hazardous material.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20826">Hazardous Material or Condition Testing Date</a>
        /// </para>
        /// </summary>
        System.DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityHazardousMaterialsOrCondType"/> model
        /// </summary>
        Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilityNaturallyOccurringHazardType"/> model
        /// </summary>
        Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    }
}
