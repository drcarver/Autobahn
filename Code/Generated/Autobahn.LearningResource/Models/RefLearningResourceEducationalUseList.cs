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
        /// The complete <see cref="RefLearningResourceEducationalUseModel"> List
         /// </summary>
        public static List<RefLearningResourceEducationalUseModel> RefLearningResourceEducationalUseList = new List<RefLearningResourceEducationalUseModel>
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("3ed97451-6944-4516-b8e5-ff2f66b3f3e6"), Code="CurriculumInstruction", Description="Curriculum/Instruction", Definition="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("356ef677-8034-446a-9fce-0dfa7f9dd5b7"), Code="Assessment", Description="Assessment", Definition="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("1c149e10-e2b9-43e9-9b4f-0c252961a3d4"), Code="ProfessionalDevelopment", Description="Professional Development", Definition="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("565f3971-0990-4e0f-aeac-2ae9ef240848"), Code="Other", Description="Other", Definition="Primary purpose of the resource is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceEducationalUse Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceEducationalUseViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceEducationalUse { Id=Guid.Parse("3ed97451-6944-4516-b8e5-ff2f66b3f3e6"), Description="Curriculum/Instruction", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("356ef677-8034-446a-9fce-0dfa7f9dd5b7"), Description="Assessment", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("1c149e10-e2b9-43e9-9b4f-0c252961a3d4"), Description="Professional Development", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceEducationalUse { Id=Guid.Parse("565f3971-0990-4e0f-aeac-2ae9ef240848"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
