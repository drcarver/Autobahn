//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedAfterExitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedAfterExit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedAfterExit"> List
         /// </summary>
        public static List<RefEmployedAfterExit> RefEmployedAfterExitList = new List<RefEmployedAfterExit> =
        {
            new RefEmployedAfterExit { Id=Guid.Parse("b0531f96-11db-475c-ab9f-72060e38a260"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefEmployedAfterExit { Id=Guid.Parse("d4cc0be6-010f-4fa9-8488-3fa13a5314f2"), Code="", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmployedAfterExit Pick List
         /// </summary>
        public static List<RefEmployedAfterExit> RefEmployedAfterExitPickList = new List<RefEmployedAfterExit> =
        {
            new RefEmployedAfterExit { Id=Guid.Parse("b0531f96-11db-475c-ab9f-72060e38a260"), Code="", SortOrder=0 },
            new RefEmployedAfterExit { Id=Guid.Parse("d4cc0be6-010f-4fa9-8488-3fa13a5314f2"), Code="", SortOrder=0 },
       };
   }
}
