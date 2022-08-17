//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignModel.cs
//* Name:       Building Architect Name
//* Definition: The name of the architect of record for the building.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The name of the architect of record for the building.
     /// </summary>
    public partial class FacilityDesignModel : AutobahnBase, Interfaces.IFacilityDesign
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
        public System.String BuildingArchitectName { get; set; }

        /// <summary>
        /// Building Architectural Firm Name
        /// <para>
        /// The name of the architectural firm responsible for the building design.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
        /// </para>
        /// </summary>
        public System.String BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// Building Date of Certificate of Occupancy
        /// <para>
        /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
        /// </para>
        /// </summary>
        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingDesignType"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingEnvOrEnergyPerformanceRatingCat"/> model
        /// </summary>
        public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    }
}
