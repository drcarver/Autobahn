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
        public static List<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypeList = new List<RefAcademicAwardPrerequisiteType> =
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("455c6b41-f783-4318-834b-4d14b2e0e912"), Code="Achievement is a prerequisite condition for earning an academic award.", Description="Achievement", Definition="", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("412f3981-aded-44ab-b421-d9fa89bb5cc3"), Code="Course is a prerequisite condition for earning an academic award.", Description="Course", Definition="", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("99cca32f-3415-47db-9024-6bbdba76c71e"), Code="Experience is a prerequisite condition for earning an academic award.", Description="Experience", Definition="", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("58d6dd0d-84ed-4cf4-a306-993077f9868a"), Code="Score is a prerequisite condition for earning an academic award.", Description="Score", Definition="", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("c062c469-898b-4ba5-886a-6dd0d2704163"), Code="Status is a prerequisite condition for earning an academic award.", Description="Status", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAcademicAwardPrerequisiteType Pick List
         /// </summary>
        public static List<RefAcademicAwardPrerequisiteType> RefAcademicAwardPrerequisiteTypePickList = new List<RefAcademicAwardPrerequisiteType> =
        {
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("455c6b41-f783-4318-834b-4d14b2e0e912"), Code="Achievement is a prerequisite condition for earning an academic award.", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("412f3981-aded-44ab-b421-d9fa89bb5cc3"), Code="Course is a prerequisite condition for earning an academic award.", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("99cca32f-3415-47db-9024-6bbdba76c71e"), Code="Experience is a prerequisite condition for earning an academic award.", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("58d6dd0d-84ed-4cf4-a306-993077f9868a"), Code="Score is a prerequisite condition for earning an academic award.", SortOrder=0 },
            new RefAcademicAwardPrerequisiteType { Id=Guid.Parse("c062c469-898b-4ba5-886a-6dd0d2704163"), Code="Status is a prerequisite condition for earning an academic award.", SortOrder=0 },
       };
   }
}
