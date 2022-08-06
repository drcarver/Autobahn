//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefChildOutcomesSummaryRatingList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefChildOutcomesSummaryRating Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefChildOutcomesSummaryRating"> List
         /// </summary>
        public static List<RefChildOutcomesSummaryRating> RefChildOutcomesSummaryRatingList = new List<RefChildOutcomesSummaryRating>
        {
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("f9b52e15-fb1f-4878-9508-de4cc12173fb"), Code="01", Description="Does not show functioning expected at age - does not include immediate foundational skills", Definition="Child does not yet show functioning expected of a child his or her age in any situation. Child's functioning does not yet include immediate foundational skills upon which to build age-appropriate functioning. Child functioning reflects skills that developmentally come before immediate foundational skills.", SortOrder=Convert.ToDecimal("2.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("ced70af6-381e-456d-9862-9e7736a8e3ea"), Code="02", Description="Occasionally uses immediate foundational skills across settings and situations", Definition="Child occasionally uses immediate foundational skills across settings and situations.  More functioning reflects skills that are not immediate foundational than are immediate foundational.", SortOrder=Convert.ToDecimal("4.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("3c729027-54ef-4db1-b338-28b0b23e16be"), Code="03", Description="Does not show functioning expected at age - uses immediate foundational skills", Definition="Child does not yet show functioning expected of a child of his or her age in any situation. Child uses immediate foundational skills, most or all of the time, across settings and situations. Immediate foundational skills are the skills upon which to build age-appropriate functioning.", SortOrder=Convert.ToDecimal("6.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("54a79d1e-f27a-4e6a-9201-1fd2d4cd46fd"), Code="04", Description="Shows occasional age-appropriate functioning across settings and situations", Definition="Child shows occasional age-appropriate functioning across settings and situations. More functioning is not age-appropriate than age-appropriate.", SortOrder=Convert.ToDecimal("8.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("f6281622-933b-44af-bc3a-a75dd368b0bf"), Code="05", Description="Shows functioning expected at age some of the time and/or in some settings and situations", Definition="Child shows functioning expected for his or her age some of the time and/or in some settings and situations. Child's functioning is a mix of age-appropriate and not age-appropriate behaviors and skills.", SortOrder=Convert.ToDecimal("10.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("3c6aaf7e-8ab3-4e5f-8966-986a9b16d33b"), Code="06", Description="Functioning generally is considered appropriate for age but there are some significant concerns", Definition="Child's functioning generally is considered appropriate for his or her age but there are some significant concerns about the child's functioning in this outcome area. These concerns are substantial enough to suggest monitoring or possible additional support.", SortOrder=Convert.ToDecimal("12.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("eefc922c-5d7a-43fb-abd1-5e13282e59ab"), Code="07", Description="Shows functioning expected for age in all or almost all everyday situations", Definition="Child shows functioning expected for his or her age in all or almost all everyday situations that are part of the child's life. Functioning is considered appropriate for his or her age.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The RefChildOutcomesSummaryRating Pick List
         /// </summary>
        public static List<RefChildOutcomesSummaryRating> RefChildOutcomesSummaryRatingPickList = new List<RefChildOutcomesSummaryRating>
        {
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("f9b52e15-fb1f-4878-9508-de4cc12173fb"), Code="01", Description="Does not show functioning expected at age - does not include immediate foundational skills", SortOrder=Convert.ToDecimal("2.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("ced70af6-381e-456d-9862-9e7736a8e3ea"), Code="02", Description="Occasionally uses immediate foundational skills across settings and situations", SortOrder=Convert.ToDecimal("4.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("3c729027-54ef-4db1-b338-28b0b23e16be"), Code="03", Description="Does not show functioning expected at age - uses immediate foundational skills", SortOrder=Convert.ToDecimal("6.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("54a79d1e-f27a-4e6a-9201-1fd2d4cd46fd"), Code="04", Description="Shows occasional age-appropriate functioning across settings and situations", SortOrder=Convert.ToDecimal("8.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("f6281622-933b-44af-bc3a-a75dd368b0bf"), Code="05", Description="Shows functioning expected at age some of the time and/or in some settings and situations", SortOrder=Convert.ToDecimal("10.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("3c6aaf7e-8ab3-4e5f-8966-986a9b16d33b"), Code="06", Description="Functioning generally is considered appropriate for age but there are some significant concerns", SortOrder=Convert.ToDecimal("12.00") },
            new RefChildOutcomesSummaryRating { Id=Guid.Parse("eefc922c-5d7a-43fb-abd1-5e13282e59ab"), Code="07", Description="Shows functioning expected for age in all or almost all everyday situations", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
