//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefISO6395LanguageFamily.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefISO6395LanguageFamily
     /// </summary>
    public partial interface IRefISO6395LanguageFamily
    {
        /// <summary>
        /// Defines the RefISO6395LanguageFamily.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefISO6395LanguageFamily.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefISO6395LanguageFamily.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefISO6395LanguageFamily.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefISO6395LanguageFamily.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefISO6395LanguageFamily.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
