//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefNonPromotionReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefNonPromotionReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNonPromotionReasonModel"> List
         /// </summary>
        public static List<RefNonPromotionReasonModel> RefNonPromotionReasonList = new List<RefNonPromotionReasonModel>
        {
            new RefNonPromotionReason { Id=Guid.Parse("376d92d0-bf70-4ff6-bf05-92087dbbeafa"), Code="FailedTestingRequirements", Description="Failed to meet testing requirements", Definition="Failed to meet testing requirements is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("1.00") },
            new RefNonPromotionReason { Id=Guid.Parse("4f801702-625f-48dc-893e-21241efa470a"), Code="Illness", Description="Illness", Definition="Illness is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("2.00") },
            new RefNonPromotionReason { Id=Guid.Parse("b239c9cf-d896-43c4-b5ed-bb653b7b643c"), Code="Immaturity", Description="Immaturity", Definition="Immaturity is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("3.00") },
            new RefNonPromotionReason { Id=Guid.Parse("db45859e-566f-4358-a440-7431762d5fb8"), Code="InadequatePerformance", Description="Inadequate performance", Definition="Inadequate performance is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("4.00") },
            new RefNonPromotionReason { Id=Guid.Parse("652f93e6-6ca2-4906-b8ff-0b8f866f1eea"), Code="InsufficientCredits", Description="Insufficient credits", Definition="Insufficient credits is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("5.00") },
            new RefNonPromotionReason { Id=Guid.Parse("97662f47-5dbd-4eb5-b614-c79b6a75ef88"), Code="Other", Description="Other", Definition="Other is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("6.00") },
            new RefNonPromotionReason { Id=Guid.Parse("6cfd69d5-245b-4ad1-b4ba-c8b2e2b928b4"), Code="ProlongedAbsence", Description="Prolonged absence", Definition="Prolonged absence is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefNonPromotionReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNonPromotionReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNonPromotionReason { Id=Guid.Parse("376d92d0-bf70-4ff6-bf05-92087dbbeafa"), Description="Failed to meet testing requirements", SortOrder=Convert.ToDecimal("1.00") },
            new RefNonPromotionReason { Id=Guid.Parse("4f801702-625f-48dc-893e-21241efa470a"), Description="Illness", SortOrder=Convert.ToDecimal("2.00") },
            new RefNonPromotionReason { Id=Guid.Parse("b239c9cf-d896-43c4-b5ed-bb653b7b643c"), Description="Immaturity", SortOrder=Convert.ToDecimal("3.00") },
            new RefNonPromotionReason { Id=Guid.Parse("db45859e-566f-4358-a440-7431762d5fb8"), Description="Inadequate performance", SortOrder=Convert.ToDecimal("4.00") },
            new RefNonPromotionReason { Id=Guid.Parse("652f93e6-6ca2-4906-b8ff-0b8f866f1eea"), Description="Insufficient credits", SortOrder=Convert.ToDecimal("5.00") },
            new RefNonPromotionReason { Id=Guid.Parse("97662f47-5dbd-4eb5-b614-c79b6a75ef88"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefNonPromotionReason { Id=Guid.Parse("6cfd69d5-245b-4ad1-b4ba-c8b2e2b928b4"), Description="Prolonged absence", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
