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
        public static List<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategoryList = new List<RefIDEAPartCEligibilityCategory> =
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("45affcdf-f1bb-418c-a2f7-ba6a5eb11167"), Code="The child has one or more delays as measured by appropriate diagnostic instruments and procedures in 1 or more of the areas of cognitive development, physical development, communication  development, social or emotional development, and adaptive development.", Description="DevelopmentalDelay", Definition="", SortOrder=0 },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("902a3908-bb59-4eba-a871-be4cd3ad51d7"), Code="The child has a diagnosed physical or mental condition that has a high probability of resulting in developmental delay.", Description="DiagnosedCondition", Definition="", SortOrder=0 },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("f481d4bf-1b41-4257-9bde-b7befaa3c901"), Code="The child would be at risk of experiencing a substantial developmental delay if early intervention services were not provided to the child.", Description="AtRisk", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIDEAPartCEligibilityCategory Pick List
         /// </summary>
        public static List<RefIDEAPartCEligibilityCategory> RefIDEAPartCEligibilityCategoryPickList = new List<RefIDEAPartCEligibilityCategory> =
        {
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("45affcdf-f1bb-418c-a2f7-ba6a5eb11167"), Code="The child has one or more delays as measured by appropriate diagnostic instruments and procedures in 1 or more of the areas of cognitive development, physical development, communication  development, social or emotional development, and adaptive development.", SortOrder=0 },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("902a3908-bb59-4eba-a871-be4cd3ad51d7"), Code="The child has a diagnosed physical or mental condition that has a high probability of resulting in developmental delay.", SortOrder=0 },
            new RefIDEAPartCEligibilityCategory { Id=Guid.Parse("f481d4bf-1b41-4257-9bde-b7befaa3c901"), Code="The child would be at risk of experiencing a substantial developmental delay if early intervention services were not provided to the child.", SortOrder=0 },
       };
   }
}
