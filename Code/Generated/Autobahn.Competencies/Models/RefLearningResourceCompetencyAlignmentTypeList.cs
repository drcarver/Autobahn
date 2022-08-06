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
        public static List<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypeList = new List<RefLearningResourceCompetencyAlignmentType> =
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("10acf8d6-007f-4ecd-afa9-1b62d33954a1"), Code="The learning resource Assesses the aligned competency.", Description="Assesses", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("b4d93f7a-5f5c-4bf6-abdf-7e6f7612a2e8"), Code="The learning resource Teaches the aligned competency.", Description="Teaches", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("66dc19b5-8f35-4c4f-999b-75c5a1e6e883"), Code="The learning resource Requires the aligned competency.", Description="Requires", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("5bb017dd-ecea-4381-bf86-58d823581742"), Code="The aligned item specifies the Text Complexity of the learning resource.", Description="TextComplexity", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("2f446f9d-a1bd-47c1-b26b-a188400f4cb4"), Code="The aligned item specifies the Reading Level of the learning resource.", Description="ReadingLevel", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("1353f04c-44b4-4ec5-b4e3-a3f4efabf5e5"), Code="The aligned item specifies the Educational Subject of the learning resource.", Description="EducationalSubject", Definition="", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("e0413c6d-5e3b-4bed-9d5e-5a6d869cedc0"), Code="The aligned item specifies the Education Level of the learning resource.", Description="EducationLevel", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceCompetencyAlignmentType Pick List
         /// </summary>
        public static List<RefLearningResourceCompetencyAlignmentType> RefLearningResourceCompetencyAlignmentTypePickList = new List<RefLearningResourceCompetencyAlignmentType> =
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("10acf8d6-007f-4ecd-afa9-1b62d33954a1"), Code="The learning resource Assesses the aligned competency.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("b4d93f7a-5f5c-4bf6-abdf-7e6f7612a2e8"), Code="The learning resource Teaches the aligned competency.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("66dc19b5-8f35-4c4f-999b-75c5a1e6e883"), Code="The learning resource Requires the aligned competency.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("5bb017dd-ecea-4381-bf86-58d823581742"), Code="The aligned item specifies the Text Complexity of the learning resource.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("2f446f9d-a1bd-47c1-b26b-a188400f4cb4"), Code="The aligned item specifies the Reading Level of the learning resource.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("1353f04c-44b4-4ec5-b4e3-a3f4efabf5e5"), Code="The aligned item specifies the Educational Subject of the learning resource.", SortOrder=0 },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("e0413c6d-5e3b-4bed-9d5e-5a6d869cedc0"), Code="The aligned item specifies the Education Level of the learning resource.", SortOrder=0 },
       };
   }
}
