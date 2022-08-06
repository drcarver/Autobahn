//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActivityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefLearnerActivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearnerActivityType"> List
         /// </summary>
        public static List<RefLearnerActivityType> RefLearnerActivityTypeList = new List<RefLearnerActivityType> =
        {
            new RefLearnerActivityType { Id=Guid.Parse("4a6eed66-d554-4129-9767-e5d41ffd8d01"), Code="The type of work assigned to the learner is an assignment.", Description="Assignment", Definition="", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("63a4d8ab-17bf-498d-8b18-0afbd3abc753"), Code="The type of assignment to the learner is a learning resource.", Description="LearningResource", Definition="", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("a6403a89-752e-4981-927d-8117bf1468ef"), Code="The type of work assigned to the learner is an activity.", Description="Activity", Definition="", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("793e70aa-3227-490b-80a0-73e2a3c60e64"), Code="The type of work assigned to the learner is a lesson.", Description="Lesson", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearnerActivityType Pick List
         /// </summary>
        public static List<RefLearnerActivityType> RefLearnerActivityTypePickList = new List<RefLearnerActivityType> =
        {
            new RefLearnerActivityType { Id=Guid.Parse("4a6eed66-d554-4129-9767-e5d41ffd8d01"), Code="The type of work assigned to the learner is an assignment.", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("63a4d8ab-17bf-498d-8b18-0afbd3abc753"), Code="The type of assignment to the learner is a learning resource.", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("a6403a89-752e-4981-927d-8117bf1468ef"), Code="The type of work assigned to the learner is an activity.", SortOrder=0 },
            new RefLearnerActivityType { Id=Guid.Parse("793e70aa-3227-490b-80a0-73e2a3c60e64"), Code="The type of work assigned to the learner is a lesson.", SortOrder=0 },
       };
   }
}
