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
        public static List<RefEmployedAfterExit> RefEmployedAfterExitList = new List<RefEmployedAfterExit>
        {
            new RefEmployedAfterExit { Id=Guid.Parse("ba0da1db-89d3-4e98-bbe9-b4adff274819"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedAfterExit { Id=Guid.Parse("297005bf-aed6-491d-8d7f-f3244541fb68"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefEmployedAfterExit Pick List
         /// </summary>
        public static List<RefEmployedAfterExit> RefEmployedAfterExitPickList = new List<RefEmployedAfterExit>
        {
            new RefEmployedAfterExit { Id=Guid.Parse("ba0da1db-89d3-4e98-bbe9-b4adff274819"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedAfterExit { Id=Guid.Parse("297005bf-aed6-491d-8d7f-f3244541fb68"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
