//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilitiesMgmtEmergencyType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefFacilitiesMgmtEmergencyType
     /// </summary>
    public partial interface IRefFacilitiesMgmtEmergencyType
    {
        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilitiesMgmtEmergencyType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
