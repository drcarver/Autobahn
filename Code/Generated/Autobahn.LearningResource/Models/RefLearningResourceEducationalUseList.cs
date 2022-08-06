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
        public static List<RefLearningResourceEducationalUse> RefLearningResourceEducationalUseList = new List<RefLearningResourceEducationalUse>
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("c084369a-ddef-4644-9b50-9b1d998a6ea5"), Code="CurriculumInstruction", Description="Curriculum/Instruction", Definition="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("a47f793d-c5cb-44f8-a577-fdd28c12518c"), Code="Assessment", Description="Assessment", Definition="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("dc708192-cff4-44c4-a8f9-1d574a235643"), Code="ProfessionalDevelopment", Description="Professional Development", Definition="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("e825a8da-9fe9-40ac-a0ee-5045ae9736f2"), Code="Other", Description="Other", Definition="Primary purpose of the resource is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefLearningResourceEducationalUse Pick List
         /// </summary>
        public static List<RefLearningResourceEducationalUse> RefLearningResourceEducationalUsePickList = new List<RefLearningResourceEducationalUse>
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("c084369a-ddef-4644-9b50-9b1d998a6ea5"), Code="CurriculumInstruction", Description="Curriculum/Instruction", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("a47f793d-c5cb-44f8-a577-fdd28c12518c"), Code="Assessment", Description="Assessment", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("dc708192-cff4-44c4-a8f9-1d574a235643"), Code="ProfessionalDevelopment", Description="Professional Development", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("e825a8da-9fe9-40ac-a0ee-5045ae9736f2"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
