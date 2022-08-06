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
        public static List<RefCipVersion> RefCipVersionList = new List<RefCipVersion> =
        {
            new RefCipVersion { Id=Guid.Parse("32388ab8-6953-46f7-8c83-37a80d70865c"), Code="CIP 1980 is the version of CIP being reported.", Description="CIP1980", Definition="", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("444b1dde-28c9-49fa-beac-841fdee6e2bc"), Code="CIP 1985 is the version of CIP being reported.", Description="CIP1985", Definition="", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("621955bb-d508-4304-9f0d-29067ab258f6"), Code="CIP 1990 is the version of CIP being reported.", Description="CIP1990", Definition="", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("978b35ae-a0f5-4646-8cab-6b5898e64190"), Code="CIP 2000 is the version of CIP being reported.", Description="CIP2000", Definition="", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("ef31652b-0696-4cdf-a4c7-220f25a743f8"), Code="CIP 2010 is the version of CIP being reported.", Description="CIP2010", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCipVersion Pick List
         /// </summary>
        public static List<RefCipVersion> RefCipVersionPickList = new List<RefCipVersion> =
        {
            new RefCipVersion { Id=Guid.Parse("32388ab8-6953-46f7-8c83-37a80d70865c"), Code="CIP 1980 is the version of CIP being reported.", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("444b1dde-28c9-49fa-beac-841fdee6e2bc"), Code="CIP 1985 is the version of CIP being reported.", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("621955bb-d508-4304-9f0d-29067ab258f6"), Code="CIP 1990 is the version of CIP being reported.", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("978b35ae-a0f5-4646-8cab-6b5898e64190"), Code="CIP 2000 is the version of CIP being reported.", SortOrder=0 },
            new RefCipVersion { Id=Guid.Parse("ef31652b-0696-4cdf-a4c7-220f25a743f8"), Code="CIP 2010 is the version of CIP being reported.", SortOrder=0 },
       };
   }
}
