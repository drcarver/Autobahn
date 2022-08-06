//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityConstructionMaterialTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityConstructionMaterialType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityConstructionMaterialType"> List
         /// </summary>
        public static List<RefFacilityConstructionMaterialType> RefFacilityConstructionMaterialTypeList = new List<RefFacilityConstructionMaterialType>
        {
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f25350b1-4870-4e2b-bb99-d5a554bffdc4"), Code="02430", Description="Adobe", Definition="Adobe is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("646c57ce-d652-42a0-bdbe-d74cd961e3e8"), Code="02428", Description="Aluminum", Definition="Aluminum is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("9e5a7adc-b605-4372-83dc-754589ffffb1"), Code="02424", Description="Block", Definition="Block is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("0577c86f-e645-4590-b99c-b83a21d713b2"), Code="02422", Description="Brick", Definition="Brick is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("21df0ba3-14da-4058-a0b7-e68ecc54ec1b"), Code="02423", Description="Brick veneer", Definition="Brick veneer is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("2ff277e5-298d-4af2-ac66-1467bd8c6133"), Code="02426", Description="Concrete", Definition="Concrete is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c24b6610-33a6-45c5-904c-3ce0ced623bd"), Code="02427", Description="Prefabricated", Definition="Prefabricated is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("cabbf06c-d75a-4d6a-ae98-d5d59677294f"), Code="02429", Description="Steel", Definition="Steel is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c47b39da-0901-49d5-aa5e-deaa4e0fd894"), Code="02425", Description="Wood frame", Definition="Wood frame is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("44463cbf-3d58-4f90-be5e-f52a16663e60"), Code="09999", Description="Other", Definition="Other is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityConstructionMaterialType Pick List
         /// </summary>
        public static List<RefFacilityConstructionMaterialType> RefFacilityConstructionMaterialTypePickList = new List<RefFacilityConstructionMaterialType>
        {
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f25350b1-4870-4e2b-bb99-d5a554bffdc4"), Code="02430", Description="Adobe", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("646c57ce-d652-42a0-bdbe-d74cd961e3e8"), Code="02428", Description="Aluminum", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("9e5a7adc-b605-4372-83dc-754589ffffb1"), Code="02424", Description="Block", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("0577c86f-e645-4590-b99c-b83a21d713b2"), Code="02422", Description="Brick", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("21df0ba3-14da-4058-a0b7-e68ecc54ec1b"), Code="02423", Description="Brick veneer", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("2ff277e5-298d-4af2-ac66-1467bd8c6133"), Code="02426", Description="Concrete", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c24b6610-33a6-45c5-904c-3ce0ced623bd"), Code="02427", Description="Prefabricated", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("cabbf06c-d75a-4d6a-ae98-d5d59677294f"), Code="02429", Description="Steel", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c47b39da-0901-49d5-aa5e-deaa4e0fd894"), Code="02425", Description="Wood frame", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("44463cbf-3d58-4f90-be5e-f52a16663e60"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
