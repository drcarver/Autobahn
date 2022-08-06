//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefItemResponseTheoryDifficultyCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefItemResponseTheoryDifficultyCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefItemResponseTheoryDifficultyCategory"> List
         /// </summary>
        public static List<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategoryList = new List<RefItemResponseTheoryDifficultyCategory> =
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("5af8f49a-0de6-4825-aed4-f3ee27624086"), Code="The category for the difficulty of the item based on the Item Response Theory value is None: 0", Description="None", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("2a288b77-fa60-4ec5-9777-7ad46893dc01"), Code="The category for the difficulty of the item based on the Item Response Theory value is Very low: 0.01 - 0.34", Description="VeryLow", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("e18c1944-88f1-4c02-91d3-3c8a3529cdf4"), Code="The category for the difficulty of the item based on the Item Response Theory value is Low: 0.35 - 0.64", Description="Low", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("1a239ea4-f0fe-486c-839f-627ed2efe2be"), Code="The category for the difficulty of the item based on the Item Response Theory value is Moderate: 0.65 - 1.34", Description="Moderate", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("e4faec5b-8586-453a-8098-55b2f7e6dbdd"), Code="The category for the difficulty of the item based on the Item Response Theory value is High: 1.35 - 1.69", Description="High", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("411f612b-09e2-411a-9e33-74e2c603a438"), Code="The category for the difficulty of the item based on the Item Response Theory value is Very high: > 1.70", Description="VeryHigh", Definition="", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("f1002c59-f338-40b2-9346-9dd8e948f596"), Code="The category for the difficulty of the item based on the Item Response Theory value is Perfect: + infinity", Description="Perfect", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefItemResponseTheoryDifficultyCategory Pick List
         /// </summary>
        public static List<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategoryPickList = new List<RefItemResponseTheoryDifficultyCategory> =
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("5af8f49a-0de6-4825-aed4-f3ee27624086"), Code="The category for the difficulty of the item based on the Item Response Theory value is None: 0", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("2a288b77-fa60-4ec5-9777-7ad46893dc01"), Code="The category for the difficulty of the item based on the Item Response Theory value is Very low: 0.01 - 0.34", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("e18c1944-88f1-4c02-91d3-3c8a3529cdf4"), Code="The category for the difficulty of the item based on the Item Response Theory value is Low: 0.35 - 0.64", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("1a239ea4-f0fe-486c-839f-627ed2efe2be"), Code="The category for the difficulty of the item based on the Item Response Theory value is Moderate: 0.65 - 1.34", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("e4faec5b-8586-453a-8098-55b2f7e6dbdd"), Code="The category for the difficulty of the item based on the Item Response Theory value is High: 1.35 - 1.69", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("411f612b-09e2-411a-9e33-74e2c603a438"), Code="The category for the difficulty of the item based on the Item Response Theory value is Very high: > 1.70", SortOrder=0 },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("f1002c59-f338-40b2-9346-9dd8e948f596"), Code="The category for the difficulty of the item based on the Item Response Theory value is Perfect: + infinity", SortOrder=0 },
       };
   }
}
