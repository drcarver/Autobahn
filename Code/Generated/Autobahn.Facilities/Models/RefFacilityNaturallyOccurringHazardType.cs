//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityNaturallyOccurringHazardType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityNaturallyOccurringHazardType
     /// </summary>
    public partial class RefFacilityNaturallyOccurringHazardType : IRefFacilityNaturallyOccurringHazardType
    {
        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityNaturallyOccurringHazardType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
