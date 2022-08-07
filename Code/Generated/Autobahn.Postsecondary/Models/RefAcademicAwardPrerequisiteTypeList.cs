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
        /// The complete <see cref="RefAcademicAwardPrerequisiteTypeModel"> List
         /// </summary>
        public static List<RefAcademicAwardPrerequisiteTypeModel> RefAcademicAwardPrerequisiteTypeList = new List<RefAcademicAwardPrerequisiteTypeModel>
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("a77e97c5-b8d0-4216-80a8-2ee8c26e8641"), Code="Achievement", Description="Achievement", Definition="Achievement is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("a9f87c7c-9623-4de2-b6fe-d1b7e44feceb"), Code="Course", Description="Course", Definition="Course is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("cf7362de-a1d1-4212-9e45-333fba7e4571"), Code="Experience", Description="Experience", Definition="Experience is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("39c354d7-b469-47cf-b1dd-ba2149831351"), Code="Score", Description="Score", Definition="Score is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("3ba3807f-2faa-4906-a34d-c3ed685d3793"), Code="Status", Description="Status", Definition="Status is a prerequisite condition for earning an academic award.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefAcademicAwardPrerequisiteType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicAwardPrerequisiteTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("a77e97c5-b8d0-4216-80a8-2ee8c26e8641"), Description="Achievement", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("a9f87c7c-9623-4de2-b6fe-d1b7e44feceb"), Description="Course", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("cf7362de-a1d1-4212-9e45-333fba7e4571"), Description="Experience", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("39c354d7-b469-47cf-b1dd-ba2149831351"), Description="Score", SortOrder=Convert.ToDecimal("") },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("3ba3807f-2faa-4906-a34d-c3ed685d3793"), Description="Status", SortOrder=Convert.ToDecimal("") },
       };
   }
}
