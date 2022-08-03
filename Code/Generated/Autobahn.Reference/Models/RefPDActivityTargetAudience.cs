//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefPDActivityTargetAudience.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefPDActivityTargetAudience
     /// </summary>
    public partial class RefPDActivityTargetAudience : IRefPDActivityTargetAudience
    {
        /// <summary>
        /// Defines the RefPDActivityTargetAudience.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPDActivityTargetAudience.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPDActivityTargetAudience.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefPDActivityTargetAudience.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPDActivityTargetAudience.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPDActivityTargetAudience.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
