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
        public static List<RefPromotionReason> RefPromotionReasonList = new List<RefPromotionReason>
        {
            new RefPromotionReason { Id=Guid.Parse("5adac4c5-001d-4d00-ab9d-09dff693204f"), Code="AcceleratedPromotion", Description="Accelerated promotion", Definition="Accelerated promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPromotionReason { Id=Guid.Parse("dc56c241-a7cb-44eb-80b1-210cd0872cb4"), Code="ContinuousPromotion", Description="Continuous promotion", Definition="Continuous promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPromotionReason { Id=Guid.Parse("4de7002a-4faa-4efa-9fef-63599b12e968"), Code="Other", Description="Other", Definition="The nature of the student's promotion or progress at the end of a given school term is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPromotionReason { Id=Guid.Parse("5aa4a4ec-dd3f-4e48-9e0b-a2bc989bf907"), Code="ProbationaryPromotion", Description="Probationary promotion", Definition="Probationary promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPromotionReason { Id=Guid.Parse("a6004b88-bd99-40c8-8dc8-843500d36546"), Code="RegularPromotion", Description="Regular promotion", Definition="Regular promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPromotionReason { Id=Guid.Parse("8dd3bcad-cea8-4c81-8c71-7f248cdeb6d1"), Code="VariableProgress", Description="Variable progress", Definition="Variable progress is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefPromotionReason Pick List
         /// </summary>
        public static List<RefPromotionReason> RefPromotionReasonPickList = new List<RefPromotionReason>
        {
            new RefPromotionReason { Id=Guid.Parse("5adac4c5-001d-4d00-ab9d-09dff693204f"), Code="AcceleratedPromotion", Description="Accelerated promotion", SortOrder=Convert.ToDecimal("1.00") },
            new RefPromotionReason { Id=Guid.Parse("dc56c241-a7cb-44eb-80b1-210cd0872cb4"), Code="ContinuousPromotion", Description="Continuous promotion", SortOrder=Convert.ToDecimal("2.00") },
            new RefPromotionReason { Id=Guid.Parse("4de7002a-4faa-4efa-9fef-63599b12e968"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("3.00") },
            new RefPromotionReason { Id=Guid.Parse("5aa4a4ec-dd3f-4e48-9e0b-a2bc989bf907"), Code="ProbationaryPromotion", Description="Probationary promotion", SortOrder=Convert.ToDecimal("4.00") },
            new RefPromotionReason { Id=Guid.Parse("a6004b88-bd99-40c8-8dc8-843500d36546"), Code="RegularPromotion", Description="Regular promotion", SortOrder=Convert.ToDecimal("5.00") },
            new RefPromotionReason { Id=Guid.Parse("8dd3bcad-cea8-4c81-8c71-7f248cdeb6d1"), Code="VariableProgress", Description="Variable progress", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
