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
        /// The complete <see cref="RefBloomsTaxonomyDomainModel"> List
         /// </summary>
        public static List<RefBloomsTaxonomyDomainModel> RefBloomsTaxonomyDomainList = new List<RefBloomsTaxonomyDomainModel>
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("9020204a-cf41-4698-86c1-bfa11826f5f7"), Code="Cognitive", Description="Cognitive", Definition="mental skills (knowledge)", SortOrder=Convert.ToDecimal("1.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("aaf68078-3f9a-4254-8062-6fccc40dad45"), Code="Affective", Description="Affective", Definition="growth in feelings or emotional areas (attitude or self)", SortOrder=Convert.ToDecimal("2.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("fc98ac5f-1e61-409e-b395-0146e0223e62"), Code="Psychomotor", Description="Psychomotor", Definition="manual or physical skills (skills)", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefBloomsTaxonomyDomain Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBloomsTaxonomyDomainViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("9020204a-cf41-4698-86c1-bfa11826f5f7"), Description="Cognitive", SortOrder=Convert.ToDecimal("1.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("aaf68078-3f9a-4254-8062-6fccc40dad45"), Description="Affective", SortOrder=Convert.ToDecimal("2.00") },
            new RefBloomsTaxonomyDomain { Id=Guid.Parse("fc98ac5f-1e61-409e-b395-0146e0223e62"), Description="Psychomotor", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
