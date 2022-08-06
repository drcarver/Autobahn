//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationLevelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEducationLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEducationLevelType"> List
         /// </summary>
        public static List<RefEducationLevelType> RefEducationLevelTypeList = new List<RefEducationLevelType> =
        {
            new RefEducationLevelType { Id=Guid.Parse("02caef32-abeb-4ce3-be46-261c885bfc14"), Code="", Description="000141", Definition="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("03175eea-cd05-46cb-ab25-6392bddacec7"), Code="", Description="000725", Definition="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("e481e072-c951-4510-b726-03704bfb1edb"), Code="", Description="001229", Definition="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("e87e0afa-ab2c-404c-9358-de96cfe77b5a"), Code="", Description="001230", Definition="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("440fc888-7ba6-4b41-abf0-cb2276011965"), Code="", Description="001246", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEducationLevelType Pick List
         /// </summary>
        public static List<RefEducationLevelType> RefEducationLevelTypePickList = new List<RefEducationLevelType> =
        {
            new RefEducationLevelType { Id=Guid.Parse("02caef32-abeb-4ce3-be46-261c885bfc14"), Code="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("03175eea-cd05-46cb-ab25-6392bddacec7"), Code="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("e481e072-c951-4510-b726-03704bfb1edb"), Code="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("e87e0afa-ab2c-404c-9358-de96cfe77b5a"), Code="", SortOrder=0 },
            new RefEducationLevelType { Id=Guid.Parse("440fc888-7ba6-4b41-abf0-cb2276011965"), Code="", SortOrder=0 },
       };
   }
}
