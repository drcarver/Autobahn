//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyModel.cs
//* Name:       Building Energy Service Company Name
//* Definition: The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
     /// </summary>
    public partial class FacilityEnergyModel : AutobahnBase, Interfaces.IFacilityEnergy
    {
        /// <summary>
        /// Building Energy Service Company Name
        /// <para>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20850">Building Energy Service Company Name</a>
        /// </para>
        /// </summary>
        public System.String BuildingEnergyServiceCompanyName { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
        /// </summary>
        public Guid? RefFacilityUtilityTypeId { get; set; }

    }
}
