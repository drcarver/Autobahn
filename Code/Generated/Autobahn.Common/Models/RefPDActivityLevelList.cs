//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityLevel"> List
         /// </summary>
        public static List<RefPDActivityLevel> RefPDActivityLevelList = new List<RefPDActivityLevel> =
        {
            new RefPDActivityLevel { Id=Guid.Parse("a65bab98-21e2-4b39-b89e-15f38d149c35"), Code="The level of expertise for the professional development activity is beginner.", Description="Beginner", Definition="", SortOrder=0 },
            new RefPDActivityLevel { Id=Guid.Parse("3c330149-e3d6-402e-b12c-553e5a3d35c7"), Code="The level of expertise for the professional development activity is intermediate.", Description="Intermediate", Definition="", SortOrder=0 },
            new RefPDActivityLevel { Id=Guid.Parse("2ec34cdb-fd83-4079-be37-f921e4a0e493"), Code="The level of expertise for the professional development activity is advanced.", Description="Advanced", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDActivityLevel Pick List
         /// </summary>
        public static List<RefPDActivityLevel> RefPDActivityLevelPickList = new List<RefPDActivityLevel> =
        {
            new RefPDActivityLevel { Id=Guid.Parse("a65bab98-21e2-4b39-b89e-15f38d149c35"), Code="The level of expertise for the professional development activity is beginner.", SortOrder=0 },
            new RefPDActivityLevel { Id=Guid.Parse("3c330149-e3d6-402e-b12c-553e5a3d35c7"), Code="The level of expertise for the professional development activity is intermediate.", SortOrder=0 },
            new RefPDActivityLevel { Id=Guid.Parse("2ec34cdb-fd83-4079-be37-f921e4a0e493"), Code="The level of expertise for the professional development activity is advanced.", SortOrder=0 },
       };
   }
}
