//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingElectricalSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingElectricalSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingElectricalSystemType"> List
         /// </summary>
        public static List<RefBuildingElectricalSystemType> RefBuildingElectricalSystemTypeList = new List<RefBuildingElectricalSystemType>
        {
            new RefBuildingElectricalSystemType { Id=Guid.Parse("7f4c159e-a61e-47d3-99b9-69a562760bdf"), Code="02476", Description="Circuit breakers", Definition="Circuit breakers is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("0e2d03c1-96e9-4360-a3dd-44ba70c6cdac"), Code="13570", Description="Communications and security", Definition="Communications and security is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("44f41eef-06b8-427e-9e58-da4333b2b456"), Code="02473", Description="Electrical distribution", Definition="Electrical distribution is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("e5335a1d-a861-474d-8b66-c7c4bcb6911f"), Code="02475", Description="Electrical interface", Definition="Electrical interface is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("dbca74d3-6b62-4245-aac6-ba3aaa4d7e27"), Code="13571", Description="Electrical service and distribution", Definition="Electrical service and distribution is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("33c5a5c0-ae73-4f94-a858-c2f098b20a90"), Code="02472", Description="Electrical supply", Definition="Electrical supply is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("cd68cee3-747a-4f12-82af-5ea527dd0147"), Code="02474", Description="Emergency generator", Definition="Emergency generator is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("91096f63-aa76-4a16-afa1-3d38d310c36a"), Code="13572", Description="Lighting and branch wiring", Definition="Lighting and branch wiring is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("f98c343e-1402-4b08-9bb4-a773553498e8"), Code="09999", Description="Other", Definition="Other is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingElectricalSystemType Pick List
         /// </summary>
        public static List<RefBuildingElectricalSystemType> RefBuildingElectricalSystemTypePickList = new List<RefBuildingElectricalSystemType>
        {
            new RefBuildingElectricalSystemType { Id=Guid.Parse("7f4c159e-a61e-47d3-99b9-69a562760bdf"), Code="02476", Description="Circuit breakers", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("0e2d03c1-96e9-4360-a3dd-44ba70c6cdac"), Code="13570", Description="Communications and security", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("44f41eef-06b8-427e-9e58-da4333b2b456"), Code="02473", Description="Electrical distribution", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("e5335a1d-a861-474d-8b66-c7c4bcb6911f"), Code="02475", Description="Electrical interface", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("dbca74d3-6b62-4245-aac6-ba3aaa4d7e27"), Code="13571", Description="Electrical service and distribution", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("33c5a5c0-ae73-4f94-a858-c2f098b20a90"), Code="02472", Description="Electrical supply", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("cd68cee3-747a-4f12-82af-5ea527dd0147"), Code="02474", Description="Emergency generator", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("91096f63-aa76-4a16-afa1-3d38d310c36a"), Code="13572", Description="Lighting and branch wiring", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("f98c343e-1402-4b08-9bb4-a773553498e8"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
