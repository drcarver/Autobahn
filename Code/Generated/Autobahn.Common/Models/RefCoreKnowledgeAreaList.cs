//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCoreKnowledgeAreaList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCoreKnowledgeArea Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCoreKnowledgeAreaModel"> List
         /// </summary>
        public static List<RefCoreKnowledgeAreaModel> RefCoreKnowledgeAreaList = new List<RefCoreKnowledgeAreaModel>
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("5a15b0cd-71a0-46ae-8aba-f5c69cb3a729"), Code="01", Description="Child growth and development", Definition="Child growth and development is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("c0dc4b6b-935f-4aa9-a34a-cdba8bb6e8c5"), Code="02", Description="Health safety and nutrition", Definition="Health safety and nutrition is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("cd109772-4ec8-472a-beeb-1a18815bcb97"), Code="03", Description="Teaching and learning", Definition="Teaching and learning is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("a47aa060-539b-4b72-a9f5-5f9b7cce6213"), Code="04", Description="Observing, documenting and assessing", Definition="Observing, documenting and assessing is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("2902f228-50f5-4d4e-b1a8-aeaa890102bd"), Code="05", Description="Family and community relationships", Definition="Family and community relationships is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("e97fba12-4452-44af-9da6-6e19f9c7d1eb"), Code="06", Description="Administration and management", Definition="Administration and management is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("24795915-5c55-4bec-98a3-0a8f18f85451"), Code="07", Description="Early childhood education profession and policy", Definition="Early childhood education profession and policy is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefCoreKnowledgeArea Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCoreKnowledgeAreaViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("5a15b0cd-71a0-46ae-8aba-f5c69cb3a729"), Description="Child growth and development", SortOrder=Convert.ToDecimal("1.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("c0dc4b6b-935f-4aa9-a34a-cdba8bb6e8c5"), Description="Health safety and nutrition", SortOrder=Convert.ToDecimal("2.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("cd109772-4ec8-472a-beeb-1a18815bcb97"), Description="Teaching and learning", SortOrder=Convert.ToDecimal("3.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("a47aa060-539b-4b72-a9f5-5f9b7cce6213"), Description="Observing, documenting and assessing", SortOrder=Convert.ToDecimal("4.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("2902f228-50f5-4d4e-b1a8-aeaa890102bd"), Description="Family and community relationships", SortOrder=Convert.ToDecimal("5.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("e97fba12-4452-44af-9da6-6e19f9c7d1eb"), Description="Administration and management", SortOrder=Convert.ToDecimal("6.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("24795915-5c55-4bec-98a3-0a8f18f85451"), Description="Early childhood education profession and policy", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
