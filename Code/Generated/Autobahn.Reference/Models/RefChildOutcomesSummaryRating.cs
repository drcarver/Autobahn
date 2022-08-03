//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefChildOutcomesSummaryRating.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefChildOutcomesSummaryRating
     /// </summary>
    public partial class RefChildOutcomesSummaryRating : IRefChildOutcomesSummaryRating
    {
        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
