//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefOrganizationElementTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefOrganizationElementType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationElementType"> List
         /// </summary>
        public static List<RefOrganizationElementType> RefOrganizationElementTypeList = new List<RefOrganizationElementType> =
        {
            new RefOrganizationElementType { Id=Guid.Parse("25f0db6b-fdc7-41cc-9008-8ef56b8f5a2f"), Code="", Description="001078", Definition="", SortOrder=0 },
            new RefOrganizationElementType { Id=Guid.Parse("829030ce-8236-4fcc-bbf5-08399e6a818c"), Code="", Description="001156", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOrganizationElementType Pick List
         /// </summary>
        public static List<RefOrganizationElementType> RefOrganizationElementTypePickList = new List<RefOrganizationElementType> =
        {
            new RefOrganizationElementType { Id=Guid.Parse("25f0db6b-fdc7-41cc-9008-8ef56b8f5a2f"), Code="", SortOrder=0 },
            new RefOrganizationElementType { Id=Guid.Parse("829030ce-8236-4fcc-bbf5-08399e6a818c"), Code="", SortOrder=0 },
       };
   }
}
