//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTenureSystemList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTenureSystem Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTenureSystem"> List
         /// </summary>
        public static List<RefTenureSystem> RefTenureSystemList = new List<RefTenureSystem>
        {
            new RefTenureSystem { Id=Guid.Parse("59bb4f3a-1815-4306-a8d4-7938518a34d3"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefTenureSystem { Id=Guid.Parse("6e1dfe76-c239-4b86-a1af-02e974a8a888"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefTenureSystem Pick List
         /// </summary>
        public static List<RefTenureSystem> RefTenureSystemPickList = new List<RefTenureSystem>
        {
            new RefTenureSystem { Id=Guid.Parse("59bb4f3a-1815-4306-a8d4-7938518a34d3"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefTenureSystem { Id=Guid.Parse("6e1dfe76-c239-4b86-a1af-02e974a8a888"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
