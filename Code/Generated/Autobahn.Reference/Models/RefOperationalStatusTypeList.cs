//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefOperationalStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefOperationalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOperationalStatusType"> List
         /// </summary>
        public static List<RefOperationalStatusType> RefOperationalStatusTypeList = new List<RefOperationalStatusType> =
        {
            new RefOperationalStatusType { Id=Guid.Parse("b623506b-ab79-40c7-adba-b556308b820b"), Code="", Description="000174", Definition="", SortOrder=0 },
            new RefOperationalStatusType { Id=Guid.Parse("bb147e68-3190-4f65-93d9-5a8588165389"), Code="", Description="000533", Definition="", SortOrder=0 },
            new RefOperationalStatusType { Id=Guid.Parse("ea37cfa5-8c4a-475a-8452-5e9315b52050"), Code="", Description="001418", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefOperationalStatusType Pick List
         /// </summary>
        public static List<RefOperationalStatusType> RefOperationalStatusTypePickList = new List<RefOperationalStatusType> =
        {
            new RefOperationalStatusType { Id=Guid.Parse("b623506b-ab79-40c7-adba-b556308b820b"), Code="", SortOrder=0 },
            new RefOperationalStatusType { Id=Guid.Parse("bb147e68-3190-4f65-93d9-5a8588165389"), Code="", SortOrder=0 },
            new RefOperationalStatusType { Id=Guid.Parse("ea37cfa5-8c4a-475a-8452-5e9315b52050"), Code="", SortOrder=0 },
       };
   }
}
