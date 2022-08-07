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
        /// The complete <see cref="RefPromotionReasonModel"> List
         /// </summary>
        public static List<RefPromotionReasonModel> RefPromotionReasonList = new List<RefPromotionReasonModel>
        {
            new RefPromotionReason { Id=Guid.Parse("088f984e-9d5e-4302-86c3-8ad883a86c4e"), Code="AcceleratedPromotion", Description="Accelerated promotion", Definition="Accelerated promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPromotionReason { Id=Guid.Parse("fc941b7f-b513-485f-8155-295e9f79d917"), Code="ContinuousPromotion", Description="Continuous promotion", Definition="Continuous promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPromotionReason { Id=Guid.Parse("87212ee8-e9ca-4189-8d48-5295f5009049"), Code="Other", Description="Other", Definition="The nature of the student's promotion or progress at the end of a given school term is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPromotionReason { Id=Guid.Parse("9d5fc204-9533-487b-ab3b-f8a989beb786"), Code="ProbationaryPromotion", Description="Probationary promotion", Definition="Probationary promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPromotionReason { Id=Guid.Parse("62757156-cd0a-429a-8f56-ea3764eccc27"), Code="RegularPromotion", Description="Regular promotion", Definition="Regular promotion is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPromotionReason { Id=Guid.Parse("05e53344-a247-494d-96fb-04fdaa7eb89b"), Code="VariableProgress", Description="Variable progress", Definition="Variable progress is the nature of the student's promotion or progress at the end of a given school term.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefPromotionReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPromotionReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPromotionReason { Id=Guid.Parse("088f984e-9d5e-4302-86c3-8ad883a86c4e"), Description="Accelerated promotion", SortOrder=Convert.ToDecimal("1.00") },
            new RefPromotionReason { Id=Guid.Parse("fc941b7f-b513-485f-8155-295e9f79d917"), Description="Continuous promotion", SortOrder=Convert.ToDecimal("2.00") },
            new RefPromotionReason { Id=Guid.Parse("87212ee8-e9ca-4189-8d48-5295f5009049"), Description="Other", SortOrder=Convert.ToDecimal("3.00") },
            new RefPromotionReason { Id=Guid.Parse("9d5fc204-9533-487b-ab3b-f8a989beb786"), Description="Probationary promotion", SortOrder=Convert.ToDecimal("4.00") },
            new RefPromotionReason { Id=Guid.Parse("62757156-cd0a-429a-8f56-ea3764eccc27"), Description="Regular promotion", SortOrder=Convert.ToDecimal("5.00") },
            new RefPromotionReason { Id=Guid.Parse("05e53344-a247-494d-96fb-04fdaa7eb89b"), Description="Variable progress", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
