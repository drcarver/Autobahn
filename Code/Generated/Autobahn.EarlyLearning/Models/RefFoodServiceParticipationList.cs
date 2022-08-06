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
        /// The complete <see cref="RefFoodServiceParticipation"> List
         /// </summary>
        public static List<RefFoodServiceParticipation> RefFoodServiceParticipationList = new List<RefFoodServiceParticipation>
        {
            new RefFoodServiceParticipation { Id=Guid.Parse("00c05187-b409-4d8b-9f3c-9a11e6161a19"), Code="FreeBreakfast", Description="Free breakfast", Definition="The student participates in the free breakfast food service program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("866b7b13-4a8c-4a80-b8cc-6c8960c64537"), Code="FreeLunch", Description="Free lunch", Definition="The student participates in the free lunch  food service program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("8ca7ab49-d219-4f9c-9747-c0f5ae2ebb71"), Code="FreeMilk", Description="Free milk", Definition="The student participates in the Free milk food service program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("1fefefb1-75e3-4789-b75d-c44db7d3e55e"), Code="FreeSnack", Description="Free snack", Definition="The student participates in the Free snack food service program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("b9b9be0c-d264-4767-8366-bac6c4953d74"), Code="FreeSupper", Description="Free supper", Definition="The student participates in the Free supper food service program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("261f3f0a-321a-4234-ae71-7c5f340f720c"), Code="FullPriceBreakfast", Description="Full price breakfast", Definition="The student participates in the Full price breakfast food service program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("0955ade6-f02d-4541-8540-9490702afee4"), Code="FullPriceLunch", Description="Full price lunch", Definition="The student participates in the Full price lunch food service program.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("2327ebab-eae2-4a84-92eb-e6e938580c41"), Code="FullPriceMilk", Description="Full price milk", Definition="The student participates in the Full price milk food service program.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("f655d975-dcdf-47b2-a3f3-79b54be42540"), Code="FullPriceSnack", Description="Full price snack", Definition="The student participates in the Full price snack food service program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("1a916bc0-53da-4ae3-80aa-1dec9e325b5b"), Code="FullPriceSupper", Description="Full price supper", Definition="The student participates in the Full price supper food service program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("9211bea3-24ea-40ec-9b7b-db90f2e3895a"), Code="ReducedPriceBreakfast", Description="Reduced price breakfast", Definition="The student participates in the Reduced price breakfast food service program.", SortOrder=Convert.ToDecimal("11.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("67dc2cc4-52b8-4ffe-8ea8-2c466cb973b1"), Code="ReducedPriceLunch", Description="Reduced price lunch", Definition="The student participates in the Reduced price lunch food service program.", SortOrder=Convert.ToDecimal("12.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("36860ffc-83e8-408d-b4a7-1db4b4e6e9b8"), Code="ReducedPriceSnack", Description="Reduced price snack", Definition="The student participates in the Reduced price snac food service program.", SortOrder=Convert.ToDecimal("13.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("470e06c0-1d81-449e-90cf-4667881e09e4"), Code="ReducedPriceSupper", Description="Reduced price supper", Definition="The student participates in the Reduced price supper food service program.", SortOrder=Convert.ToDecimal("14.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("c8aa09ce-3a4a-452a-a8ce-bb00d2f9e3d8"), Code="Other", Description="Other", Definition="The student participates in a category of the food service program not yet defined in CEDS.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The RefFoodServiceParticipation Pick List
         /// </summary>
        public static List<RefFoodServiceParticipation> RefFoodServiceParticipationPickList = new List<RefFoodServiceParticipation>
        {
            new RefFoodServiceParticipation { Id=Guid.Parse("00c05187-b409-4d8b-9f3c-9a11e6161a19"), Code="FreeBreakfast", Description="Free breakfast", SortOrder=Convert.ToDecimal("1.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("866b7b13-4a8c-4a80-b8cc-6c8960c64537"), Code="FreeLunch", Description="Free lunch", SortOrder=Convert.ToDecimal("2.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("8ca7ab49-d219-4f9c-9747-c0f5ae2ebb71"), Code="FreeMilk", Description="Free milk", SortOrder=Convert.ToDecimal("3.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("1fefefb1-75e3-4789-b75d-c44db7d3e55e"), Code="FreeSnack", Description="Free snack", SortOrder=Convert.ToDecimal("4.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("b9b9be0c-d264-4767-8366-bac6c4953d74"), Code="FreeSupper", Description="Free supper", SortOrder=Convert.ToDecimal("5.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("261f3f0a-321a-4234-ae71-7c5f340f720c"), Code="FullPriceBreakfast", Description="Full price breakfast", SortOrder=Convert.ToDecimal("6.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("0955ade6-f02d-4541-8540-9490702afee4"), Code="FullPriceLunch", Description="Full price lunch", SortOrder=Convert.ToDecimal("7.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("2327ebab-eae2-4a84-92eb-e6e938580c41"), Code="FullPriceMilk", Description="Full price milk", SortOrder=Convert.ToDecimal("8.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("f655d975-dcdf-47b2-a3f3-79b54be42540"), Code="FullPriceSnack", Description="Full price snack", SortOrder=Convert.ToDecimal("9.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("1a916bc0-53da-4ae3-80aa-1dec9e325b5b"), Code="FullPriceSupper", Description="Full price supper", SortOrder=Convert.ToDecimal("10.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("9211bea3-24ea-40ec-9b7b-db90f2e3895a"), Code="ReducedPriceBreakfast", Description="Reduced price breakfast", SortOrder=Convert.ToDecimal("11.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("67dc2cc4-52b8-4ffe-8ea8-2c466cb973b1"), Code="ReducedPriceLunch", Description="Reduced price lunch", SortOrder=Convert.ToDecimal("12.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("36860ffc-83e8-408d-b4a7-1db4b4e6e9b8"), Code="ReducedPriceSnack", Description="Reduced price snack", SortOrder=Convert.ToDecimal("13.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("470e06c0-1d81-449e-90cf-4667881e09e4"), Code="ReducedPriceSupper", Description="Reduced price supper", SortOrder=Convert.ToDecimal("14.00") },
            new RefFoodServiceParticipation { Id=Guid.Parse("c8aa09ce-3a4a-452a-a8ce-bb00d2f9e3d8"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
