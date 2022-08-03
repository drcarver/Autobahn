//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefItemResponseTheoryDifficultyCategory.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefItemResponseTheoryDifficultyCategory
     /// </summary>
    public partial class RefItemResponseTheoryDifficultyCategory : IRefItemResponseTheoryDifficultyCategory
    {
        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefItemResponseTheoryDifficultyCategory.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
