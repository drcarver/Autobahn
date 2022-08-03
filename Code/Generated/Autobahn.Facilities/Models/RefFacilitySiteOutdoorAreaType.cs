//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitySiteOutdoorAreaType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilitySiteOutdoorAreaType
     /// </summary>
    public partial class RefFacilitySiteOutdoorAreaType : IRefFacilitySiteOutdoorAreaType
    {
        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteOutdoorAreaType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
