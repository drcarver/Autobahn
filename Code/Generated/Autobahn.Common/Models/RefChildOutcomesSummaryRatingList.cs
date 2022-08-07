//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefChildOutcomesSummaryRatingList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefChildOutcomesSummaryRating Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefChildOutcomesSummaryRatingModel"> List
         /// </summary>
        public static List<RefChildOutcomesSummaryRatingModel> RefChildOutcomesSummaryRatingList = new List<RefChildOutcomesSummaryRatingModel>
        {
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("9aff2397-cc0c-4289-8a8d-091198fe2015"), Code="01", Description="Does not show functioning expected at age - does not include immediate foundational skills", Definition="Child does not yet show functioning expected of a child his or her age in any situation. Child's functioning does not yet include immediate foundational skills upon which to build age-appropriate functioning. Child functioning reflects skills that developmentally come before immediate foundational skills.", SortOrder=Convert.ToDecimal("2.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("a796e2f5-634b-459d-a0bd-38c9e319536f"), Code="02", Description="Occasionally uses immediate foundational skills across settings and situations", Definition="Child occasionally uses immediate foundational skills across settings and situations.  More functioning reflects skills that are not immediate foundational than are immediate foundational.", SortOrder=Convert.ToDecimal("4.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("007f9c23-c72a-4371-96ce-5c4f1a214ad7"), Code="03", Description="Does not show functioning expected at age - uses immediate foundational skills", Definition="Child does not yet show functioning expected of a child of his or her age in any situation. Child uses immediate foundational skills, most or all of the time, across settings and situations. Immediate foundational skills are the skills upon which to build age-appropriate functioning.", SortOrder=Convert.ToDecimal("6.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("1d0a2626-544c-4c4d-908a-abd67ad807d7"), Code="04", Description="Shows occasional age-appropriate functioning across settings and situations", Definition="Child shows occasional age-appropriate functioning across settings and situations. More functioning is not age-appropriate than age-appropriate.", SortOrder=Convert.ToDecimal("8.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("ab6b61d6-93a8-4f28-b94b-618942f4a601"), Code="05", Description="Shows functioning expected at age some of the time and/or in some settings and situations", Definition="Child shows functioning expected for his or her age some of the time and/or in some settings and situations. Child's functioning is a mix of age-appropriate and not age-appropriate behaviors and skills.", SortOrder=Convert.ToDecimal("10.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("7017947b-da1f-48ec-b728-05812b8303c4"), Code="06", Description="Functioning generally is considered appropriate for age but there are some significant concerns", Definition="Child's functioning generally is considered appropriate for his or her age but there are some significant concerns about the child's functioning in this outcome area. These concerns are substantial enough to suggest monitoring or possible additional support.", SortOrder=Convert.ToDecimal("12.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("862cf3d4-7712-43f3-bef2-e5464a0e0340"), Code="07", Description="Shows functioning expected for age in all or almost all everyday situations", Definition="Child shows functioning expected for his or her age in all or almost all everyday situations that are part of the child's life. Functioning is considered appropriate for his or her age.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The Reference RefChildOutcomesSummaryRating Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefChildOutcomesSummaryRatingViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("9aff2397-cc0c-4289-8a8d-091198fe2015"), Description="Does not show functioning expected at age - does not include immediate foundational skills", SortOrder=Convert.ToDecimal("2.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("a796e2f5-634b-459d-a0bd-38c9e319536f"), Description="Occasionally uses immediate foundational skills across settings and situations", SortOrder=Convert.ToDecimal("4.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("007f9c23-c72a-4371-96ce-5c4f1a214ad7"), Description="Does not show functioning expected at age - uses immediate foundational skills", SortOrder=Convert.ToDecimal("6.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("1d0a2626-544c-4c4d-908a-abd67ad807d7"), Description="Shows occasional age-appropriate functioning across settings and situations", SortOrder=Convert.ToDecimal("8.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("ab6b61d6-93a8-4f28-b94b-618942f4a601"), Description="Shows functioning expected at age some of the time and/or in some settings and situations", SortOrder=Convert.ToDecimal("10.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("7017947b-da1f-48ec-b728-05812b8303c4"), Description="Functioning generally is considered appropriate for age but there are some significant concerns", SortOrder=Convert.ToDecimal("12.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("862cf3d4-7712-43f3-bef2-e5464a0e0340"), Description="Shows functioning expected for age in all or almost all everyday situations", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
