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
        /// The complete <see cref="RefLearnerActivityTypeModel"> List
         /// </summary>
        public static List<RefLearnerActivityTypeModel> RefLearnerActivityTypeList = new List<RefLearnerActivityTypeModel>
        {
            new RefLearnerActivityType { Id=Guid.Parse("1e005784-68d4-4d2c-b948-7b97578abcff"), Code="Assignment", Description="Assignment", Definition="The type of work assigned to the learner is an assignment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityType { Id=Guid.Parse("cf48c179-dee7-420e-a4c6-10185461c0d8"), Code="LearningResource", Description="Learning Resource", Definition="The type of assignment to the learner is a learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityType { Id=Guid.Parse("9de6c7c4-9a6f-4e49-b57c-4089ccc95568"), Code="Activity", Description="Activity", Definition="The type of work assigned to the learner is an activity.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActivityType { Id=Guid.Parse("215f3582-c659-43d0-9461-4cf2f5eff9ff"), Code="Lesson", Description="Lesson", Definition="The type of work assigned to the learner is a lesson.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefLearnerActivityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearnerActivityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearnerActivityType { Id=Guid.Parse("1e005784-68d4-4d2c-b948-7b97578abcff"), Description="Assignment", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActivityType { Id=Guid.Parse("cf48c179-dee7-420e-a4c6-10185461c0d8"), Description="Learning Resource", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActivityType { Id=Guid.Parse("9de6c7c4-9a6f-4e49-b57c-4089ccc95568"), Description="Activity", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActivityType { Id=Guid.Parse("215f3582-c659-43d0-9461-4cf2f5eff9ff"), Description="Lesson", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
