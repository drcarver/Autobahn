//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitySiteImprovementLocationType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilitySiteImprovementLocationType
     /// </summary>
    public partial class RefFacilitySiteImprovementLocationType : IRefFacilitySiteImprovementLocationType
    {
        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilitySiteImprovementLocationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
