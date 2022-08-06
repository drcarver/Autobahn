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
        public static List<RefTenureSystem> RefTenureSystemList = new List<RefTenureSystem> =
        {
            new RefTenureSystem { Id=Guid.Parse("9e3214e1-8402-4ea7-a7d5-dc8b4e15bf12"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefTenureSystem { Id=Guid.Parse("1a21aaf6-524a-44d8-93c4-f5259f8ec7d5"), Code="", Description="No", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTenureSystem Pick List
         /// </summary>
        public static List<RefTenureSystem> RefTenureSystemPickList = new List<RefTenureSystem> =
        {
            new RefTenureSystem { Id=Guid.Parse("9e3214e1-8402-4ea7-a7d5-dc8b4e15bf12"), Code="", SortOrder=0 },
            new RefTenureSystem { Id=Guid.Parse("1a21aaf6-524a-44d8-93c4-f5259f8ec7d5"), Code="", SortOrder=0 },
       };
   }
}
