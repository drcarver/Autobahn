//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySite.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySite
     /// </summary>
    public partial class FacilitySite : IFacilitySite
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
        /// Defines the FacilitySite.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilitySite.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
