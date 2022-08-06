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
        /// The complete <see cref="RefBuildingHeatingGenerationSystemType"> List
         /// </summary>
        public static List<RefBuildingHeatingGenerationSystemType> RefBuildingHeatingGenerationSystemTypeList = new List<RefBuildingHeatingGenerationSystemType>
        {
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d206315b-2994-4364-a3f0-b07087ebffb5"), Code="02482", Description="Central duct system", Definition="Central duct system is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("9e81a414-0d5b-448b-bce8-4116c551873e"), Code="02485", Description="Displacement ventilation", Definition="Displacement ventilation is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d32b0cd4-cd36-420a-bdff-3312b8254a70"), Code="02484", Description="Forced air", Definition="Forced air is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("aa6dbfc9-02b1-4164-b140-d53910da61fa"), Code="02479", Description="Heat pump", Definition="Heat pump is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("61dd742f-ab9c-4a1a-acfe-80a47c504dca"), Code="02478", Description="Hot water radiator", Definition="Hot water radiator is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("486e902b-e313-4a40-bab7-257de09f2466"), Code="02483", Description="Open plenum system", Definition="Open plenum system is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("0d36879c-7296-4de0-90e2-5c611894e977"), Code="02477", Description="Steam radiator", Definition="Steam radiator is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("aea0b8fc-decc-4d5c-9454-719be7439422"), Code="02481", Description="Unit heaters/baseboard heaters", Definition="Unit heaters/baseboard heaters is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("62380b2a-5967-4251-ba9d-27df5e55399c"), Code="02480", Description="Unit ventilators", Definition="Unit ventilators is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("41fcecce-89d2-419c-afe9-8dc6334983c5"), Code="09999", Description="Other", Definition="Other is specified as the method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingHeatingGenerationSystemType Pick List
         /// </summary>
        public static List<RefBuildingHeatingGenerationSystemType> RefBuildingHeatingGenerationSystemTypePickList = new List<RefBuildingHeatingGenerationSystemType>
        {
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d206315b-2994-4364-a3f0-b07087ebffb5"), Code="02482", Description="Central duct system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("9e81a414-0d5b-448b-bce8-4116c551873e"), Code="02485", Description="Displacement ventilation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("d32b0cd4-cd36-420a-bdff-3312b8254a70"), Code="02484", Description="Forced air", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("aa6dbfc9-02b1-4164-b140-d53910da61fa"), Code="02479", Description="Heat pump", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("61dd742f-ab9c-4a1a-acfe-80a47c504dca"), Code="02478", Description="Hot water radiator", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("486e902b-e313-4a40-bab7-257de09f2466"), Code="02483", Description="Open plenum system", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("0d36879c-7296-4de0-90e2-5c611894e977"), Code="02477", Description="Steam radiator", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("aea0b8fc-decc-4d5c-9454-719be7439422"), Code="02481", Description="Unit heaters/baseboard heaters", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("62380b2a-5967-4251-ba9d-27df5e55399c"), Code="02480", Description="Unit ventilators", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingHeatingGenerationSystemType { Id=Guid.Parse("41fcecce-89d2-419c-afe9-8dc6334983c5"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
