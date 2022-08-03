//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefItemResponseTheoryDifficultyCategory.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefItemResponseTheoryDifficultyCategory
     /// </summary>
    public partial interface IRefItemResponseTheoryDifficultyCategory
    {
        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
