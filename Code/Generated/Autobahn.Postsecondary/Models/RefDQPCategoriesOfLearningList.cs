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
        public static List<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearningList = new List<RefDQPCategoriesOfLearning> =
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d3de762b-1fa9-451d-83de-a309f3e8991a"), Code="A category of learning addressing specialized knowledge and skill requirements of a student pursuing a specialized degree.", Description="SpecializedKnowledge", Definition="", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("4a56273e-eadb-40bf-9831-b1b4850e8201"), Code="Liberal and general education category of learning with emphasis on students' broad learning across the humanities, arts, sciences and social sciences.", Description="BroadAndIntegrativeKnowledge", Definition="", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d186a504-1d53-406d-ad11-f28f9b509ea7"), Code="Proficiencies that transcend the boundaries of particular fields of study including analytic inquiry, use of information resources, engaging diverse perspectives, ethical reasoning, quantitative fluency, and communicative fluency.", Description="IntellectualSkills", Definition="", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("f359dcaa-8d77-410e-83f9-a158d64c8bb9"), Code="A category of learning addressing what graduates can do with what they know.", Description="AppliedAndCollaborativeLearning", Definition="", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("682b4988-0dc3-4e5e-a4a5-df4c9d444b83"), Code="A category of learning addressing proficiencies needed for both civic and global inquiry and interaction.", Description="CivicAndGlobalLearning", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDQPCategoriesOfLearning Pick List
         /// </summary>
        public static List<RefDQPCategoriesOfLearning> RefDQPCategoriesOfLearningPickList = new List<RefDQPCategoriesOfLearning> =
        {
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d3de762b-1fa9-451d-83de-a309f3e8991a"), Code="A category of learning addressing specialized knowledge and skill requirements of a student pursuing a specialized degree.", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("4a56273e-eadb-40bf-9831-b1b4850e8201"), Code="Liberal and general education category of learning with emphasis on students' broad learning across the humanities, arts, sciences and social sciences.", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("d186a504-1d53-406d-ad11-f28f9b509ea7"), Code="Proficiencies that transcend the boundaries of particular fields of study including analytic inquiry, use of information resources, engaging diverse perspectives, ethical reasoning, quantitative fluency, and communicative fluency.", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("f359dcaa-8d77-410e-83f9-a158d64c8bb9"), Code="A category of learning addressing what graduates can do with what they know.", SortOrder=0 },
            new RefDQPCategoriesOfLearning { Id=Guid.Parse("682b4988-0dc3-4e5e-a4a5-df4c9d444b83"), Code="A category of learning addressing proficiencies needed for both civic and global inquiry and interaction.", SortOrder=0 },
       };
   }
}
