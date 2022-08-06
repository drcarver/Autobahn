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
        public static List<RefRoleStatusType> RefRoleStatusTypeList = new List<RefRoleStatusType>
        {
            new RefRoleStatusType { Id=Guid.Parse("33d9aa95-005b-4cd2-9c9d-0552f2ea18f3"), Code="000094", Description="Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("436f24b5-f242-44f9-8cd9-e03e709516f5"), Code="000096", Description="Postsecondary Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("b65a0705-d3d6-41c0-80ae-148368f619df"), Code="000347", Description="Employment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("1fb0881d-ff21-4e79-96af-f09ab837a185"), Code="000767", Description="Teacher Preparation Program Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("6fa4e336-18d1-46f5-bcff-77b6cb728556"), Code="000976", Description="Course Section Enrollment Status Type", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefRoleStatusType Pick List
         /// </summary>
        public static List<RefRoleStatusType> RefRoleStatusTypePickList = new List<RefRoleStatusType>
        {
            new RefRoleStatusType { Id=Guid.Parse("33d9aa95-005b-4cd2-9c9d-0552f2ea18f3"), Code="000094", Description="Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("436f24b5-f242-44f9-8cd9-e03e709516f5"), Code="000096", Description="Postsecondary Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("b65a0705-d3d6-41c0-80ae-148368f619df"), Code="000347", Description="Employment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("1fb0881d-ff21-4e79-96af-f09ab837a185"), Code="000767", Description="Teacher Preparation Program Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("6fa4e336-18d1-46f5-bcff-77b6cb728556"), Code="000976", Description="Course Section Enrollment Status Type", SortOrder=Convert.ToDecimal("") },
       };
   }
}
