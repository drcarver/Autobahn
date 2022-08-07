//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilitySiteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySiteModel Interface
     /// </summary>
    public partial interface IFacilitySiteModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilitySite.FacilitySiteIdentifier non nullable property
        /// </summary>
        System.String FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// Defines the FacilitySite.FacilitySiteArea nullable property
        /// </summary>
        System.Decimal? FacilitySiteArea { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsType"/> model
        /// </summary>
        Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaType"/> model
        /// </summary>
        Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    }
}
