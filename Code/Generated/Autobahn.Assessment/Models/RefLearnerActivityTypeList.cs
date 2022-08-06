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
        public static List<RefLearnerActivityType> RefLearnerActivityTypeList = new List<RefLearnerActivityType>
        {
            new RefLearnerActivityType { Id=Guid.Parse("35e29816-de7e-4729-931b-3904748ffefb"), Code="Assignment", Description="Assignment", Definition="The type of work assigned to the learner is an assignment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityType { Id=Guid.Parse("df026321-e07c-48ba-8c85-64dc7989db5d"), Code="LearningResource", Description="Learning Resource", Definition="The type of assignment to the learner is a learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityType { Id=Guid.Parse("6f338e7c-c1e7-48fa-b763-d4704393ff1d"), Code="Activity", Description="Activity", Definition="The type of work assigned to the learner is an activity.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActivityType { Id=Guid.Parse("2cdef63d-aa15-4f5e-bc9f-4f7e4998af2c"), Code="Lesson", Description="Lesson", Definition="The type of work assigned to the learner is a lesson.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefLearnerActivityType Pick List
         /// </summary>
        public static List<RefLearnerActivityType> RefLearnerActivityTypePickList = new List<RefLearnerActivityType>
        {
            new RefLearnerActivityType { Id=Guid.Parse("35e29816-de7e-4729-931b-3904748ffefb"), Code="Assignment", Description="Assignment", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityType { Id=Guid.Parse("df026321-e07c-48ba-8c85-64dc7989db5d"), Code="LearningResource", Description="Learning Resource", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityType { Id=Guid.Parse("6f338e7c-c1e7-48fa-b763-d4704393ff1d"), Code="Activity", Description="Activity", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActivityType { Id=Guid.Parse("2cdef63d-aa15-4f5e-bc9f-4f7e4998af2c"), Code="Lesson", Description="Lesson", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
