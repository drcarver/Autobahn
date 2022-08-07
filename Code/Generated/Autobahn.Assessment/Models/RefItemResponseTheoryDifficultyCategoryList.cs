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
        /// The complete <see cref="RefItemResponseTheoryDifficultyCategoryModel"> List
         /// </summary>
        public static List<RefItemResponseTheoryDifficultyCategoryModel> RefItemResponseTheoryDifficultyCategoryList = new List<RefItemResponseTheoryDifficultyCategoryModel>
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("91721716-1cb2-4677-a385-9cdf3ebecab6"), Code="None", Description="None: 0", Definition="The category for the difficulty of the item based on the Item Response Theory value is None: 0", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("2e9b698e-5eb6-4298-a455-cdf18ad04229"), Code="VeryLow", Description="Very low: 0.01 - 0.34", Definition="The category for the difficulty of the item based on the Item Response Theory value is Very low: 0.01 - 0.34", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("7b1942b9-8de3-454f-ac43-c4b548536196"), Code="Low", Description="Low: 0.35 - 0.64", Definition="The category for the difficulty of the item based on the Item Response Theory value is Low: 0.35 - 0.64", SortOrder=Convert.ToDecimal("3.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("488be051-4ab2-4fd1-bd7c-789aba7f6762"), Code="Moderate", Description="Moderate: 0.65 - 1.34", Definition="The category for the difficulty of the item based on the Item Response Theory value is Moderate: 0.65 - 1.34", SortOrder=Convert.ToDecimal("4.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("686bed00-80e3-4bb1-a789-3cb09e0af30f"), Code="High", Description="High: 1.35 - 1.69", Definition="The category for the difficulty of the item based on the Item Response Theory value is High: 1.35 - 1.69", SortOrder=Convert.ToDecimal("5.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("5e3d94b2-56e9-4e71-aef9-c23ee5989211"), Code="VeryHigh", Description="Very high: > 1.70", Definition="The category for the difficulty of the item based on the Item Response Theory value is Very high: > 1.70", SortOrder=Convert.ToDecimal("6.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("845a0dc3-5468-4bd2-932c-77173c65e3f3"), Code="Perfect", Description="Perfect: + infinity", Definition="The category for the difficulty of the item based on the Item Response Theory value is Perfect: + infinity", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefItemResponseTheoryDifficultyCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefItemResponseTheoryDifficultyCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("91721716-1cb2-4677-a385-9cdf3ebecab6"), Description="None: 0", SortOrder=Convert.ToDecimal("1.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("2e9b698e-5eb6-4298-a455-cdf18ad04229"), Description="Very low: 0.01 - 0.34", SortOrder=Convert.ToDecimal("2.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("7b1942b9-8de3-454f-ac43-c4b548536196"), Description="Low: 0.35 - 0.64", SortOrder=Convert.ToDecimal("3.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("488be051-4ab2-4fd1-bd7c-789aba7f6762"), Description="Moderate: 0.65 - 1.34", SortOrder=Convert.ToDecimal("4.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("686bed00-80e3-4bb1-a789-3cb09e0af30f"), Description="High: 1.35 - 1.69", SortOrder=Convert.ToDecimal("5.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("5e3d94b2-56e9-4e71-aef9-c23ee5989211"), Description="Very high: > 1.70", SortOrder=Convert.ToDecimal("6.00") },
            new RefItemResponseTheoryDifficultyCategory { Id=Guid.Parse("845a0dc3-5468-4bd2-932c-77173c65e3f3"), Description="Perfect: + infinity", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
