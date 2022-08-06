//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefReferralOutcomeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefReferralOutcome Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefReferralOutcome"> List
         /// </summary>
        public static List<RefReferralOutcome> RefReferralOutcomeList = new List<RefReferralOutcome>
        {
            new RefReferralOutcome { Id=Guid.Parse("fb87d1cb-2f85-48af-a925-25f659dd9571"), Code="WaitingList", Description="Waiting list", Definition="The student is on a waiting list to receive services based on the referral.", SortOrder=Convert.ToDecimal("2.00") },
            new RefReferralOutcome { Id=Guid.Parse("b8e0cee8-9e30-40e2-bba6-fce868fcf64f"), Code="ParentDeclined", Description="Parent declined service", Definition="Parent declined service offered based on the referral.", SortOrder=Convert.ToDecimal("4.00") },
            new RefReferralOutcome { Id=Guid.Parse("70497e56-9d3b-4be2-a574-bd3129f7b1c1"), Code="Enrolled", Description="Enrolled", Definition="The student is enrolled based on the referral.", SortOrder=Convert.ToDecimal("6.00") },
            new RefReferralOutcome { Id=Guid.Parse("5b91c1ed-60ed-4af7-9fd1-ff3f567775e2"), Code="Unreachable", Description="Unable to contact parent/family/guardian", Definition="The service provider has been unable to contact parent/family/guardian.", SortOrder=Convert.ToDecimal("8.00") },
            new RefReferralOutcome { Id=Guid.Parse("1faf9d66-2426-4ee7-9efe-725f9834c15b"), Code="NotEligible", Description="Not eligible", Definition="The student is not eligible to receive services related to the referral.", SortOrder=Convert.ToDecimal("10.00") },
            new RefReferralOutcome { Id=Guid.Parse("76e47940-1395-4ed3-a90b-0915d9c356c6"), Code="Other", Description="Other", Definition="The outcome of the referral is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefReferralOutcome Pick List
         /// </summary>
        public static List<RefReferralOutcome> RefReferralOutcomePickList = new List<RefReferralOutcome>
        {
            new RefReferralOutcome { Id=Guid.Parse("fb87d1cb-2f85-48af-a925-25f659dd9571"), Code="WaitingList", Description="Waiting list", SortOrder=Convert.ToDecimal("2.00") },
            new RefReferralOutcome { Id=Guid.Parse("b8e0cee8-9e30-40e2-bba6-fce868fcf64f"), Code="ParentDeclined", Description="Parent declined service", SortOrder=Convert.ToDecimal("4.00") },
            new RefReferralOutcome { Id=Guid.Parse("70497e56-9d3b-4be2-a574-bd3129f7b1c1"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("6.00") },
            new RefReferralOutcome { Id=Guid.Parse("5b91c1ed-60ed-4af7-9fd1-ff3f567775e2"), Code="Unreachable", Description="Unable to contact parent/family/guardian", SortOrder=Convert.ToDecimal("8.00") },
            new RefReferralOutcome { Id=Guid.Parse("1faf9d66-2426-4ee7-9efe-725f9834c15b"), Code="NotEligible", Description="Not eligible", SortOrder=Convert.ToDecimal("10.00") },
            new RefReferralOutcome { Id=Guid.Parse("76e47940-1395-4ed3-a90b-0915d9c356c6"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
