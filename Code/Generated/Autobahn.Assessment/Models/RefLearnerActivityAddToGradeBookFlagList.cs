//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActivityAddToGradeBookFlagList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefLearnerActivityAddToGradeBookFlag Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearnerActivityAddToGradeBookFlag"> List
         /// </summary>
        public static List<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlagList = new List<RefLearnerActivityAddToGradeBookFlag>
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("55a07fd3-eaa5-43ad-84f0-67ccb746c36a"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("618eb95e-debf-4d30-a6d2-7ccbbb2e2fb1"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("498fe7b8-239d-4f0f-bdc8-c98abc1dd1bc"), Code="NotSelected", Description="Not selected", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefLearnerActivityAddToGradeBookFlag Pick List
         /// </summary>
        public static List<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlagPickList = new List<RefLearnerActivityAddToGradeBookFlag>
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("55a07fd3-eaa5-43ad-84f0-67ccb746c36a"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("618eb95e-debf-4d30-a6d2-7ccbbb2e2fb1"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("498fe7b8-239d-4f0f-bdc8-c98abc1dd1bc"), Code="NotSelected", Description="Not selected", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
