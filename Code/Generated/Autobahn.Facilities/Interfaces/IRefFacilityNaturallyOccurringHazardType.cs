//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilityNaturallyOccurringHazardType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefFacilityNaturallyOccurringHazardType
     /// </summary>
    public partial interface IRefFacilityNaturallyOccurringHazardType
    {
        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
