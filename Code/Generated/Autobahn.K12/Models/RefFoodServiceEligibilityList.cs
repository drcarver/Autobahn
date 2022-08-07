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
        /// The complete <see cref="RefFoodServiceEligibilityModel"> List
         /// </summary>
        public static List<RefFoodServiceEligibilityModel> RefFoodServiceEligibilityList = new List<RefFoodServiceEligibilityModel>
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("bccf9a03-2e04-465a-8373-9a8bb903a05f"), Code="Free", Description="Free", Definition="Free is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("dc592651-0d21-4d5d-b443-789002d4f439"), Code="FullPrice", Description="Full price", Definition="Full price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("cf29c769-3fa4-476f-a51a-eac02af27395"), Code="ReducedPrice", Description="Reduced price", Definition="Reduced price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("6327e83f-ceb2-424f-9d0b-a4618836a6f5"), Code="Other", Description="Other", Definition="Other is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefFoodServiceEligibility Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFoodServiceEligibilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("bccf9a03-2e04-465a-8373-9a8bb903a05f"), Description="Free", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("dc592651-0d21-4d5d-b443-789002d4f439"), Description="Full price", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("cf29c769-3fa4-476f-a51a-eac02af27395"), Description="Reduced price", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("6327e83f-ceb2-424f-9d0b-a4618836a6f5"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
