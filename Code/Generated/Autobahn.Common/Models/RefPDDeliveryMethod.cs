//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDDeliveryMethod.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPDDeliveryMethod
     /// </summary>
    public partial class RefPDDeliveryMethod : IRefPDDeliveryMethod
    {
        /// <summary>
        /// Defines the RefPDDeliveryMethod.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPDDeliveryMethod.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPDDeliveryMethod.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPDDeliveryMethod.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPDDeliveryMethod.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPDDeliveryMethod.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}