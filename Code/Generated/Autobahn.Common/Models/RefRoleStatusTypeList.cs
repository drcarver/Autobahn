//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRoleStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRoleStatusType"> List
         /// </summary>
        public static List<RefRoleStatusType> RefRoleStatusTypeList = new List<RefRoleStatusType> =
        {
            new RefRoleStatusType { Id=Guid.Parse("60287e51-225b-4e5b-87fc-c8d151c2e111"), Code="", Description="000094", Definition="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("ce59b9cf-1a0a-4686-ac06-85522fe0721a"), Code="", Description="000096", Definition="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("e2d4f4e8-100f-48f4-bc09-7b736f4b54ec"), Code="", Description="000347", Definition="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("52b37680-cccf-4f6f-951d-64c5eae8450a"), Code="", Description="000767", Definition="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("22cfdb27-2dca-4fac-9403-03d10f7e2156"), Code="", Description="000976", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRoleStatusType Pick List
         /// </summary>
        public static List<RefRoleStatusType> RefRoleStatusTypePickList = new List<RefRoleStatusType> =
        {
            new RefRoleStatusType { Id=Guid.Parse("60287e51-225b-4e5b-87fc-c8d151c2e111"), Code="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("ce59b9cf-1a0a-4686-ac06-85522fe0721a"), Code="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("e2d4f4e8-100f-48f4-bc09-7b736f4b54ec"), Code="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("52b37680-cccf-4f6f-951d-64c5eae8450a"), Code="", SortOrder=0 },
            new RefRoleStatusType { Id=Guid.Parse("22cfdb27-2dca-4fac-9403-03d10f7e2156"), Code="", SortOrder=0 },
       };
   }
}
