//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefFoodServiceEligibilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefFoodServiceEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFoodServiceEligibility"> List
         /// </summary>
        public static List<RefFoodServiceEligibility> RefFoodServiceEligibilityList = new List<RefFoodServiceEligibility> =
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("f076e71e-3555-44e8-b904-1672cf59c4da"), Code="Free is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", Description="Free", Definition="", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("74e3e0be-89f8-47bf-a381-02a43eee9db3"), Code="Full price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", Description="FullPrice", Definition="", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("a66eb008-3639-4eba-9284-cbf79d62bacb"), Code="Reduced price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", Description="ReducedPrice", Definition="", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("75fbff87-09e3-4ff6-965e-4ca95ece70e9"), Code="Other is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFoodServiceEligibility Pick List
         /// </summary>
        public static List<RefFoodServiceEligibility> RefFoodServiceEligibilityPickList = new List<RefFoodServiceEligibility> =
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("f076e71e-3555-44e8-b904-1672cf59c4da"), Code="Free is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("74e3e0be-89f8-47bf-a381-02a43eee9db3"), Code="Full price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("a66eb008-3639-4eba-9284-cbf79d62bacb"), Code="Reduced price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=0 },
            new RefFoodServiceEligibility { Id=Guid.Parse("75fbff87-09e3-4ff6-965e-4ca95ece70e9"), Code="Other is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=0 },
       };
   }
}
