//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefIDEAPartCEligibilityCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefIDEAPartCEligibilityCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAPartCEligibilityCategoryModel"> List
         /// </summary>
        public static List<RefIDEAPartCEligibilityCategoryModel> RefIDEAPartCEligibilityCategoryList = new List<RefIDEAPartCEligibilityCategoryModel>
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("f009fde5-5a59-4bbc-acaa-f8513c1a0019"), Code="DevelopmentalDelay", Description="Developmental Delay", Definition="The child has one or more delays as measured by appropriate diagnostic instruments and procedures in 1 or more of the areas of cognitive development, physical development, communication  development, social or emotional development, and adaptive development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("0c4877f6-36dd-4197-9ea6-7150f1a5ac0f"), Code="DiagnosedCondition", Description="Diagnosed Condition", Definition="The child has a diagnosed physical or mental condition that has a high probability of resulting in developmental delay.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("8fcfb353-ec76-4e14-bc97-f3cc1f725da3"), Code="AtRisk", Description="At-risk", Definition="The child would be at risk of experiencing a substantial developmental delay if early intervention services were not provided to the child.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefIDEAPartCEligibilityCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAPartCEligibilityCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("f009fde5-5a59-4bbc-acaa-f8513c1a0019"), Description="Developmental Delay", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("0c4877f6-36dd-4197-9ea6-7150f1a5ac0f"), Description="Diagnosed Condition", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("8fcfb353-ec76-4e14-bc97-f3cc1f725da3"), Description="At-risk", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
