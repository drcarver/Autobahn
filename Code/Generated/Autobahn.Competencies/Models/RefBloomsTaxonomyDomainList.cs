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
        public static List<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomainList = new List<RefBloomsTaxonomyDomain> =
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("46debe41-d76f-4dbf-b81d-3afa68f6ce97"), Code="mental skills (knowledge)", Description="Cognitive", Definition="", SortOrder=0 },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("b1a10a08-8ba8-4f16-8b34-d65c65ee81ff"), Code="growth in feelings or emotional areas (attitude or self)", Description="Affective", Definition="", SortOrder=0 },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("6b1565fc-1028-4bd7-be45-9714f4874557"), Code="manual or physical skills (skills)", Description="Psychomotor", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBloomsTaxonomyDomain Pick List
         /// </summary>
        public static List<RefBloomsTaxonomyDomain> RefBloomsTaxonomyDomainPickList = new List<RefBloomsTaxonomyDomain> =
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("46debe41-d76f-4dbf-b81d-3afa68f6ce97"), Code="mental skills (knowledge)", SortOrder=0 },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("b1a10a08-8ba8-4f16-8b34-d65c65ee81ff"), Code="growth in feelings or emotional areas (attitude or self)", SortOrder=0 },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("6b1565fc-1028-4bd7-be45-9714f4874557"), Code="manual or physical skills (skills)", SortOrder=0 },
       };
   }
}
