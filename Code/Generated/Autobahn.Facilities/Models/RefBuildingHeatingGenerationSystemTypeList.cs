//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingHeatingGenerationSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingHeatingGenerationSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingHeatingGenerationSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingHeatingGenerationSystemTypeModel> RefBuildingHeatingGenerationSystemTypeList = new List<RefBuildingHeatingGenerationSystemTypeModel>
        {
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("ebecbd29-771b-4dd2-aaa5-ea8071c652a5"), Code="02482", Description="Central duct system", Definition="Central duct system is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("e4a627be-0eba-4330-8840-f57ae6a58e68"), Code="02485", Description="Displacement ventilation", Definition="Displacement ventilation is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("dd04c180-997e-4ccd-89a0-4066265aa765"), Code="02484", Description="Forced air", Definition="Forced air is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("82093326-9d39-4f69-9989-f917f34bfbea"), Code="02479", Description="Heat pump", Definition="Heat pump is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("99ba39cb-f4b2-4eff-a791-826daba6748b"), Code="02478", Description="Hot water radiator", Definition="Hot water radiator is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("35d1c028-3347-4fca-b781-68232d4db54f"), Code="02483", Description="Open plenum system", Definition="Open plenum system is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("c529efa7-016f-4ec3-b147-845176162802"), Code="02477", Description="Steam radiator", Definition="Steam radiator is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("54413034-335b-423d-997f-6b402cbae4ab"), Code="02481", Description="Unit heaters/baseboard heaters", Definition="Unit heaters/baseboard heaters is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d1e62e47-8baa-474e-a1d2-382bd49c591c"), Code="02480", Description="Unit ventilators", Definition="Unit ventilators is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("0dfa19f3-ce4a-4e1b-a21c-c8f430d6ecdf"), Code="09999", Description="Other", Definition="Other is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingHeatingGenerationSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingHeatingGenerationSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("ebecbd29-771b-4dd2-aaa5-ea8071c652a5"), Description="Central duct system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("e4a627be-0eba-4330-8840-f57ae6a58e68"), Description="Displacement ventilation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("dd04c180-997e-4ccd-89a0-4066265aa765"), Description="Forced air", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("82093326-9d39-4f69-9989-f917f34bfbea"), Description="Heat pump", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("99ba39cb-f4b2-4eff-a791-826daba6748b"), Description="Hot water radiator", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("35d1c028-3347-4fca-b781-68232d4db54f"), Description="Open plenum system", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("c529efa7-016f-4ec3-b147-845176162802"), Description="Steam radiator", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("54413034-335b-423d-997f-6b402cbae4ab"), Description="Unit heaters/baseboard heaters", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d1e62e47-8baa-474e-a1d2-382bd49c591c"), Description="Unit ventilators", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("0dfa19f3-ce4a-4e1b-a21c-c8f430d6ecdf"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
