//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSchoolFoodServiceProgramList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSchoolFoodServiceProgram Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSchoolFoodServiceProgramModel"> List
         /// </summary>
        public static List<RefSchoolFoodServiceProgramModel> RefSchoolFoodServiceProgramList = new List<RefSchoolFoodServiceProgramModel>
        {
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3a57803a-8e84-4985-99a6-b4a49e6df5f5"), Code="FreeBreakfast", Description="Free breakfast", Definition="The student participates in the free breakfast food service program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d2276c40-601f-42cd-8157-0f77e35e29d7"), Code="FreeLunch", Description="Free lunch", Definition="The student participates in the free lunch  food service program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("0166af81-8fbc-48b3-9c9c-506938be1f73"), Code="FreeMilk", Description="Free milk", Definition="The student participates in the Free milk food service program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d321edf0-0fcf-4bad-a4bf-ab3eab8a2a79"), Code="FreeSnack", Description="Free snack", Definition="The student participates in the Free snack food service program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("e15b150d-c401-4bc2-8b57-81ad677c150b"), Code="FreeSupper", Description="Free supper", Definition="The student participates in the Free supper food service program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("64085870-d470-4061-ad07-bfc1f8d143e1"), Code="FullPriceBreakfast", Description="Full price breakfast", Definition="The student participates in the Full price breakfast food service program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d656025e-1b14-4d9a-956f-129d37ced3ff"), Code="FullPriceLunch", Description="Full price lunch", Definition="The student participates in the Full price lunch food service program.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("a178d108-6fcf-447a-b2eb-7086cf2de4e4"), Code="FullPriceMilk", Description="Full price milk", Definition="The student participates in the Full price milk food service program.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("b3532de3-7ab1-4ba5-92d3-8ba1ed48bf36"), Code="FullPriceSnack", Description="Full price snack", Definition="The student participates in the Full price snack food service program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("76c6f952-2b7f-45ba-9330-7a755f67b67f"), Code="FullPriceSupper", Description="Full price supper", Definition="The student participates in the Full price supper food service program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("2c650635-3edc-401e-b1d0-74e2c08f4414"), Code="ReducedPriceBreakfast", Description="Reduced price breakfast", Definition="The student participates in the Reduced price breakfast food service program.", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("ebae0810-9403-4416-9266-6a8a767bdd7f"), Code="ReducedPriceLunch", Description="Reduced price lunch", Definition="The student participates in the Reduced price lunch food service program.", SortOrder=Convert.ToDecimal("12.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3e463d2b-aec7-4fb1-8706-f8f2dd41015f"), Code="ReducedPriceSnack", Description="Reduced price snack", Definition="The student participates in the Reduced price snac food service program.", SortOrder=Convert.ToDecimal("13.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("2398e788-4b95-4e56-9271-bdde41649dc2"), Code="ReducedPriceSupper", Description="Reduced price supper", Definition="The student participates in the Reduced price supper food service program.", SortOrder=Convert.ToDecimal("14.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3e78198c-8e00-44f3-af3a-7946a50e1cfb"), Code="Other", Description="Other", Definition="The student participates in a category of the food service program not yet defined in CEDS.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The Reference RefSchoolFoodServiceProgram Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSchoolFoodServiceProgramViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3a57803a-8e84-4985-99a6-b4a49e6df5f5"), Description="Free breakfast", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d2276c40-601f-42cd-8157-0f77e35e29d7"), Description="Free lunch", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("0166af81-8fbc-48b3-9c9c-506938be1f73"), Description="Free milk", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d321edf0-0fcf-4bad-a4bf-ab3eab8a2a79"), Description="Free snack", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("e15b150d-c401-4bc2-8b57-81ad677c150b"), Description="Free supper", SortOrder=Convert.ToDecimal("5.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("64085870-d470-4061-ad07-bfc1f8d143e1"), Description="Full price breakfast", SortOrder=Convert.ToDecimal("6.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("d656025e-1b14-4d9a-956f-129d37ced3ff"), Description="Full price lunch", SortOrder=Convert.ToDecimal("7.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("a178d108-6fcf-447a-b2eb-7086cf2de4e4"), Description="Full price milk", SortOrder=Convert.ToDecimal("8.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("b3532de3-7ab1-4ba5-92d3-8ba1ed48bf36"), Description="Full price snack", SortOrder=Convert.ToDecimal("9.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("76c6f952-2b7f-45ba-9330-7a755f67b67f"), Description="Full price supper", SortOrder=Convert.ToDecimal("10.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("2c650635-3edc-401e-b1d0-74e2c08f4414"), Description="Reduced price breakfast", SortOrder=Convert.ToDecimal("11.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("ebae0810-9403-4416-9266-6a8a767bdd7f"), Description="Reduced price lunch", SortOrder=Convert.ToDecimal("12.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3e463d2b-aec7-4fb1-8706-f8f2dd41015f"), Description="Reduced price snack", SortOrder=Convert.ToDecimal("13.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("2398e788-4b95-4e56-9271-bdde41649dc2"), Description="Reduced price supper", SortOrder=Convert.ToDecimal("14.00") },
            new RefSchoolFoodServiceProgram { Id=Guid.Parse("3e78198c-8e00-44f3-af3a-7946a50e1cfb"), Description="Other", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
