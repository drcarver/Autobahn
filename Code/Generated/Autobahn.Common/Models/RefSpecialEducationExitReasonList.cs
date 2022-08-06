//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSpecialEducationExitReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSpecialEducationExitReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSpecialEducationExitReason"> List
         /// </summary>
        public static List<RefSpecialEducationExitReason> RefSpecialEducationExitReasonList = new List<RefSpecialEducationExitReason>
        {
            new RefSpecialEducationExitReason { Id=Guid.Parse("4f17b83f-779c-4b56-ade3-6a369c760ba4"), Code="HighSchoolDiploma", Description="Graduated with regular high school diploma", Definition="Graduated with regular high school diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("6150df8c-8f67-4165-add8-0d4e91488a23"), Code="ReceivedCertificate", Description="Received a certificate", Definition="Received a certificate is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("04fd236a-c883-4ea6-a546-05acc8d1374f"), Code="ReachedMaximumAge", Description="Reached maximum age", Definition="Reached maximum age is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("f102619b-d7f6-4395-909f-e42702d43dc2"), Code="Died", Description="Died", Definition="Died is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("0cca8ce3-339f-46b5-bc0d-56e530bfeb2e"), Code="MovedAndContinuing", Description="Moved, known to be continuing", Definition="Moved, known to be continuing is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("b0da8527-8cae-405a-865a-298750de755d"), Code="DroppedOut", Description="Dropped out", Definition="Dropped out is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("dcc7d6ce-7e0b-4772-be30-b90a666004ef"), Code="Transferred", Description="Transferred to regular education", Definition="Transferred to regular education is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("603593b1-93c0-4114-b2df-12f6d875700d"), Code="PartCNoLongerEligible", Description="No longer eligible for Part C prior to reaching age three.", Definition="No longer eligible for Part C prior to reaching age three  is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5c2005a8-45c5-4e55-91d9-555705ebb564"), Code="PartBEligibleExitingPartC", Description="Part B eligible, exiting Part C.", Definition="Part B eligible, exiting Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("11.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("b3482eb9-6ec4-4d81-9469-0cb279c2dc89"), Code="PartBEligibleContinuingPartC", Description="Part B eligible, continuing in Part C.", Definition="Part B eligible, continuing in Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("13.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("08a82e72-0416-4f9a-9dce-114f7bc7e5ee"), Code="NotPartBEligibleExitingPartCWithReferrrals", Description="Not eligible for Part B, exit with referrals to other programs.", Definition="Not eligible for Part B, exit with referrals to other programs is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("15.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5d616422-ca11-4566-90c9-2b9b8bade1e3"), Code="NotPartBEligibleExitingPartCWithoutReferrrals", Description="Not eligible for Part B, exit with no referrals.", Definition="Not eligible for Part B, exit with no referrals is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("17.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("4721cece-fb1b-4a3a-81d0-e37395329e6a"), Code="PartBEligibilityNotDeterminedExitingPartC", Description="Part B eligibility not determined.", Definition="Part B eligibility not determined is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("19.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5fd1b5ca-c5de-4c77-8fa3-007b3a3d7468"), Code="WithdrawalByParent", Description="Withdrawal by parent (or guardian).", Definition="Withdrawal by parent (or guardian) is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("21.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("ac5f705e-a61d-4918-84d9-8583fe75755b"), Code="MovedOutOfState", Description="Moved out of State", Definition="Moved out of State is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("23.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("8a76ba85-7e83-48a0-8f83-2af5144796f8"), Code="Unreachable", Description="Attempts to contact the parent and/or child were unsuccessful.", Definition="Attempts to contact the parent and/or child were unsuccessful is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("25.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("ea32a6b0-14db-4478-9d4e-d83d608c1844"), Code="GraduatedAlternateDiploma", Description="Graduated with an alternate diploma", Definition="Graduated with an alternate diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("26.00") },
        };

        /// <summary>
        /// The RefSpecialEducationExitReason Pick List
         /// </summary>
        public static List<RefSpecialEducationExitReason> RefSpecialEducationExitReasonPickList = new List<RefSpecialEducationExitReason>
        {
            new RefSpecialEducationExitReason { Id=Guid.Parse("4f17b83f-779c-4b56-ade3-6a369c760ba4"), Code="HighSchoolDiploma", Description="Graduated with regular high school diploma", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("6150df8c-8f67-4165-add8-0d4e91488a23"), Code="ReceivedCertificate", Description="Received a certificate", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("04fd236a-c883-4ea6-a546-05acc8d1374f"), Code="ReachedMaximumAge", Description="Reached maximum age", SortOrder=Convert.ToDecimal("3.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("f102619b-d7f6-4395-909f-e42702d43dc2"), Code="Died", Description="Died", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("0cca8ce3-339f-46b5-bc0d-56e530bfeb2e"), Code="MovedAndContinuing", Description="Moved, known to be continuing", SortOrder=Convert.ToDecimal("5.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("b0da8527-8cae-405a-865a-298750de755d"), Code="DroppedOut", Description="Dropped out", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("dcc7d6ce-7e0b-4772-be30-b90a666004ef"), Code="Transferred", Description="Transferred to regular education", SortOrder=Convert.ToDecimal("7.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("603593b1-93c0-4114-b2df-12f6d875700d"), Code="PartCNoLongerEligible", Description="No longer eligible for Part C prior to reaching age three.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5c2005a8-45c5-4e55-91d9-555705ebb564"), Code="PartBEligibleExitingPartC", Description="Part B eligible, exiting Part C.", SortOrder=Convert.ToDecimal("11.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("b3482eb9-6ec4-4d81-9469-0cb279c2dc89"), Code="PartBEligibleContinuingPartC", Description="Part B eligible, continuing in Part C.", SortOrder=Convert.ToDecimal("13.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("08a82e72-0416-4f9a-9dce-114f7bc7e5ee"), Code="NotPartBEligibleExitingPartCWithReferrrals", Description="Not eligible for Part B, exit with referrals to other programs.", SortOrder=Convert.ToDecimal("15.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5d616422-ca11-4566-90c9-2b9b8bade1e3"), Code="NotPartBEligibleExitingPartCWithoutReferrrals", Description="Not eligible for Part B, exit with no referrals.", SortOrder=Convert.ToDecimal("17.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("4721cece-fb1b-4a3a-81d0-e37395329e6a"), Code="PartBEligibilityNotDeterminedExitingPartC", Description="Part B eligibility not determined.", SortOrder=Convert.ToDecimal("19.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("5fd1b5ca-c5de-4c77-8fa3-007b3a3d7468"), Code="WithdrawalByParent", Description="Withdrawal by parent (or guardian).", SortOrder=Convert.ToDecimal("21.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("ac5f705e-a61d-4918-84d9-8583fe75755b"), Code="MovedOutOfState", Description="Moved out of State", SortOrder=Convert.ToDecimal("23.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("8a76ba85-7e83-48a0-8f83-2af5144796f8"), Code="Unreachable", Description="Attempts to contact the parent and/or child were unsuccessful.", SortOrder=Convert.ToDecimal("25.00") },
            new RefSpecialEducationExitReason { Id=Guid.Parse("ea32a6b0-14db-4478-9d4e-d83d608c1844"), Code="GraduatedAlternateDiploma", Description="Graduated with an alternate diploma", SortOrder=Convert.ToDecimal("26.00") },
       };
   }
}
