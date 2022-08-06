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
        public static List<RefInternetAccess> RefInternetAccessList = new List<RefInternetAccess>
        {
            new RefInternetAccess { Id=Guid.Parse("b15c7b1a-6644-49d0-80cc-a4dadde7ebfa"), Code="HighSpeed", Description="High speed connectivity", Definition="High speed internet connectivity is available.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccess { Id=Guid.Parse("84f2725e-3697-4333-9748-1c6cf24aaedc"), Code="LessThanHighSpeed", Description="Less than high speed connectivity", Definition="Less than high speed internet connectivity is available.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefInternetAccess Pick List
         /// </summary>
        public static List<RefInternetAccess> RefInternetAccessPickList = new List<RefInternetAccess>
        {
            new RefInternetAccess { Id=Guid.Parse("b15c7b1a-6644-49d0-80cc-a4dadde7ebfa"), Code="HighSpeed", Description="High speed connectivity", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccess { Id=Guid.Parse("84f2725e-3697-4333-9748-1c6cf24aaedc"), Code="LessThanHighSpeed", Description="Less than high speed connectivity", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
