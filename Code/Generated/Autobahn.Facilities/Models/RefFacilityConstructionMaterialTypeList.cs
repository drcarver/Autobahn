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
        /// The complete <see cref="RefFacilityConstructionMaterialTypeModel"> List
         /// </summary>
        public static List<RefFacilityConstructionMaterialTypeModel> RefFacilityConstructionMaterialTypeList = new List<RefFacilityConstructionMaterialTypeModel>
        {
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c204800b-9073-42d6-9a94-d5482152dc14"), Code="02430", Description="Adobe", Definition="Adobe is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("e1ef6497-0584-488f-9980-b6fbd45799cf"), Code="02428", Description="Aluminum", Definition="Aluminum is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("3d703f3b-9d65-43ee-b1cc-be17d9f66e5d"), Code="02424", Description="Block", Definition="Block is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("24885a15-eaeb-4606-b1cd-097f42642a24"), Code="02422", Description="Brick", Definition="Brick is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f2c2a676-79f4-45c5-81dd-585f5dd7f248"), Code="02423", Description="Brick veneer", Definition="Brick veneer is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f526eaaf-7ff3-4683-ab06-0118123c2094"), Code="02426", Description="Concrete", Definition="Concrete is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("d54c4969-5f94-4526-81be-0bcfa6a04cee"), Code="02427", Description="Prefabricated", Definition="Prefabricated is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("146a2f34-b954-456a-8ef2-e96bf32371e6"), Code="02429", Description="Steel", Definition="Steel is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("62f44953-c954-41b0-8e6f-5586b1142513"), Code="02425", Description="Wood frame", Definition="Wood frame is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("3bc86964-0ee9-4ebe-892c-6664514b6738"), Code="09999", Description="Other", Definition="Other is specified as the primary material used for the construction of a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityConstructionMaterialType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityConstructionMaterialTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("c204800b-9073-42d6-9a94-d5482152dc14"), Description="Adobe", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("e1ef6497-0584-488f-9980-b6fbd45799cf"), Description="Aluminum", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("3d703f3b-9d65-43ee-b1cc-be17d9f66e5d"), Description="Block", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("24885a15-eaeb-4606-b1cd-097f42642a24"), Description="Brick", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f2c2a676-79f4-45c5-81dd-585f5dd7f248"), Description="Brick veneer", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("f526eaaf-7ff3-4683-ab06-0118123c2094"), Description="Concrete", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("d54c4969-5f94-4526-81be-0bcfa6a04cee"), Description="Prefabricated", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("146a2f34-b954-456a-8ef2-e96bf32371e6"), Description="Steel", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("62f44953-c954-41b0-8e6f-5586b1142513"), Description="Wood frame", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityConstructionMaterialType { Id=Guid.Parse("3bc86964-0ee9-4ebe-892c-6664514b6738"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
