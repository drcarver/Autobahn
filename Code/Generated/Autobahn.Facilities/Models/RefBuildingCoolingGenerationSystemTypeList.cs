//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCoolingGenerationSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCoolingGenerationSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCoolingGenerationSystemType"> List
         /// </summary>
        public static List<RefBuildingCoolingGenerationSystemType> RefBuildingCoolingGenerationSystemTypeList = new List<RefBuildingCoolingGenerationSystemType>
        {
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("d4d8fe50-71a5-4b1b-871d-0a223f2e168a"), Code="02490", Description="Ceiling fans or ventilation fans", Definition="Ceiling fans or ventilation fans is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("0a3347c4-9560-4bde-ac16-94f3e4bbcc9c"), Code="02486", Description="Central cooling system", Definition="Central cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("1587d2a5-ba3b-43ff-9ca3-b2a75bfdfee7"), Code="02489", Description="Combination cooling systems", Definition="Combination cooling systems is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("2ee827aa-8bc0-4eed-84ca-25c2b17b43ea"), Code="02488", Description="Individual (room) unit cooling system", Definition="Individual (room) unit cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("03a2724f-e753-45c7-ad86-86d37b214368"), Code="02487", Description="Local zone cooling system", Definition="Local zone cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("495250fd-1156-4bbc-9e6c-8e40eb6b135e"), Code="02491", Description="Natural systems", Definition="Natural systems is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("20d0ac1e-6bbd-47ec-ad87-27023048d71a"), Code="09998", Description="None", Definition="No type of mechanical systems and building designs used for cooling is specified.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("8aaf6b4f-a146-48d3-84fa-fcdd29007922"), Code="09999", Description="Other", Definition="Other is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingCoolingGenerationSystemType Pick List
         /// </summary>
        public static List<RefBuildingCoolingGenerationSystemType> RefBuildingCoolingGenerationSystemTypePickList = new List<RefBuildingCoolingGenerationSystemType>
        {
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("d4d8fe50-71a5-4b1b-871d-0a223f2e168a"), Code="02490", Description="Ceiling fans or ventilation fans", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("0a3347c4-9560-4bde-ac16-94f3e4bbcc9c"), Code="02486", Description="Central cooling system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("1587d2a5-ba3b-43ff-9ca3-b2a75bfdfee7"), Code="02489", Description="Combination cooling systems", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("2ee827aa-8bc0-4eed-84ca-25c2b17b43ea"), Code="02488", Description="Individual (room) unit cooling system", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("03a2724f-e753-45c7-ad86-86d37b214368"), Code="02487", Description="Local zone cooling system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("495250fd-1156-4bbc-9e6c-8e40eb6b135e"), Code="02491", Description="Natural systems", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("20d0ac1e-6bbd-47ec-ad87-27023048d71a"), Code="09998", Description="None", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("8aaf6b4f-a146-48d3-84fa-fcdd29007922"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
