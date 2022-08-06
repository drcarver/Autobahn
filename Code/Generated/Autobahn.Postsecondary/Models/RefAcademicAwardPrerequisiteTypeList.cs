//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAcademicAwardPrerequisiteTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAcademicAwardPrerequisiteType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicAwardPrerequisiteType"> List
         /// </summary>
        public static List<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypeList = new List<RefAcademicAwardPrerequisiteType>
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("f908d669-cdfa-4626-8ec3-23a6980d00b2"), Code="Achievement", Description="Achievement", Definition="Achievement is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("de3648b8-47cb-4040-8be6-f355d7ace241"), Code="Course", Description="Course", Definition="Course is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("d7ac67e5-db0c-4af7-9289-081907d9f01d"), Code="Experience", Description="Experience", Definition="Experience is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("3df3f569-df24-4f6b-9549-57019cb941ac"), Code="Score", Description="Score", Definition="Score is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("19ac11da-9219-4ff9-9687-bb08a5590d1f"), Code="Status", Description="Status", Definition="Status is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefAcademicAwardPrerequisiteType Pick List
         /// </summary>
        public static List<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypePickList = new List<RefAcademicAwardPrerequisiteType>
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("f908d669-cdfa-4626-8ec3-23a6980d00b2"), Code="Achievement", Description="Achievement", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("de3648b8-47cb-4040-8be6-f355d7ace241"), Code="Course", Description="Course", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("d7ac67e5-db0c-4af7-9289-081907d9f01d"), Code="Experience", Description="Experience", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("3df3f569-df24-4f6b-9549-57019cb941ac"), Code="Score", Description="Score", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("19ac11da-9219-4ff9-9687-bb08a5590d1f"), Code="Status", Description="Status", SortOrder=Convert.ToDecimal("") },
       };
   }
}
