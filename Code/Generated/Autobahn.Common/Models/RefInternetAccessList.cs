//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetAccess Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetAccess"> List
         /// </summary>
        public static List<RefInternetAccess> RefInternetAccessList = new List<RefInternetAccess> =
        {
            new RefInternetAccess { Id=Guid.Parse("31b43d17-44f5-4d93-b45a-85a94358af1e"), Code="High speed internet connectivity is available.", Description="HighSpeed", Definition="", SortOrder=0 },
            new RefInternetAccess { Id=Guid.Parse("2fba5ed6-5650-4599-acab-fc35c0b16f11"), Code="Less than high speed internet connectivity is available.", Description="LessThanHighSpeed", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInternetAccess Pick List
         /// </summary>
        public static List<RefInternetAccess> RefInternetAccessPickList = new List<RefInternetAccess> =
        {
            new RefInternetAccess { Id=Guid.Parse("31b43d17-44f5-4d93-b45a-85a94358af1e"), Code="High speed internet connectivity is available.", SortOrder=0 },
            new RefInternetAccess { Id=Guid.Parse("2fba5ed6-5650-4599-acab-fc35c0b16f11"), Code="Less than high speed internet connectivity is available.", SortOrder=0 },
       };
   }
}
