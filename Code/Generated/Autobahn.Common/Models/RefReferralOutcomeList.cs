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
        public static List<RefReferralOutcome> RefReferralOutcomeList = new List<RefReferralOutcome> =
        {
            new RefReferralOutcome { Id=Guid.Parse("19c1ce03-f477-4be4-9466-674d738bc183"), Code="The student is on a waiting list to receive services based on the referral.", Description="WaitingList", Definition="", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("6deed0ea-a82c-4253-8a38-92ab9c65c34e"), Code="Parent declined service offered based on the referral.", Description="ParentDeclined", Definition="", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("43d4c735-ff47-4883-bed5-93746fb830f2"), Code="The student is enrolled based on the referral.", Description="Enrolled", Definition="", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("def57b23-0eee-473a-a768-046f8ce6b69f"), Code="The service provider has been unable to contact parent/family/guardian.", Description="Unreachable", Definition="", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("e21eec3f-c8fd-4ecb-8d71-8fd36742d250"), Code="The student is not eligible to receive services related to the referral.", Description="NotEligible", Definition="", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("06e2a2ef-c2f2-4f84-91f6-f66f08d989c3"), Code="The outcome of the referral is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefReferralOutcome Pick List
         /// </summary>
        public static List<RefReferralOutcome> RefReferralOutcomePickList = new List<RefReferralOutcome> =
        {
            new RefReferralOutcome { Id=Guid.Parse("19c1ce03-f477-4be4-9466-674d738bc183"), Code="The student is on a waiting list to receive services based on the referral.", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("6deed0ea-a82c-4253-8a38-92ab9c65c34e"), Code="Parent declined service offered based on the referral.", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("43d4c735-ff47-4883-bed5-93746fb830f2"), Code="The student is enrolled based on the referral.", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("def57b23-0eee-473a-a768-046f8ce6b69f"), Code="The service provider has been unable to contact parent/family/guardian.", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("e21eec3f-c8fd-4ecb-8d71-8fd36742d250"), Code="The student is not eligible to receive services related to the referral.", SortOrder=0 },
            new RefReferralOutcome { Id=Guid.Parse("06e2a2ef-c2f2-4f84-91f6-f66f08d989c3"), Code="The outcome of the referral is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
