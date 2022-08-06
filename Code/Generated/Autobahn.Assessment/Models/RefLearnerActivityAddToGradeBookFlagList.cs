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
        public static List<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlagList = new List<RefLearnerActivityAddToGradeBookFlag> =
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("3ed0557a-ac96-45a8-9808-d92f9dca7902"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("e62fa7eb-d4b5-423d-8e2d-30a15d961a9d"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("92a88eed-8433-48ff-952a-bdcc0f90dd16"), Code="", Description="NotSelected", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearnerActivityAddToGradeBookFlag Pick List
         /// </summary>
        public static List<RefLearnerActivityAddToGradeBookFlag> RefLearnerActivityAddToGradeBookFlagPickList = new List<RefLearnerActivityAddToGradeBookFlag> =
        {
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("3ed0557a-ac96-45a8-9808-d92f9dca7902"), Code="", SortOrder=0 },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("e62fa7eb-d4b5-423d-8e2d-30a15d961a9d"), Code="", SortOrder=0 },
            new RefLearnerActivityAddToGradeBookFlag { Id=Guid.Parse("92a88eed-8433-48ff-952a-bdcc0f90dd16"), Code="", SortOrder=0 },
       };
   }
}
