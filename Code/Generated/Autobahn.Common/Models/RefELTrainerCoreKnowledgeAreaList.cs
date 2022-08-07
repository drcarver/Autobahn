//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefELTrainerCoreKnowledgeAreaList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefELTrainerCoreKnowledgeArea Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELTrainerCoreKnowledgeAreaModel"> List
         /// </summary>
        public static List<RefELTrainerCoreKnowledgeAreaModel> RefELTrainerCoreKnowledgeAreaList = new List<RefELTrainerCoreKnowledgeAreaModel>
        {
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("1407637c-2343-49e1-bccd-f402975339ef"), Code="01", Description="Child growth and development", Definition="Child growth and development is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("66d0ae53-7940-4bf8-9ca7-aed7a4f75c31"), Code="02", Description="Health safety and nutrition", Definition="Health safety and nutrition is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("d32fa88a-2f82-4fd1-ad1a-9d659f311482"), Code="03", Description="Teaching and learning", Definition="Teaching and learning is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("08dd3663-6098-40de-be6d-89bb75e8e243"), Code="04", Description="Observing, documenting and assessing", Definition="Observing, documenting and assessing is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("12ae378d-9011-429a-af00-17508a4d24e8"), Code="05", Description="Family and community relationships", Definition="Family and community relationships is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("93f0d1e4-ecb6-4995-9f38-be46b932daa7"), Code="06", Description="Administration and management", Definition="Administration and management is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("9cf8fdb0-2020-4bd9-9ebf-9d9d69319e6b"), Code="07", Description="Early childhood education profession and policy", Definition="Early childhood education profession and policy is the core knowledge expertise of a trainer of a professional development experience.", SortOrder=Convert.ToDecimal("13.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("d8627420-7d5a-4cc5-a77a-4b3c87bfd7e6"), Code="99", Description="Other", Definition="The core knowledge expertise of a trainer of a professional development experience is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefELTrainerCoreKnowledgeArea Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELTrainerCoreKnowledgeAreaViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("1407637c-2343-49e1-bccd-f402975339ef"), Description="Child growth and development", SortOrder=Convert.ToDecimal("1.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("66d0ae53-7940-4bf8-9ca7-aed7a4f75c31"), Description="Health safety and nutrition", SortOrder=Convert.ToDecimal("3.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("d32fa88a-2f82-4fd1-ad1a-9d659f311482"), Description="Teaching and learning", SortOrder=Convert.ToDecimal("5.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("08dd3663-6098-40de-be6d-89bb75e8e243"), Description="Observing, documenting and assessing", SortOrder=Convert.ToDecimal("7.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("12ae378d-9011-429a-af00-17508a4d24e8"), Description="Family and community relationships", SortOrder=Convert.ToDecimal("9.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("93f0d1e4-ecb6-4995-9f38-be46b932daa7"), Description="Administration and management", SortOrder=Convert.ToDecimal("11.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("9cf8fdb0-2020-4bd9-9ebf-9d9d69319e6b"), Description="Early childhood education profession and policy", SortOrder=Convert.ToDecimal("13.00") },
            new RefELTrainerCoreKnowledgeArea { Id=Guid.Parse("d8627420-7d5a-4cc5-a77a-4b3c87bfd7e6"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
