//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefFoodServiceParticipationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefFoodServiceParticipation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFoodServiceParticipationModel"> List
         /// </summary>
        public static List<RefFoodServiceParticipationModel> RefFoodServiceParticipationList = new List<RefFoodServiceParticipationModel>
        {
            new RefFoodServiceParticipation { Id=Guid.Parse("50a0731a-8cfb-4f1e-8996-94c728e2120b"), Code="FreeBreakfast", Description="Free breakfast", Definition="The student participates in the free breakfast food service program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("c2ff0a7c-bb49-4478-999f-b8da8e2b9167"), Code="FreeLunch", Description="Free lunch", Definition="The student participates in the free lunch  food service program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("4e09798a-6ac3-4f06-90cd-e224525a7e99"), Code="FreeMilk", Description="Free milk", Definition="The student participates in the Free milk food service program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("27730fc2-52e5-4840-868a-bc9deb3f7c11"), Code="FreeSnack", Description="Free snack", Definition="The student participates in the Free snack food service program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("bd50e8e1-7090-4e0d-9313-9ed9a2bfb43f"), Code="FreeSupper", Description="Free supper", Definition="The student participates in the Free supper food service program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("f30cefb4-cec6-4049-b60f-0942ad5402e0"), Code="FullPriceBreakfast", Description="Full price breakfast", Definition="The student participates in the Full price breakfast food service program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("067da14f-ffa1-48e9-b2ee-1576895e5514"), Code="FullPriceLunch", Description="Full price lunch", Definition="The student participates in the Full price lunch food service program.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("af6a3261-8e00-472f-a2de-2bb3faf3f5a8"), Code="FullPriceMilk", Description="Full price milk", Definition="The student participates in the Full price milk food service program.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("e00cc3ee-f2e3-4a4d-a349-8b594c4c85c4"), Code="FullPriceSnack", Description="Full price snack", Definition="The student participates in the Full price snack food service program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("a529b16f-3391-4707-b31d-8535d09aa658"), Code="FullPriceSupper", Description="Full price supper", Definition="The student participates in the Full price supper food service program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("582653a2-9fe1-4257-83b1-58334ee6e653"), Code="ReducedPriceBreakfast", Description="Reduced price breakfast", Definition="The student participates in the Reduced price breakfast food service program.", SortOrder=Convert.ToDecimal("11.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("3fb1e99f-7a85-408c-ad9b-86712cc2d975"), Code="ReducedPriceLunch", Description="Reduced price lunch", Definition="The student participates in the Reduced price lunch food service program.", SortOrder=Convert.ToDecimal("12.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("feef41e7-029a-4c95-a348-a50ce82b487f"), Code="ReducedPriceSnack", Description="Reduced price snack", Definition="The student participates in the Reduced price snac food service program.", SortOrder=Convert.ToDecimal("13.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("63e2382c-8dd1-4d26-974d-f1da083dfaf2"), Code="ReducedPriceSupper", Description="Reduced price supper", Definition="The student participates in the Reduced price supper food service program.", SortOrder=Convert.ToDecimal("14.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("6b30a1ba-2498-4a34-bec6-4040ab49c6fd"), Code="Other", Description="Other", Definition="The student participates in a category of the food service program not yet defined in CEDS.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The Reference RefFoodServiceParticipation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFoodServiceParticipationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFoodServiceParticipation { Id=Guid.Parse("50a0731a-8cfb-4f1e-8996-94c728e2120b"), Description="Free breakfast", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("c2ff0a7c-bb49-4478-999f-b8da8e2b9167"), Description="Free lunch", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("4e09798a-6ac3-4f06-90cd-e224525a7e99"), Description="Free milk", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("27730fc2-52e5-4840-868a-bc9deb3f7c11"), Description="Free snack", SortOrder=Convert.ToDecimal("4.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("bd50e8e1-7090-4e0d-9313-9ed9a2bfb43f"), Description="Free supper", SortOrder=Convert.ToDecimal("5.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("f30cefb4-cec6-4049-b60f-0942ad5402e0"), Description="Full price breakfast", SortOrder=Convert.ToDecimal("6.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("067da14f-ffa1-48e9-b2ee-1576895e5514"), Description="Full price lunch", SortOrder=Convert.ToDecimal("7.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("af6a3261-8e00-472f-a2de-2bb3faf3f5a8"), Description="Full price milk", SortOrder=Convert.ToDecimal("8.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("e00cc3ee-f2e3-4a4d-a349-8b594c4c85c4"), Description="Full price snack", SortOrder=Convert.ToDecimal("9.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("a529b16f-3391-4707-b31d-8535d09aa658"), Description="Full price supper", SortOrder=Convert.ToDecimal("10.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("582653a2-9fe1-4257-83b1-58334ee6e653"), Description="Reduced price breakfast", SortOrder=Convert.ToDecimal("11.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("3fb1e99f-7a85-408c-ad9b-86712cc2d975"), Description="Reduced price lunch", SortOrder=Convert.ToDecimal("12.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("feef41e7-029a-4c95-a348-a50ce82b487f"), Description="Reduced price snack", SortOrder=Convert.ToDecimal("13.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("63e2382c-8dd1-4d26-974d-f1da083dfaf2"), Description="Reduced price supper", SortOrder=Convert.ToDecimal("14.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("6b30a1ba-2498-4a34-bec6-4040ab49c6fd"), Description="Other", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
