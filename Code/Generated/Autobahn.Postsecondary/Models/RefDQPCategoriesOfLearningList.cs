//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDQPCategoriesOfLearningList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefDQPCategoriesOfLearning Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDQPCategoriesOfLearningModel"> List
         /// </summary>
        public static List<RefDQPCategoriesOfLearningModel> RefDQPCategoriesOfLearningList = new List<RefDQPCategoriesOfLearningModel>
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("23afbe4d-7160-48a5-84e1-0d3351bcb9de"), Code="SpecializedKnowledge", Description="Specialized Knowledge", Definition="A category of learning addressing specialized knowledge and skill requirements of a student pursuing a specialized degree.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("3119358a-841e-445a-ad6f-56206dae40c0"), Code="BroadAndIntegrativeKnowledge", Description="Broad and Integrative Knowledge", Definition="Liberal and general education category of learning with emphasis on students' broad learning across the humanities, arts, sciences and social sciences.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("1bfc1490-5806-4b33-916d-6c604446646e"), Code="IntellectualSkills", Description="Intellectual Skills", Definition="Proficiencies that transcend the boundaries of particular fields of study including analytic inquiry, use of information resources, engaging diverse perspectives, ethical reasoning, quantitative fluency, and communicative fluency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d8c46eb0-7255-4445-8b5c-1081fe052c0c"), Code="AppliedAndCollaborativeLearning", Description="Applied and Collaborative Learning", Definition="A category of learning addressing what graduates can do with what they know.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("7fe64e83-a846-4bae-a71f-08a9396b0497"), Code="CivicAndGlobalLearning", Description="Civic and Global Learning", Definition="A category of learning addressing proficiencies needed for both civic and global inquiry and interaction.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefDQPCategoriesOfLearning Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDQPCategoriesOfLearningViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("23afbe4d-7160-48a5-84e1-0d3351bcb9de"), Description="Specialized Knowledge", SortOrder=Convert.ToDecimal("1.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("3119358a-841e-445a-ad6f-56206dae40c0"), Description="Broad and Integrative Knowledge", SortOrder=Convert.ToDecimal("2.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("1bfc1490-5806-4b33-916d-6c604446646e"), Description="Intellectual Skills", SortOrder=Convert.ToDecimal("3.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d8c46eb0-7255-4445-8b5c-1081fe052c0c"), Description="Applied and Collaborative Learning", SortOrder=Convert.ToDecimal("4.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("7fe64e83-a846-4bae-a71f-08a9396b0497"), Description="Civic and Global Learning", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
