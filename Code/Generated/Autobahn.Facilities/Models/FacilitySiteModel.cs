//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySiteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySite Model
     /// </summary>
    public partial class FacilitySiteModel : AutobahnBase, Interfaces.IFacilitySiteModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilitySite.FacilitySiteIdentifier non nullable property
        /// </summary>
        public System.String FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// Defines the FacilitySite.FacilitySiteArea nullable property
        /// </summary>
        public System.Decimal? FacilitySiteArea { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSiteUseRestrictionsType"/> model
        /// </summary>
        public Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteOutdoorAreaType"/> model
        /// </summary>
        public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
