//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPrekindergartenEligibilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPrekindergartenEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrekindergartenEligibility"> List
         /// </summary>
        public static List<RefPrekindergartenEligibility> RefPrekindergartenEligibilityList = new List<RefPrekindergartenEligibility>
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("e3757632-57c6-4769-89cf-85a361127616"), Code="All", Description="All students", Definition="All students", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("061d99e7-7b6f-4631-bc28-f9f32a13ef51"), Code="IDEA", Description="Students with disabilities (IDEA)", Definition="Students with disabilities (IDEA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("f5d0cd8d-de8e-45e7-bca2-b6b6911fbcac"), Code="TitleI", Description="Students in Title I schools", Definition="Students in Title I schools", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("14397613-a1c0-4bf7-b1a2-6f74bafba400"), Code="LowIncome", Description="Students from low income families", Definition="Students from low income families", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("7ee54204-d4e4-425d-8a9b-146857b6f861"), Code="Other", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefPrekindergartenEligibility Pick List
         /// </summary>
        public static List<RefPrekindergartenEligibility> RefPrekindergartenEligibilityPickList = new List<RefPrekindergartenEligibility>
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("e3757632-57c6-4769-89cf-85a361127616"), Code="All", Description="All students", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("061d99e7-7b6f-4631-bc28-f9f32a13ef51"), Code="IDEA", Description="Students with disabilities (IDEA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("f5d0cd8d-de8e-45e7-bca2-b6b6911fbcac"), Code="TitleI", Description="Students in Title I schools", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("14397613-a1c0-4bf7-b1a2-6f74bafba400"), Code="LowIncome", Description="Students from low income families", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("7ee54204-d4e4-425d-8a9b-146857b6f861"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
