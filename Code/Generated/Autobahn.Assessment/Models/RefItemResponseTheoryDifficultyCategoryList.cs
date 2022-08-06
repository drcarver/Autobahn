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
        public static List<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategoryList = new List<RefItemResponseTheoryDifficultyCategory>
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("0ecaea73-cbfe-48c6-b186-08e8f61706d2"), Code="None", Description="None: 0", Definition="The category for the difficulty of the item based on the Item Response Theory value is None: 0", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("b86a1e57-210f-4849-8794-750633ae04dc"), Code="VeryLow", Description="Very low: 0.01 - 0.34", Definition="The category for the difficulty of the item based on the Item Response Theory value is Very low: 0.01 - 0.34", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("cdde674b-c5da-4546-a470-1b1dc78c07e0"), Code="Low", Description="Low: 0.35 - 0.64", Definition="The category for the difficulty of the item based on the Item Response Theory value is Low: 0.35 - 0.64", SortOrder=Convert.ToDecimal("3.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("6bcedc8a-6106-4006-8815-ff05df16c8ff"), Code="Moderate", Description="Moderate: 0.65 - 1.34", Definition="The category for the difficulty of the item based on the Item Response Theory value is Moderate: 0.65 - 1.34", SortOrder=Convert.ToDecimal("4.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("a68643fa-40d1-4599-8153-f40f37657caa"), Code="High", Description="High: 1.35 - 1.69", Definition="The category for the difficulty of the item based on the Item Response Theory value is High: 1.35 - 1.69", SortOrder=Convert.ToDecimal("5.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("a3e43bf2-cd11-469d-be14-3b8563e3f8ea"), Code="VeryHigh", Description="Very high: > 1.70", Definition="The category for the difficulty of the item based on the Item Response Theory value is Very high: > 1.70", SortOrder=Convert.ToDecimal("6.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("8f496800-5a17-4ba0-ab03-9051ff623f9c"), Code="Perfect", Description="Perfect: + infinity", Definition="The category for the difficulty of the item based on the Item Response Theory value is Perfect: + infinity", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefItemResponseTheoryDifficultyCategory Pick List
         /// </summary>
        public static List<RefItemResponseTheoryDifficultyCategory> RefItemResponseTheoryDifficultyCategoryPickList = new List<RefItemResponseTheoryDifficultyCategory>
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("0ecaea73-cbfe-48c6-b186-08e8f61706d2"), Code="None", Description="None: 0", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("b86a1e57-210f-4849-8794-750633ae04dc"), Code="VeryLow", Description="Very low: 0.01 - 0.34", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("cdde674b-c5da-4546-a470-1b1dc78c07e0"), Code="Low", Description="Low: 0.35 - 0.64", SortOrder=Convert.ToDecimal("3.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("6bcedc8a-6106-4006-8815-ff05df16c8ff"), Code="Moderate", Description="Moderate: 0.65 - 1.34", SortOrder=Convert.ToDecimal("4.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("a68643fa-40d1-4599-8153-f40f37657caa"), Code="High", Description="High: 1.35 - 1.69", SortOrder=Convert.ToDecimal("5.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("a3e43bf2-cd11-469d-be14-3b8563e3f8ea"), Code="VeryHigh", Description="Very high: > 1.70", SortOrder=Convert.ToDecimal("6.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("8f496800-5a17-4ba0-ab03-9051ff623f9c"), Code="Perfect", Description="Perfect: + infinity", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
