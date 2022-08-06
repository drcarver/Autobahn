//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   RefLearningResourceCompetencyAlignmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The list of RefLearningResourceCompetencyAlignmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceCompetencyAlignmentType"> List
         /// </summary>
        public static List<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypeList = new List<RefLearningResourceCompetencyAlignmentType>
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("97598ff5-dde0-492b-a103-47d2be9ea0b7"), Code="Assesses", Description="Assesses", Definition="The learning resource Assesses the aligned competency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("25b2b255-4235-48e2-9397-513e15f0db44"), Code="Teaches", Description="Teaches", Definition="The learning resource Teaches the aligned competency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("f0412179-d276-4ea8-bed2-44fd19b0b4de"), Code="Requires", Description="Requires", Definition="The learning resource Requires the aligned competency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("b5f104a3-f0d5-4482-85ab-e61086729761"), Code="TextComplexity", Description="Text Complexity", Definition="The aligned item specifies the Text Complexity of the learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("276beed0-0f6e-46bc-9916-88261b7cebdc"), Code="ReadingLevel", Description="Reading Level", Definition="The aligned item specifies the Reading Level of the learning resource.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("dd2b2d7a-5824-4904-9527-ddf8038abe78"), Code="EducationalSubject", Description="Educational Subject", Definition="The aligned item specifies the Educational Subject of the learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("a72071ee-062e-49ad-a7ea-15e7c583889a"), Code="EducationLevel", Description="Education Level", Definition="The aligned item specifies the Education Level of the learning resource.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefLearningResourceCompetencyAlignmentType Pick List
         /// </summary>
        public static List<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypePickList = new List<RefLearningResourceCompetencyAlignmentType>
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("97598ff5-dde0-492b-a103-47d2be9ea0b7"), Code="Assesses", Description="Assesses", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("25b2b255-4235-48e2-9397-513e15f0db44"), Code="Teaches", Description="Teaches", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("f0412179-d276-4ea8-bed2-44fd19b0b4de"), Code="Requires", Description="Requires", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("b5f104a3-f0d5-4482-85ab-e61086729761"), Code="TextComplexity", Description="Text Complexity", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("276beed0-0f6e-46bc-9916-88261b7cebdc"), Code="ReadingLevel", Description="Reading Level", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("dd2b2d7a-5824-4904-9527-ddf8038abe78"), Code="EducationalSubject", Description="Educational Subject", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("a72071ee-062e-49ad-a7ea-15e7c583889a"), Code="EducationLevel", Description="Education Level", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
