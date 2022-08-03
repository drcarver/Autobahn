//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilitySite.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySite
     /// </summary>
    public partial interface IFacilitySite
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

        /// <summary>
        /// Defines the FacilitySite.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilitySite.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
