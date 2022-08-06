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
        /// The complete <see cref="RefNonPromotionReason"> List
         /// </summary>
        public static List<RefNonPromotionReason> RefNonPromotionReasonList = new List<RefNonPromotionReason>
        {
            new RefNonPromotionReason { Id=Guid.Parse("7303aea0-be64-4016-bf7b-a754f1518a46"), Code="FailedTestingRequirements", Description="Failed to meet testing requirements", Definition="Failed to meet testing requirements is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("1.00") },
            new RefNonPromotionReason { Id=Guid.Parse("3a4b2124-9e53-429a-b403-23b1aed452aa"), Code="Illness", Description="Illness", Definition="Illness is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("2.00") },
            new RefNonPromotionReason { Id=Guid.Parse("43cf199b-8160-4514-af88-0c02c221db34"), Code="Immaturity", Description="Immaturity", Definition="Immaturity is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("3.00") },
            new RefNonPromotionReason { Id=Guid.Parse("04be39fa-b4a0-4b69-bafd-0fb3fc2077bb"), Code="InadequatePerformance", Description="Inadequate performance", Definition="Inadequate performance is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("4.00") },
            new RefNonPromotionReason { Id=Guid.Parse("4041c256-98fb-4a61-9a02-3a786fa1a299"), Code="InsufficientCredits", Description="Insufficient credits", Definition="Insufficient credits is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("5.00") },
            new RefNonPromotionReason { Id=Guid.Parse("770bdfe8-0df4-4482-a5fc-dbf8162f7bdc"), Code="Other", Description="Other", Definition="Other is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("6.00") },
            new RefNonPromotionReason { Id=Guid.Parse("0e5f61de-0a9d-48de-b30c-b4699cd14639"), Code="ProlongedAbsence", Description="Prolonged absence", Definition="Prolonged absence is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefNonPromotionReason Pick List
         /// </summary>
        public static List<RefNonPromotionReason> RefNonPromotionReasonPickList = new List<RefNonPromotionReason>
        {
            new RefNonPromotionReason { Id=Guid.Parse("7303aea0-be64-4016-bf7b-a754f1518a46"), Code="FailedTestingRequirements", Description="Failed to meet testing requirements", SortOrder=Convert.ToDecimal("1.00") },
            new RefNonPromotionReason { Id=Guid.Parse("3a4b2124-9e53-429a-b403-23b1aed452aa"), Code="Illness", Description="Illness", SortOrder=Convert.ToDecimal("2.00") },
            new RefNonPromotionReason { Id=Guid.Parse("43cf199b-8160-4514-af88-0c02c221db34"), Code="Immaturity", Description="Immaturity", SortOrder=Convert.ToDecimal("3.00") },
            new RefNonPromotionReason { Id=Guid.Parse("04be39fa-b4a0-4b69-bafd-0fb3fc2077bb"), Code="InadequatePerformance", Description="Inadequate performance", SortOrder=Convert.ToDecimal("4.00") },
            new RefNonPromotionReason { Id=Guid.Parse("4041c256-98fb-4a61-9a02-3a786fa1a299"), Code="InsufficientCredits", Description="Insufficient credits", SortOrder=Convert.ToDecimal("5.00") },
            new RefNonPromotionReason { Id=Guid.Parse("770bdfe8-0df4-4482-a5fc-dbf8162f7bdc"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
            new RefNonPromotionReason { Id=Guid.Parse("0e5f61de-0a9d-48de-b30c-b4699cd14639"), Code="ProlongedAbsence", Description="Prolonged absence", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
