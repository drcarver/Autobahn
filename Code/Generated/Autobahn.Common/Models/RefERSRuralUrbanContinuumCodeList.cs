//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefERSRuralUrbanContinuumCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefERSRuralUrbanContinuumCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefERSRuralUrbanContinuumCodeModel"> List
         /// </summary>
        public static List<RefERSRuralUrbanContinuumCodeModel> RefERSRuralUrbanContinuumCodeList = new List<RefERSRuralUrbanContinuumCodeModel>
        {
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("131edbe8-2899-4b46-bcba-adab495f3cee"), Code="1", Description="Counties in metro areas of 1 million population or more", Definition="Counties in metro areas of 1 million population or more", SortOrder=Convert.ToDecimal("1.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("2f57ff15-5a8a-4159-8157-64c68f9d53ca"), Code="2", Description="Counties in metro areas of 250,000 to 1 million population", Definition="Counties in metro areas of 250,000 to 1 million population", SortOrder=Convert.ToDecimal("2.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("a4d2c315-eb45-41d0-8f96-f41c9f57b649"), Code="3", Description="Counties in metro areas of fewer than 250,000 population", Definition="Counties in metro areas of fewer than 250,000 population", SortOrder=Convert.ToDecimal("3.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("6006d9ba-1d13-4e57-9b47-aad3d30be956"), Code="4", Description="Urban population of 20,000 or more, adjacent to a metro area", Definition="Urban population of 20,000 or more, adjacent to a metro area", SortOrder=Convert.ToDecimal("4.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("61cc7ac3-0ade-4e43-8e61-bda87918b5a6"), Code="5", Description="Urban population of 20,000 or more, not adjacent to a metro area", Definition="Urban population of 20,000 or more, not adjacent to a metro area", SortOrder=Convert.ToDecimal("5.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("9902bb86-5eba-4387-b485-c88c9c5c69e1"), Code="6", Description="Urban population of 2,500 to 19,999, adjacent to a metro area", Definition="Urban population of 2,500 to 19,999, adjacent to a metro area", SortOrder=Convert.ToDecimal("6.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("ffe9da3d-da8c-42a1-a9e0-733d62ba22b4"), Code="7", Description="Urban population of 2,500 to 19,999, not adjacent to a metro area", Definition="Urban population of 2,500 to 19,999, not adjacent to a metro area", SortOrder=Convert.ToDecimal("7.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("71ecec8a-7961-4225-b38b-499b634bd36f"), Code="8", Description="Completely rural or less than 2,500 urban population, adjacent to a metro area", Definition="Completely rural or less than 2,500 urban population, adjacent to a metro area", SortOrder=Convert.ToDecimal("8.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("cce14763-4590-4492-9f8a-750ca4373f1d"), Code="9", Description="Completely rural or less than 2,500 urban population, not adjacent to a metro area", Definition="Completely rural or less than 2,500 urban population, not adjacent to a metro area", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefERSRuralUrbanContinuumCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefERSRuralUrbanContinuumCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("131edbe8-2899-4b46-bcba-adab495f3cee"), Description="Counties in metro areas of 1 million population or more", SortOrder=Convert.ToDecimal("1.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("2f57ff15-5a8a-4159-8157-64c68f9d53ca"), Description="Counties in metro areas of 250,000 to 1 million population", SortOrder=Convert.ToDecimal("2.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("a4d2c315-eb45-41d0-8f96-f41c9f57b649"), Description="Counties in metro areas of fewer than 250,000 population", SortOrder=Convert.ToDecimal("3.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("6006d9ba-1d13-4e57-9b47-aad3d30be956"), Description="Urban population of 20,000 or more, adjacent to a metro area", SortOrder=Convert.ToDecimal("4.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("61cc7ac3-0ade-4e43-8e61-bda87918b5a6"), Description="Urban population of 20,000 or more, not adjacent to a metro area", SortOrder=Convert.ToDecimal("5.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("9902bb86-5eba-4387-b485-c88c9c5c69e1"), Description="Urban population of 2,500 to 19,999, adjacent to a metro area", SortOrder=Convert.ToDecimal("6.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("ffe9da3d-da8c-42a1-a9e0-733d62ba22b4"), Description="Urban population of 2,500 to 19,999, not adjacent to a metro area", SortOrder=Convert.ToDecimal("7.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("71ecec8a-7961-4225-b38b-499b634bd36f"), Description="Completely rural or less than 2,500 urban population, adjacent to a metro area", SortOrder=Convert.ToDecimal("8.00") },
            new RefERSRuralUrbanContinuumCode { Id=Guid.Parse("cce14763-4590-4492-9f8a-750ca4373f1d"), Description="Completely rural or less than 2,500 urban population, not adjacent to a metro area", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
