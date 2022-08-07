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
        /// The complete <see cref="RefBuildingEnvOrEnergyPerformanceRatingCatModel"> List
         /// </summary>
        public static List<RefBuildingEnvOrEnergyPerformanceRatingCatModel> RefBuildingEnvOrEnergyPerformanceRatingCatList = new List<RefBuildingEnvOrEnergyPerformanceRatingCatModel>
        {
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("74adfabe-b2bb-4205-a8d6-b916f88286f6"), Code="13620", Description="Climate/Emissions", Definition="CHPS and Green Globes have climate/emissions as a credit category. Credits/prerequisites include greenhouse gas emission reduction.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("434ab810-2209-4e5d-b051-af71de02dfb5"), Code="13621", Description="Energy", Definition="Emissions Reduction Reporting", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("becee14f-944b-4a67-87dd-259089610e4e"), Code="13622", Description="Indoor Environmental Quality", Definition="Thermal Comfort", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("792a90a2-3cdc-4707-b075-97df8926f382"), Code="13623", Description="Innovations in Operations/ Project/ Environmental Management", Definition="LEED and Green Globes have innovations in operations/ project/ environmental management as a credit category. Credits recognize projects for innovative and exemplary technologies, methods, project planning, and project execution.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("3ce6b9f7-dcb0-4585-93c5-ed87bc75c403"), Code="13624", Description="Leadership, Education and Innovation", Definition="Schools as Learning Tools", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("529453d2-88d1-45c8-ac3a-28264dca5da4"), Code="13625", Description="Materials and Resources", Definition="Building Reuse", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("7082a62e-a113-4962-a931-4bc6936b4de9"), Code="13626", Description="Regional Priority", Definition="LEED has regional priority as a credit category. Credits address environmental concerns that are local priorities for each region of the country, as identified by USGBC''s regional councils, chapters and affiliates.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("aa8a3591-8263-4c18-a7b2-feedfdacdea8"), Code="13627", Description="Sustainable Sites", Definition="LEED, CHPS, and Green Globes have sustainable sites as a credit category. Credits/prerequisites promote responsible, innovative and practical site maintenance strategies that are sensitive to plants, wildlife and water and air quality.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefBuildingEnvOrEnergyPerformanceRatingCat Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingEnvOrEnergyPerformanceRatingCatViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("74adfabe-b2bb-4205-a8d6-b916f88286f6"), Description="Climate/Emissions", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("434ab810-2209-4e5d-b051-af71de02dfb5"), Description="Energy", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("becee14f-944b-4a67-87dd-259089610e4e"), Description="Indoor Environmental Quality", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("792a90a2-3cdc-4707-b075-97df8926f382"), Description="Innovations in Operations/ Project/ Environmental Management", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("3ce6b9f7-dcb0-4585-93c5-ed87bc75c403"), Description="Leadership, Education and Innovation", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("529453d2-88d1-45c8-ac3a-28264dca5da4"), Description="Materials and Resources", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("7082a62e-a113-4962-a931-4bc6936b4de9"), Description="Regional Priority", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnvOrEnergyPerformanceRatingCat { Id=Guid.Parse("aa8a3591-8263-4c18-a7b2-feedfdacdea8"), Description="Sustainable Sites", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
