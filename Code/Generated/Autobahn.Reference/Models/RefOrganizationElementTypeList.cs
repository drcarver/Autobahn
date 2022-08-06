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
        public static List<RefOrganizationElementType> RefOrganizationElementTypeList = new List<RefOrganizationElementType>
        {
            new RefOrganizationElementType { Id=Guid.Parse("7ca5c9b6-94d6-43e4-8fd6-2671a8661534"), Code="001078", Description="Adult Education Provider Type", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOrganizationElementType { Id=Guid.Parse("7b95569b-ab94-4116-a5e4-6f7c499ae2e5"), Code="001156", Description="Organization Type", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefOrganizationElementType Pick List
         /// </summary>
        public static List<RefOrganizationElementType> RefOrganizationElementTypePickList = new List<RefOrganizationElementType>
        {
            new RefOrganizationElementType { Id=Guid.Parse("7ca5c9b6-94d6-43e4-8fd6-2671a8661534"), Code="001078", Description="Adult Education Provider Type", SortOrder=Convert.ToDecimal("") },
            new RefOrganizationElementType { Id=Guid.Parse("7b95569b-ab94-4116-a5e4-6f7c499ae2e5"), Code="001156", Description="Organization Type", SortOrder=Convert.ToDecimal("") },
       };
   }
}
