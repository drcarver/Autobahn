//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSiteUseRestrictionsTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingSiteUseRestrictionsType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingSiteUseRestrictionsTypeModel"> List
         /// </summary>
        public static List<RefBuildingSiteUseRestrictionsTypeModel> RefBuildingSiteUseRestrictionsTypeList = new List<RefBuildingSiteUseRestrictionsTypeModel>
        {
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("45e55751-3f12-473b-9fe4-68b44eaa45d4"), Code="02446", Description="Enterprise zone", Definition="The government identification for special funding opportunities based on income of residents of the area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("3847944f-845e-4495-a339-9a02ddb376d6"), Code="02449", Description="Environmental contamination", Definition="All or a portion of the site is subject to any environmental contamination such as oil or toxic soil conditions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("12d254e2-fd0a-4339-a6fe-d5655b2b08f0"), Code="02448", Description="Environmental protection", Definition="All or a portion of the site is protected under any environmental restrictions for development, such as wetlands.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("9bf1aab5-4667-430e-9303-19d3158102dc"), Code="02447", Description="Historic district", Definition="The school or LEA facility is located in a publicly designated historic district, whether or not the facility itself is historic.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("d0fbc297-0e37-487a-a2d0-79c98dcff9ab"), Code="02445", Description="Land use", Definition="The underlying municipal zoning regulation which guides the potential development of a site.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("d2ac74ae-849f-43ba-b1ec-040913898ce9"), Code="02450", Description="Site easements", Definition="The covenants legally attached to a site, including agreements allowing other parties to use the site and agreements allowing the LEA to use sites belonging to others.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("33b7f278-54b2-429e-8fdb-3e88258090c0"), Code="09999", Description="Other", Definition="Other is specified as a characterization of a site that would define restrictions or opportunities.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingSiteUseRestrictionsType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingSiteUseRestrictionsTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("45e55751-3f12-473b-9fe4-68b44eaa45d4"), Description="Enterprise zone", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("3847944f-845e-4495-a339-9a02ddb376d6"), Description="Environmental contamination", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("12d254e2-fd0a-4339-a6fe-d5655b2b08f0"), Description="Environmental protection", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("9bf1aab5-4667-430e-9303-19d3158102dc"), Description="Historic district", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("d0fbc297-0e37-487a-a2d0-79c98dcff9ab"), Description="Land use", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("d2ac74ae-849f-43ba-b1ec-040913898ce9"), Description="Site easements", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("33b7f278-54b2-429e-8fdb-3e88258090c0"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
