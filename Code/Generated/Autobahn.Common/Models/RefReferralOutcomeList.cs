//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefReferralOutcomeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefReferralOutcome Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefReferralOutcomeModel"> List
         /// </summary>
        public static List<RefReferralOutcomeModel> RefReferralOutcomeList = new List<RefReferralOutcomeModel>
        {
            new RefReferralOutcome { Id=Guid.Parse("8db078cb-abef-486e-b88f-f36fbc8cc0c2"), Code="WaitingList", Description="Waiting list", Definition="The student is on a waiting list to receive services based on the referral.", SortOrder=Convert.ToDecimal("2.00") },
            new RefReferralOutcome { Id=Guid.Parse("98ba7299-9242-464d-95d6-f35b3b7d4e86"), Code="ParentDeclined", Description="Parent declined service", Definition="Parent declined service offered based on the referral.", SortOrder=Convert.ToDecimal("4.00") },
            new RefReferralOutcome { Id=Guid.Parse("c22ab86b-d4e5-4792-8b1c-b985301d82a8"), Code="Enrolled", Description="Enrolled", Definition="The student is enrolled based on the referral.", SortOrder=Convert.ToDecimal("6.00") },
            new RefReferralOutcome { Id=Guid.Parse("3a0dc6cc-8a32-46dc-a29d-6907781176a7"), Code="Unreachable", Description="Unable to contact parent/family/guardian", Definition="The service provider has been unable to contact parent/family/guardian.", SortOrder=Convert.ToDecimal("8.00") },
            new RefReferralOutcome { Id=Guid.Parse("025d9a33-54c6-407e-8239-16708f1cc5de"), Code="NotEligible", Description="Not eligible", Definition="The student is not eligible to receive services related to the referral.", SortOrder=Convert.ToDecimal("10.00") },
            new RefReferralOutcome { Id=Guid.Parse("c4871b91-f3f2-448b-9b2d-95ce42c7cfe1"), Code="Other", Description="Other", Definition="The outcome of the referral is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefReferralOutcome Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefReferralOutcomeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefReferralOutcome { Id=Guid.Parse("8db078cb-abef-486e-b88f-f36fbc8cc0c2"), Description="Waiting list", SortOrder=Convert.ToDecimal("2.00") },
            new RefReferralOutcome { Id=Guid.Parse("98ba7299-9242-464d-95d6-f35b3b7d4e86"), Description="Parent declined service", SortOrder=Convert.ToDecimal("4.00") },
            new RefReferralOutcome { Id=Guid.Parse("c22ab86b-d4e5-4792-8b1c-b985301d82a8"), Description="Enrolled", SortOrder=Convert.ToDecimal("6.00") },
            new RefReferralOutcome { Id=Guid.Parse("3a0dc6cc-8a32-46dc-a29d-6907781176a7"), Description="Unable to contact parent/family/guardian", SortOrder=Convert.ToDecimal("8.00") },
            new RefReferralOutcome { Id=Guid.Parse("025d9a33-54c6-407e-8239-16708f1cc5de"), Description="Not eligible", SortOrder=Convert.ToDecimal("10.00") },
            new RefReferralOutcome { Id=Guid.Parse("c4871b91-f3f2-448b-9b2d-95ce42c7cfe1"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
