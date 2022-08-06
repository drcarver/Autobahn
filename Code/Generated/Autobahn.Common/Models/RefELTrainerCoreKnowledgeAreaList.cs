//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefELTrainerCoreKnowledgeAreaList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefELTrainerCoreKnowledgeArea Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELTrainerCoreKnowledgeArea"> List
         /// </summary>
        public static List<RefELTrainerCoreKnowledgeArea> RefELTrainerCoreKnowledgeAreaList = new List<RefELTrainerCoreKnowledgeArea>
        {
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("56a81ed0-aac7-4425-ae94-f40abdd1d3b5"), Code="01", Description="Child growth and development", Definition="Child growth and development is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("b1b1fd17-74ba-4993-a6e6-d5185d965843"), Code="02", Description="Health safety and nutrition", Definition="Health safety and nutrition is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("2d6b02d7-1560-4507-bf90-db8461892285"), Code="03", Description="Teaching and learning", Definition="Teaching and learning is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("6f468720-fffe-4aeb-83a5-c4f6b3caf18a"), Code="04", Description="Observing, documenting and assessing", Definition="Observing, documenting and assessing is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("57feb1a9-fca6-4b32-ab08-a52ffcf14010"), Code="05", Description="Family and community relationships", Definition="Family and community relationships is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("34f428f7-0450-4958-af63-b4ce59e89e4c"), Code="06", Description="Administration and management", Definition="Administration and management is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("59bb9392-999a-452c-92f4-6f2edb9dcf27"), Code="07", Description="Early childhood education profession and policy", Definition="Early childhood education profession and policy is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("13.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("ca32cb2c-5a4b-43cc-9e71-379a482034c6"), Code="99", Description="Other", Definition="The core knowledge expertise of a trainer of a professional development experience is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefELTrainerCoreKnowledgeArea Pick List
         /// </summary>
        public static List<RefELTrainerCoreKnowledgeArea> RefELTrainerCoreKnowledgeAreaPickList = new List<RefELTrainerCoreKnowledgeArea>
        {
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("56a81ed0-aac7-4425-ae94-f40abdd1d3b5"), Code="01", Description="Child growth and development", SortOrder=Convert.ToDecimal("1.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("b1b1fd17-74ba-4993-a6e6-d5185d965843"), Code="02", Description="Health safety and nutrition", SortOrder=Convert.ToDecimal("3.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("2d6b02d7-1560-4507-bf90-db8461892285"), Code="03", Description="Teaching and learning", SortOrder=Convert.ToDecimal("5.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("6f468720-fffe-4aeb-83a5-c4f6b3caf18a"), Code="04", Description="Observing, documenting and assessing", SortOrder=Convert.ToDecimal("7.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("57feb1a9-fca6-4b32-ab08-a52ffcf14010"), Code="05", Description="Family and community relationships", SortOrder=Convert.ToDecimal("9.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("34f428f7-0450-4958-af63-b4ce59e89e4c"), Code="06", Description="Administration and management", SortOrder=Convert.ToDecimal("11.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("59bb9392-999a-452c-92f4-6f2edb9dcf27"), Code="07", Description="Early childhood education profession and policy", SortOrder=Convert.ToDecimal("13.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("ca32cb2c-5a4b-43cc-9e71-379a482034c6"), Code="99", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
