//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefBarrierToInternetAccessInResidence.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefBarrierToInternetAccessInResidence
     /// </summary>
    public partial class RefBarrierToInternetAccessInResidence : IRefBarrierToInternetAccessInResidence
    {
        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBarrierToInternetAccessInResidence.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
