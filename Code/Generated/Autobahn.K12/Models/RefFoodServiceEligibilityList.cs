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
        public static List<RefFoodServiceEligibility> RefFoodServiceEligibilityList = new List<RefFoodServiceEligibility>
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("f145e703-1729-4c5d-8fac-65a68e916993"), Code="Free", Description="Free", Definition="Free is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("587f6823-1c36-4efb-9bcf-311d306fece8"), Code="FullPrice", Description="Full price", Definition="Full price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("afa7664a-eed8-4e23-bbe2-284836b3daee"), Code="ReducedPrice", Description="Reduced price", Definition="Reduced price is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("5bc10ebd-e8c0-4f80-812a-b10977b459aa"), Code="Other", Description="Other", Definition="Other is the student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefFoodServiceEligibility Pick List
         /// </summary>
        public static List<RefFoodServiceEligibility> RefFoodServiceEligibilityPickList = new List<RefFoodServiceEligibility>
        {
            new RefFoodServiceEligibility { Id=Guid.Parse("f145e703-1729-4c5d-8fac-65a68e916993"), Code="Free", Description="Free", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("587f6823-1c36-4efb-9bcf-311d306fece8"), Code="FullPrice", Description="Full price", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("afa7664a-eed8-4e23-bbe2-284836b3daee"), Code="ReducedPrice", Description="Reduced price", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceEligibility { Id=Guid.Parse("5bc10ebd-e8c0-4f80-812a-b10977b459aa"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
