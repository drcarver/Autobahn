//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessTypeInResidence.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefInternetAccessTypeInResidence
     /// </summary>
    public partial class RefInternetAccessTypeInResidence : IRefInternetAccessTypeInResidence
    {
        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefInternetAccessTypeInResidence.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
