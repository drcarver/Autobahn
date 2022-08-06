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
        /// The complete <see cref="RefBuildingSiteUseRestrictionsType"> List
         /// </summary>
        public static List<RefBuildingSiteUseRestrictionsType> RefBuildingSiteUseRestrictionsTypeList = new List<RefBuildingSiteUseRestrictionsType>
        {
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("ac75cde0-10aa-4c20-86ac-2be295edae0b"), Code="02446", Description="Enterprise zone", Definition="The government identification for special funding opportunities based on income of residents of the area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("3244fa8d-fe7e-4d8f-a135-01a1f3e45e3c"), Code="02449", Description="Environmental contamination", Definition="All or a portion of the site is subject to any environmental contamination such as oil or toxic soil conditions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("44c1d431-e07b-4495-ae53-02606caac277"), Code="02448", Description="Environmental protection", Definition="All or a portion of the site is protected under any environmental restrictions for development, such as wetlands.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("c106a965-c998-4d7d-b8cd-d134cc56ea33"), Code="02447", Description="Historic district", Definition="The school or LEA facility is located in a publicly designated historic district, whether or not the facility itself is historic.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("5d4edce0-900e-4c11-bf4b-0abcb41db207"), Code="02445", Description="Land use", Definition="The underlying municipal zoning regulation which guides the potential development of a site.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("4b463215-0810-4d74-b246-a0798f411e11"), Code="02450", Description="Site easements", Definition="The covenants legally attached to a site, including agreements allowing other parties to use the site and agreements allowing the LEA to use sites belonging to others.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("1fa33ecd-b79a-4ff6-a9fd-011919a2a72c"), Code="09999", Description="Other", Definition="Other is specified as a characterization of a site that would define restrictions or opportunities.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingSiteUseRestrictionsType Pick List
         /// </summary>
        public static List<RefBuildingSiteUseRestrictionsType> RefBuildingSiteUseRestrictionsTypePickList = new List<RefBuildingSiteUseRestrictionsType>
        {
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("ac75cde0-10aa-4c20-86ac-2be295edae0b"), Code="02446", Description="Enterprise zone", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("3244fa8d-fe7e-4d8f-a135-01a1f3e45e3c"), Code="02449", Description="Environmental contamination", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("44c1d431-e07b-4495-ae53-02606caac277"), Code="02448", Description="Environmental protection", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("c106a965-c998-4d7d-b8cd-d134cc56ea33"), Code="02447", Description="Historic district", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("5d4edce0-900e-4c11-bf4b-0abcb41db207"), Code="02445", Description="Land use", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("4b463215-0810-4d74-b246-a0798f411e11"), Code="02450", Description="Site easements", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSiteUseRestrictionsType { Id=Guid.Parse("1fa33ecd-b79a-4ff6-a9fd-011919a2a72c"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
