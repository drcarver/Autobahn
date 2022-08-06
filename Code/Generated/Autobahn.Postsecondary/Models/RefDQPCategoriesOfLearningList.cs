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
        /// The complete <see cref="RefDQPCategoriesOfLearning"> List
         /// </summary>
        public static List<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearningList = new List<RefDQPCategoriesOfLearning>
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("4e0bd5c7-ccf8-413d-8bbc-0f60fe89bb0a"), Code="SpecializedKnowledge", Description="Specialized Knowledge", Definition="A category of learning addressing specialized knowledge and skill requirements of a student pursuing a specialized degree.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d17127d6-b35b-477f-a1c3-270030bda21f"), Code="BroadAndIntegrativeKnowledge", Description="Broad and Integrative Knowledge", Definition="Liberal and general education category of learning with emphasis on students' broad learning across the humanities, arts, sciences and social sciences.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("5fc3d485-4fda-4e1b-beb5-1d11b9daf2bd"), Code="IntellectualSkills", Description="Intellectual Skills", Definition="Proficiencies that transcend the boundaries of particular fields of study including analytic inquiry, use of information resources, engaging diverse perspectives, ethical reasoning, quantitative fluency, and communicative fluency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("05c4ead2-56b9-4d5d-8918-bdf4a5919ddf"), Code="AppliedAndCollaborativeLearning", Description="Applied and Collaborative Learning", Definition="A category of learning addressing what graduates can do with what they know.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("6ec941e2-448a-4b88-848e-9d6879a3da64"), Code="CivicAndGlobalLearning", Description="Civic and Global Learning", Definition="A category of learning addressing proficiencies needed for both civic and global inquiry and interaction.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefDQPCategoriesOfLearning Pick List
         /// </summary>
        public static List<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearningPickList = new List<RefDQPCategoriesOfLearning>
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("4e0bd5c7-ccf8-413d-8bbc-0f60fe89bb0a"), Code="SpecializedKnowledge", Description="Specialized Knowledge", SortOrder=Convert.ToDecimal("1.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d17127d6-b35b-477f-a1c3-270030bda21f"), Code="BroadAndIntegrativeKnowledge", Description="Broad and Integrative Knowledge", SortOrder=Convert.ToDecimal("2.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("5fc3d485-4fda-4e1b-beb5-1d11b9daf2bd"), Code="IntellectualSkills", Description="Intellectual Skills", SortOrder=Convert.ToDecimal("3.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("05c4ead2-56b9-4d5d-8918-bdf4a5919ddf"), Code="AppliedAndCollaborativeLearning", Description="Applied and Collaborative Learning", SortOrder=Convert.ToDecimal("4.00") },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("6ec941e2-448a-4b88-848e-9d6879a3da64"), Code="CivicAndGlobalLearning", Description="Civic and Global Learning", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
