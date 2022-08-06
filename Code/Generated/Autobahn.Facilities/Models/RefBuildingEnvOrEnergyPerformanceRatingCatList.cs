//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingEnvOrEnergyPerformanceRatingCatList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingEnvOrEnergyPerformanceRatingCat Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"> List
         /// </summary>
        public static List<RefBuildingEnvOrEnergyPerformanceRatingCat> RefBuildingEnvOrEnergyPerformanceRatingCatList = new List<RefBuildingEnvOrEnergyPerformanceRatingCat>
        {
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("73dd6e9b-9af2-4a91-a876-58b257f746e3"), Code="13620", Description="Climate/Emissions", Definition="CHPS and Green Globes have climate/emissions as a credit category. Credits/prerequisites include greenhouse gas emission reduction.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("6b43bd95-942c-4a67-bdeb-eb8827ce2067"), Code="13621", Description="Energy", Definition="Emissions Reduction Reporting", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("6e134ae9-66d8-4756-8d18-e1509533f6c3"), Code="13622", Description="Indoor Environmental Quality", Definition="Thermal Comfort", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("a4a3f292-ff7b-4122-8226-7af7babe6dec"), Code="13623", Description="Innovations in Operations/ Project/ Environmental Management", Definition="LEED and Green Globes have innovations in operations/ project/ environmental management as a credit category. Credits recognize projects for innovative and exemplary technologies, methods, project planning, and project execution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("47c634ba-f194-47c3-bbe9-25af8ea75ac9"), Code="13624", Description="Leadership, Education and Innovation", Definition="Schools as Learning Tools", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("8674c152-a5af-4c9b-952f-2890d44189f1"), Code="13625", Description="Materials and Resources", Definition="Building Reuse", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("b1dadac6-61e4-417e-af0e-f7b9bac0a4ac"), Code="13626", Description="Regional Priority", Definition="LEED has regional priority as a credit category. Credits address environmental concerns that are local priorities for each region of the country, as identified by USGBC''s regional councils, chapters and affiliates.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("640bec5c-82aa-4eaf-8f5a-c060a836f646"), Code="13627", Description="Sustainable Sites", Definition="LEED, CHPS, and Green Globes have sustainable sites as a credit category. Credits/prerequisites promote responsible, innovative and practical site maintenance strategies that are sensitive to plants, wildlife and water and air quality.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefBuildingEnvOrEnergyPerformanceRatingCat Pick List
         /// </summary>
        public static List<RefBuildingEnvOrEnergyPerformanceRatingCat> RefBuildingEnvOrEnergyPerformanceRatingCatPickList = new List<RefBuildingEnvOrEnergyPerformanceRatingCat>
        {
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("73dd6e9b-9af2-4a91-a876-58b257f746e3"), Code="13620", Description="Climate/Emissions", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("6b43bd95-942c-4a67-bdeb-eb8827ce2067"), Code="13621", Description="Energy", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("6e134ae9-66d8-4756-8d18-e1509533f6c3"), Code="13622", Description="Indoor Environmental Quality", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("a4a3f292-ff7b-4122-8226-7af7babe6dec"), Code="13623", Description="Innovations in Operations/ Project/ Environmental Management", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("47c634ba-f194-47c3-bbe9-25af8ea75ac9"), Code="13624", Description="Leadership, Education and Innovation", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("8674c152-a5af-4c9b-952f-2890d44189f1"), Code="13625", Description="Materials and Resources", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("b1dadac6-61e4-417e-af0e-f7b9bac0a4ac"), Code="13626", Description="Regional Priority", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("640bec5c-82aa-4eaf-8f5a-c060a836f646"), Code="13627", Description="Sustainable Sites", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
