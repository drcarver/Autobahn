//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefFacilityStateOrLocalMandateInterestType.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IRefFacilityStateOrLocalMandateInterestType
     /// </summary>
    public partial interface IRefFacilityStateOrLocalMandateInterestType
    {
        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFacilityStateOrLocalMandateInterestType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
