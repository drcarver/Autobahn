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
        /// The complete <see cref="RefPrekindergartenEligibilityModel"> List
         /// </summary>
        public static List<RefPrekindergartenEligibilityModel> RefPrekindergartenEligibilityList = new List<RefPrekindergartenEligibilityModel>
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("243d7da4-3f7c-4f00-91a1-0f50321a7dfb"), Code="All", Description="All students", Definition="All students", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("8a3c3cde-052b-4846-9e6f-326d815afcf7"), Code="IDEA", Description="Students with disabilities (IDEA)", Definition="Students with disabilities (IDEA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("64575190-a3de-4d17-9fbf-ccfb728117ea"), Code="TitleI", Description="Students in Title I schools", Definition="Students in Title I schools", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("de0d37db-4e35-454e-89d6-ddff2ca6f8a0"), Code="LowIncome", Description="Students from low income families", Definition="Students from low income families", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("668bae5e-03c5-4c9b-b319-b076fa0f75c5"), Code="Other", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefPrekindergartenEligibility Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPrekindergartenEligibilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("243d7da4-3f7c-4f00-91a1-0f50321a7dfb"), Description="All students", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("8a3c3cde-052b-4846-9e6f-326d815afcf7"), Description="Students with disabilities (IDEA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("64575190-a3de-4d17-9fbf-ccfb728117ea"), Description="Students in Title I schools", SortOrder=Convert.ToDecimal("3.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("de0d37db-4e35-454e-89d6-ddff2ca6f8a0"), Description="Students from low income families", SortOrder=Convert.ToDecimal("4.00") },
            new RefPrekindergartenEligibility { Id=Guid.Parse("668bae5e-03c5-4c9b-b319-b076fa0f75c5"), Description="Other", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
