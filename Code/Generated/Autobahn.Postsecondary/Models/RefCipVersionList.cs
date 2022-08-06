//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCipVersionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCipVersion Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCipVersion"> List
         /// </summary>
        public static List<RefCipVersion> RefCipVersionList = new List<RefCipVersion>
        {
            new RefCipVersion { Id=Guid.Parse("57d51647-c457-4464-a11c-ad8748cf45a7"), Code="CIP1980", Description="CIP 1980", Definition="CIP 1980 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipVersion { Id=Guid.Parse("76b65c1c-7af6-4fb2-b211-6d6fcdc61949"), Code="CIP1985", Description="CIP 1985", Definition="CIP 1985 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipVersion { Id=Guid.Parse("4f6e685a-0f84-415f-9e1b-7a7bb2a0e431"), Code="CIP1990", Description="CIP 1990", Definition="CIP 1990 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipVersion { Id=Guid.Parse("7fc2da54-cb12-40be-b764-abeab0f66b2e"), Code="CIP2000", Description="CIP 2000", Definition="CIP 2000 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCipVersion { Id=Guid.Parse("a4dd0f07-cea2-4f48-8a56-d10aa7f11c1e"), Code="CIP2010", Description="CIP 2010", Definition="CIP 2010 is the version of CIP being reported.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefCipVersion Pick List
         /// </summary>
        public static List<RefCipVersion> RefCipVersionPickList = new List<RefCipVersion>
        {
            new RefCipVersion { Id=Guid.Parse("57d51647-c457-4464-a11c-ad8748cf45a7"), Code="CIP1980", Description="CIP 1980", SortOrder=Convert.ToDecimal("1.00") },
            new RefCipVersion { Id=Guid.Parse("76b65c1c-7af6-4fb2-b211-6d6fcdc61949"), Code="CIP1985", Description="CIP 1985", SortOrder=Convert.ToDecimal("2.00") },
            new RefCipVersion { Id=Guid.Parse("4f6e685a-0f84-415f-9e1b-7a7bb2a0e431"), Code="CIP1990", Description="CIP 1990", SortOrder=Convert.ToDecimal("3.00") },
            new RefCipVersion { Id=Guid.Parse("7fc2da54-cb12-40be-b764-abeab0f66b2e"), Code="CIP2000", Description="CIP 2000", SortOrder=Convert.ToDecimal("4.00") },
            new RefCipVersion { Id=Guid.Parse("a4dd0f07-cea2-4f48-8a56-d10aa7f11c1e"), Code="CIP2010", Description="CIP 2010", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
