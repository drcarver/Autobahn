//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefBarrierToEducatingHomeless.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefBarrierToEducatingHomeless
     /// </summary>
    public partial class RefBarrierToEducatingHomeless : IRefBarrierToEducatingHomeless
    {
        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefBarrierToEducatingHomeless.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
