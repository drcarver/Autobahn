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
        /// The complete <see cref="RefLearningResourceCompetencyAlignmentTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceCompetencyAlignmentTypeModel> RefLearningResourceCompetencyAlignmentTypeList = new List<RefLearningResourceCompetencyAlignmentTypeModel>
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("d04ca893-d4da-48cf-90ac-0c292264ce80"), Code="Assesses", Description="Assesses", Definition="The learning resource Assesses the aligned competency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("e41d400a-c78a-4fe6-8550-8d75a24d9582"), Code="Teaches", Description="Teaches", Definition="The learning resource Teaches the aligned competency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("395537bd-9726-4811-abc4-e17e0eb14502"), Code="Requires", Description="Requires", Definition="The learning resource Requires the aligned competency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("3944d9eb-8ac5-480d-ad49-5abebe4e991d"), Code="TextComplexity", Description="Text Complexity", Definition="The aligned item specifies the Text Complexity of the learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("c5bc355d-2ce1-4363-a486-6ab7a8729c60"), Code="ReadingLevel", Description="Reading Level", Definition="The aligned item specifies the Reading Level of the learning resource.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("3f23765e-5988-4f75-91fa-b8d6ef583674"), Code="EducationalSubject", Description="Educational Subject", Definition="The aligned item specifies the Educational Subject of the learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("2e5c18da-7b73-45ba-9297-616320a204a9"), Code="EducationLevel", Description="Education Level", Definition="The aligned item specifies the Education Level of the learning resource.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceCompetencyAlignmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceCompetencyAlignmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("d04ca893-d4da-48cf-90ac-0c292264ce80"), Description="Assesses", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("e41d400a-c78a-4fe6-8550-8d75a24d9582"), Description="Teaches", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("395537bd-9726-4811-abc4-e17e0eb14502"), Description="Requires", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("3944d9eb-8ac5-480d-ad49-5abebe4e991d"), Description="Text Complexity", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("c5bc355d-2ce1-4363-a486-6ab7a8729c60"), Description="Reading Level", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("3f23765e-5988-4f75-91fa-b8d6ef583674"), Description="Educational Subject", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceCompetencyAlignmentType { Id=Guid.Parse("2e5c18da-7b73-45ba-9297-616320a204a9"), Description="Education Level", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
