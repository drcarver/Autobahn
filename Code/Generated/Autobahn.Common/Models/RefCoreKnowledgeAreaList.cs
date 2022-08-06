//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCoreKnowledgeAreaList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCoreKnowledgeArea Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCoreKnowledgeArea"> List
         /// </summary>
        public static List<RefCoreKnowledgeArea> RefCoreKnowledgeAreaList = new List<RefCoreKnowledgeArea>
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("1312d20b-b28e-40b6-877d-12f5acd41613"), Code="01", Description="Child growth and development", Definition="Child growth and development is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("0b37adda-9c8b-45ae-b34b-666c0683a3d8"), Code="02", Description="Health safety and nutrition", Definition="Health safety and nutrition is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("145b497b-43bc-4bcb-b4b9-156da77eba22"), Code="03", Description="Teaching and learning", Definition="Teaching and learning is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("3943f855-cec9-4019-b240-9b733c7a8a0b"), Code="04", Description="Observing, documenting and assessing", Definition="Observing, documenting and assessing is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("de2cf8b6-abb5-43ee-9ab1-bd91511650f2"), Code="05", Description="Family and community relationships", Definition="Family and community relationships is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("d8eeddc2-c374-443e-aef6-0b67343f41c9"), Code="06", Description="Administration and management", Definition="Administration and management is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("26e714bf-73c0-49eb-b7c3-e13e62156402"), Code="07", Description="Early childhood education profession and policy", Definition="Early childhood education profession and policy is the core knowledge area addressed by Early Learning professional development.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefCoreKnowledgeArea Pick List
         /// </summary>
        public static List<RefCoreKnowledgeArea> RefCoreKnowledgeAreaPickList = new List<RefCoreKnowledgeArea>
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("1312d20b-b28e-40b6-877d-12f5acd41613"), Code="01", Description="Child growth and development", SortOrder=Convert.ToDecimal("1.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("0b37adda-9c8b-45ae-b34b-666c0683a3d8"), Code="02", Description="Health safety and nutrition", SortOrder=Convert.ToDecimal("2.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("145b497b-43bc-4bcb-b4b9-156da77eba22"), Code="03", Description="Teaching and learning", SortOrder=Convert.ToDecimal("3.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("3943f855-cec9-4019-b240-9b733c7a8a0b"), Code="04", Description="Observing, documenting and assessing", SortOrder=Convert.ToDecimal("4.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("de2cf8b6-abb5-43ee-9ab1-bd91511650f2"), Code="05", Description="Family and community relationships", SortOrder=Convert.ToDecimal("5.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("d8eeddc2-c374-443e-aef6-0b67343f41c9"), Code="06", Description="Administration and management", SortOrder=Convert.ToDecimal("6.00") },
            new RefCoreKnowledgeArea { Id=Guid.Parse("26e714bf-73c0-49eb-b7c3-e13e62156402"), Code="07", Description="Early childhood education profession and policy", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
