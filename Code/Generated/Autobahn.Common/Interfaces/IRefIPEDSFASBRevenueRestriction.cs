//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSFASBRevenueRestriction.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefIPEDSFASBRevenueRestriction
     /// </summary>
    public partial interface IRefIPEDSFASBRevenueRestriction
    {
        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIPEDSFASBRevenueRestriction.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
