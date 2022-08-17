//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The FacilitySite Model
     /// </summary>
    public partial class FacilitySiteModel : AutobahnBase, Interfaces.IFacilitySite
    {
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
        /// Facility Site Area
        /// <para>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20754">Facility Site Area</a>
        /// </para>
        /// </summary>
        public System.Decimal? FacilitySiteArea { get; set; }

        /// <summary>
        /// Facility Site Identifier
        /// <para>
        /// The lot and square number, or equivalent unique municipal number identification, of a parcel of land.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20767">Facility Site Identifier</a>
        /// </para>
        /// </summary>
        public System.String FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSiteUseRestrictionsType"/> model
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFacilitySiteOutdoorAreaType"/> model
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    }
}
