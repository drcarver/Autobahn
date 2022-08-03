//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilityOperationsMgmtType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefFacilityOperationsMgmtType
     /// </summary>
    public partial interface IRefFacilityOperationsMgmtType
    {
        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityOperationsMgmtType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
