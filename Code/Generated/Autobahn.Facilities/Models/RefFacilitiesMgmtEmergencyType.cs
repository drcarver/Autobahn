//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitiesMgmtEmergencyType.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefFacilitiesMgmtEmergencyType
     /// </summary>
    public partial class RefFacilitiesMgmtEmergencyType : IRefFacilitiesMgmtEmergencyType
    {
        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
