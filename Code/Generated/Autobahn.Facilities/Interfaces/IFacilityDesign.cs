//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityDesign.cs
//* Name:       Building Architect Name
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IFacilityDesign : IAutobahnBase
    {
        /// <summary>
        /// Building Architect Name
        /// <para>
        /// The name of the architect of record for the building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
        /// </para>
        /// </summary>
        System.String BuildingArchitectName { get; set; }

        /// <summary>
        /// Building Architectural Firm Name
        /// <para>
        /// The name of the architectural firm responsible for the building design.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
        /// </para>
        /// </summary>
        System.String BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// Building Date of Certificate of Occupancy
        /// <para>
        /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
        /// </para>
        /// </summary>
        System.DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// </summary>
        Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/> model
        /// </summary>
        Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    }
}
