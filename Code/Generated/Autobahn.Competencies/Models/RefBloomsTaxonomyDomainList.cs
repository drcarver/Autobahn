//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefBloomsTaxonomyDomainList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefBloomsTaxonomyDomain Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBloomsTaxonomyDomain"> List
         /// </summary>
        public static List<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomainList = new List<RefBloomsTaxonomyDomain>
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("84cef735-ddab-47f8-82b1-c985a8d9bccb"), Code="Cognitive", Description="Cognitive", Definition="mental skills (knowledge)", SortOrder=Convert.ToDecimal("1.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("82a2cfed-aad1-4305-9a94-8743b890e951"), Code="Affective", Description="Affective", Definition="growth in feelings or emotional areas (attitude or self)", SortOrder=Convert.ToDecimal("2.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("7cbf1d63-7562-477c-8858-1e3700044239"), Code="Psychomotor", Description="Psychomotor", Definition="manual or physical skills (skills)", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefBloomsTaxonomyDomain Pick List
         /// </summary>
        public static List<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomainPickList = new List<RefBloomsTaxonomyDomain>
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("84cef735-ddab-47f8-82b1-c985a8d9bccb"), Code="Cognitive", Description="Cognitive", SortOrder=Convert.ToDecimal("1.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("82a2cfed-aad1-4305-9a94-8743b890e951"), Code="Affective", Description="Affective", SortOrder=Convert.ToDecimal("2.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("7cbf1d63-7562-477c-8858-1e3700044239"), Code="Psychomotor", Description="Psychomotor", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
