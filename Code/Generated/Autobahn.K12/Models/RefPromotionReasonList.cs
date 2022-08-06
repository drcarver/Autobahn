//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPromotionReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPromotionReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPromotionReason"> List
         /// </summary>
        public static List<RefPromotionReason> RefPromotionReasonList = new List<RefPromotionReason> =
        {
            new RefPromotionReason { Id=Guid.Parse("d397320d-b6bc-47e6-82da-89ca500ff246"), Code="Accelerated promotion is the nature of the student's promotion or progress at the end of a given school term.", Description="AcceleratedPromotion", Definition="", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("090e33fe-920e-4b6f-af09-afa822472686"), Code="Continuous promotion is the nature of the student's promotion or progress at the end of a given school term.", Description="ContinuousPromotion", Definition="", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("3ebb8eb3-7025-46ac-94a2-8d8b476a2069"), Code="The nature of the student's promotion or progress at the end of a given school term is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("61ddea22-30ae-4a91-bea9-201fedb9f5c6"), Code="Probationary promotion is the nature of the student's promotion or progress at the end of a given school term.", Description="ProbationaryPromotion", Definition="", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("c3f82cf4-b040-4623-a7bc-c9c0fc9143f7"), Code="Regular promotion is the nature of the student's promotion or progress at the end of a given school term.", Description="RegularPromotion", Definition="", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("dcb0f847-ee96-4efe-b3bd-209685d4da8b"), Code="Variable progress is the nature of the student's promotion or progress at the end of a given school term.", Description="VariableProgress", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPromotionReason Pick List
         /// </summary>
        public static List<RefPromotionReason> RefPromotionReasonPickList = new List<RefPromotionReason> =
        {
            new RefPromotionReason { Id=Guid.Parse("d397320d-b6bc-47e6-82da-89ca500ff246"), Code="Accelerated promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("090e33fe-920e-4b6f-af09-afa822472686"), Code="Continuous promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("3ebb8eb3-7025-46ac-94a2-8d8b476a2069"), Code="The nature of the student's promotion or progress at the end of a given school term is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("61ddea22-30ae-4a91-bea9-201fedb9f5c6"), Code="Probationary promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("c3f82cf4-b040-4623-a7bc-c9c0fc9143f7"), Code="Regular promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=0 },
            new RefPromotionReason { Id=Guid.Parse("dcb0f847-ee96-4efe-b3bd-209685d4da8b"), Code="Variable progress is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=0 },
       };
   }
}
