//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefBarrierToInternetAccessInResidence.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefBarrierToInternetAccessInResidence
     /// </summary>
    public partial interface IRefBarrierToInternetAccessInResidence
    {
        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
