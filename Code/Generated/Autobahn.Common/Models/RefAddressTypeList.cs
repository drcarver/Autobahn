//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAddressTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAddressType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAddressType"> List
         /// </summary>
        public static List<RefAddressType> RefAddressTypeList = new List<RefAddressType> =
        {
            new RefAddressType { Id=Guid.Parse("58994a1b-c255-4b67-acc6-5dacb4b66bbe"), Code="", Description="000010", Definition="", SortOrder=0 },
            new RefAddressType { Id=Guid.Parse("dd2ad515-b8e2-4d51-8dd2-1dee96eb5f95"), Code="", Description="000722", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAddressType Pick List
         /// </summary>
        public static List<RefAddressType> RefAddressTypePickList = new List<RefAddressType> =
        {
            new RefAddressType { Id=Guid.Parse("58994a1b-c255-4b67-acc6-5dacb4b66bbe"), Code="", SortOrder=0 },
            new RefAddressType { Id=Guid.Parse("dd2ad515-b8e2-4d51-8dd2-1dee96eb5f95"), Code="", SortOrder=0 },
       };
   }
}
