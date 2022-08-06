//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCurriculumFrameworkTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCurriculumFrameworkType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCurriculumFrameworkType"> List
         /// </summary>
        public static List<RefCurriculumFrameworkType> RefCurriculumFrameworkTypeList = new List<RefCurriculumFrameworkType> =
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("c2fd696e-2893-40e0-8b26-6a675c8a72ac"), Code="A Local Education Agency (LEA) curriculum framework is the standard curriculum used for this course.", Description="LEA", Definition="", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("7d521a04-4b93-44f0-91c9-d0c0bffc14aa"), Code="A national curriculum standard is the standard curriculum used for this course.", Description="NationalStandard", Definition="", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("51ab7e1e-8868-4567-9284-83350560efe5"), Code="A private, religious curriculum is the standard curriculum used for this course.", Description="PrivateOrReligious", Definition="", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("ddafe0bc-6a0d-49b2-b65e-dd650048de6c"), Code="A school curriculum framework is the standard curriculum used for this course.", Description="School", Definition="", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("3e8be0a6-0e00-4ede-8c9d-b30b1beefec3"), Code="A state curriculum framework is the standard curriculum used for this course.", Description="State", Definition="", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("0bfb07db-16f0-40a0-8085-352baafc4460"), Code="The standard curriculum used for this course is in a category not yet defined by CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCurriculumFrameworkType Pick List
         /// </summary>
        public static List<RefCurriculumFrameworkType> RefCurriculumFrameworkTypePickList = new List<RefCurriculumFrameworkType> =
        {
            new RefCurriculumFrameworkType { Id=Guid.Parse("c2fd696e-2893-40e0-8b26-6a675c8a72ac"), Code="A Local Education Agency (LEA) curriculum framework is the standard curriculum used for this course.", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("7d521a04-4b93-44f0-91c9-d0c0bffc14aa"), Code="A national curriculum standard is the standard curriculum used for this course.", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("51ab7e1e-8868-4567-9284-83350560efe5"), Code="A private, religious curriculum is the standard curriculum used for this course.", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("ddafe0bc-6a0d-49b2-b65e-dd650048de6c"), Code="A school curriculum framework is the standard curriculum used for this course.", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("3e8be0a6-0e00-4ede-8c9d-b30b1beefec3"), Code="A state curriculum framework is the standard curriculum used for this course.", SortOrder=0 },
            new RefCurriculumFrameworkType { Id=Guid.Parse("0bfb07db-16f0-40a0-8085-352baafc4460"), Code="The standard curriculum used for this course is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
