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
        /// The complete <see cref="RefIDEAPartCEligibilityCategory"> List
         /// </summary>
        public static List<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategoryList = new List<RefIDEAPartCEligibilityCategory>
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("50b1f26a-f716-491e-8d95-d09ee4bcdc70"), Code="DevelopmentalDelay", Description="Developmental Delay", Definition="The child has one or more delays as measured by appropriate diagnostic instruments and procedures in 1 or more of the areas of cognitive development, physical development, communication  development, social or emotional development, and adaptive development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("5fcd420b-40ce-4ea9-9ab3-2e24be3086f4"), Code="DiagnosedCondition", Description="Diagnosed Condition", Definition="The child has a diagnosed physical or mental condition that has a high probability of resulting in developmental delay.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("4c8c2970-0b62-428b-ae34-fbb7a4a51c88"), Code="AtRisk", Description="At-risk", Definition="The child would be at risk of experiencing a substantial developmental delay if early intervention services were not provided to the child.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefIDEAPartCEligibilityCategory Pick List
         /// </summary>
        public static List<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategoryPickList = new List<RefIDEAPartCEligibilityCategory>
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("50b1f26a-f716-491e-8d95-d09ee4bcdc70"), Code="DevelopmentalDelay", Description="Developmental Delay", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("5fcd420b-40ce-4ea9-9ab3-2e24be3086f4"), Code="DiagnosedCondition", Description="Diagnosed Condition", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("4c8c2970-0b62-428b-ae34-fbb7a4a51c88"), Code="AtRisk", Description="At-risk", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
