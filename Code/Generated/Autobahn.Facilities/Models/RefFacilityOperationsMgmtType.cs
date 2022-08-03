//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityOperationsMgmtType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilityOperationsMgmtType
     /// </summary>
    public partial class RefFacilityOperationsMgmtType : IRefFacilityOperationsMgmtType
    {
        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
