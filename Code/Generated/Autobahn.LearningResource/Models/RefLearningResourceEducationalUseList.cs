//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceEducationalUseList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceEducationalUse Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceEducationalUse"> List
         /// </summary>
        public static List<RefLearningResourceEducationalUse> RefLearningResourceEducationalUseList = new List<RefLearningResourceEducationalUse> =
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("30cbad29-4ae9-4a36-96f3-915537b23d30"), Code="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", Description="CurriculumInstruction", Definition="", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("234ced45-2354-42d7-8520-5470303a7bf2"), Code="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", Description="Assessment", Definition="", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("5629b8d4-9760-4d9f-a8e3-012a2510c1d4"), Code="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", Description="ProfessionalDevelopment", Definition="", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("34898059-5307-4cb7-bd05-92ec81de7aa9"), Code="Primary purpose of the resource is in a category not yet defined by CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceEducationalUse Pick List
         /// </summary>
        public static List<RefLearningResourceEducationalUse> RefLearningResourceEducationalUsePickList = new List<RefLearningResourceEducationalUse> =
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("30cbad29-4ae9-4a36-96f3-915537b23d30"), Code="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("234ced45-2354-42d7-8520-5470303a7bf2"), Code="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("5629b8d4-9760-4d9f-a8e3-012a2510c1d4"), Code="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", SortOrder=0 },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("34898059-5307-4cb7-bd05-92ec81de7aa9"), Code="Primary purpose of the resource is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
