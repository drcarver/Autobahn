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
        public static List<RefCoreKnowledgeArea> RefCoreKnowledgeAreaList = new List<RefCoreKnowledgeArea> =
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("28ca5497-2ff3-45a3-b04a-ebcdff81f7d4"), Code="Child growth and development is the core knowledge area addressed by Early Learning professional development.", Description="01", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("f251d559-18ab-4c7d-83e0-c27b7644dc14"), Code="Health safety and nutrition is the core knowledge area addressed by Early Learning professional development.", Description="02", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("d75e2178-4df5-4b70-8e12-2a0197e5fba5"), Code="Teaching and learning is the core knowledge area addressed by Early Learning professional development.", Description="03", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("4e676400-e1b3-4dc0-8a95-b1b0657de437"), Code="Observing, documenting and assessing is the core knowledge area addressed by Early Learning professional development.", Description="04", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("4a717b7b-e960-44e3-bbb6-0d88f5cf2726"), Code="Family and community relationships is the core knowledge area addressed by Early Learning professional development.", Description="05", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("dac19073-0686-49a9-9b54-afce3c0e543e"), Code="Administration and management is the core knowledge area addressed by Early Learning professional development.", Description="06", Definition="", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("1994f246-54dc-451f-8bb9-916c335fa4c3"), Code="Early childhood education profession and policy is the core knowledge area addressed by Early Learning professional development.", Description="07", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCoreKnowledgeArea Pick List
         /// </summary>
        public static List<RefCoreKnowledgeArea> RefCoreKnowledgeAreaPickList = new List<RefCoreKnowledgeArea> =
        {
            new RefCoreKnowledgeArea { Id=Guid.Parse("28ca5497-2ff3-45a3-b04a-ebcdff81f7d4"), Code="Child growth and development is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("f251d559-18ab-4c7d-83e0-c27b7644dc14"), Code="Health safety and nutrition is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("d75e2178-4df5-4b70-8e12-2a0197e5fba5"), Code="Teaching and learning is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("4e676400-e1b3-4dc0-8a95-b1b0657de437"), Code="Observing, documenting and assessing is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("4a717b7b-e960-44e3-bbb6-0d88f5cf2726"), Code="Family and community relationships is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("dac19073-0686-49a9-9b54-afce3c0e543e"), Code="Administration and management is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
            new RefCoreKnowledgeArea { Id=Guid.Parse("1994f246-54dc-451f-8bb9-916c335fa4c3"), Code="Early childhood education profession and policy is the core knowledge area addressed by Early Learning professional development.", SortOrder=0 },
       };
   }
}
