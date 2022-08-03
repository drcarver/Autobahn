//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefChildOutcomesSummaryRating.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefChildOutcomesSummaryRating
     /// </summary>
    public partial interface IRefChildOutcomesSummaryRating
    {
        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefChildOutcomesSummaryRating.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
