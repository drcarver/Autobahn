//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilitySite.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySite Interface
     /// </summary>
    public partial interface IFacilitySite : IAutobahnBase
    {
        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        System.Decimal? FacilitySiteArea { get; set; }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        System.String FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
        /// </summary>
        Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    }
}
