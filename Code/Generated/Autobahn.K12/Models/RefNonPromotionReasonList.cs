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
        public static List<RefNonPromotionReason> RefNonPromotionReasonList = new List<RefNonPromotionReason> =
        {
            new RefNonPromotionReason { Id=Guid.Parse("82267edc-1ea4-406b-b503-7deb439ffaad"), Code="Failed to meet testing requirements is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="FailedTestingRequirements", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("3d364975-d524-4cf4-bbfc-af2359aa47e9"), Code="Illness is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="Illness", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("d210e0db-5fe6-49b0-85d7-cccdde25af03"), Code="Immaturity is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="Immaturity", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("3a53dc65-23e3-4c54-bce7-e424221a28e4"), Code="Inadequate performance is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="InadequatePerformance", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("8c216e45-3af7-4fb5-91a5-89154e2e7d03"), Code="Insufficient credits is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="InsufficientCredits", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("fd69fa23-37ed-48f2-a19e-608acb89d948"), Code="Other is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="Other", Definition="", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("c6bebcd4-f456-4a64-b6fe-484309dd9bc0"), Code="Prolonged absence is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", Description="ProlongedAbsence", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNonPromotionReason Pick List
         /// </summary>
        public static List<RefNonPromotionReason> RefNonPromotionReasonPickList = new List<RefNonPromotionReason> =
        {
            new RefNonPromotionReason { Id=Guid.Parse("82267edc-1ea4-406b-b503-7deb439ffaad"), Code="Failed to meet testing requirements is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("3d364975-d524-4cf4-bbfc-af2359aa47e9"), Code="Illness is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("d210e0db-5fe6-49b0-85d7-cccdde25af03"), Code="Immaturity is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("3a53dc65-23e3-4c54-bce7-e424221a28e4"), Code="Inadequate performance is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("8c216e45-3af7-4fb5-91a5-89154e2e7d03"), Code="Insufficient credits is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("fd69fa23-37ed-48f2-a19e-608acb89d948"), Code="Other is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
            new RefNonPromotionReason { Id=Guid.Parse("c6bebcd4-f456-4a64-b6fe-484309dd9bc0"), Code="Prolonged absence is the primary reason  why a staff member determined that a student should not be promoted (or be demoted).", SortOrder=0 },
       };
   }
}
