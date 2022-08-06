//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingAirDistributionSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingAirDistributionSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingAirDistributionSystemType"> List
         /// </summary>
        public static List<RefBuildingAirDistributionSystemType> RefBuildingAirDistributionSystemTypeList = new List<RefBuildingAirDistributionSystemType>
        {
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("95125380-35af-49fc-a40b-8cc82f28bec3"), Code="02497", Description="Air handler units", Definition="Air handler units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("d642a624-9568-41bd-92ef-fca07f09b7c6"), Code="02496", Description="Both mechanical exhaust and supply units", Definition="Both mechanical exhaust and supply units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("56d7e032-b2c1-49f7-a650-5568204ebaac"), Code="02493", Description="Gravity ventilation units", Definition="Gravity ventilation units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("f8c31502-45a8-4c13-a1a1-2b1c1e1561ad"), Code="02494", Description="Mechanical exhaust units", Definition="Mechanical exhaust units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("780637d3-5c47-4cf1-a0d7-57559b73cff3"), Code="02495", Description="Mechanical supply units", Definition="Mechanical supply units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("5bbeccde-879c-4f34-b7bb-e6dd3f88bcc9"), Code="09999", Description="Other units", Definition="Other units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("724d9b97-d7cf-4067-a696-d0683e5fbc75"), Code="02492", Description="Window ventilation units", Definition="Window ventilation units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefBuildingAirDistributionSystemType Pick List
         /// </summary>
        public static List<RefBuildingAirDistributionSystemType> RefBuildingAirDistributionSystemTypePickList = new List<RefBuildingAirDistributionSystemType>
        {
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("95125380-35af-49fc-a40b-8cc82f28bec3"), Code="02497", Description="Air handler units", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("d642a624-9568-41bd-92ef-fca07f09b7c6"), Code="02496", Description="Both mechanical exhaust and supply units", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("56d7e032-b2c1-49f7-a650-5568204ebaac"), Code="02493", Description="Gravity ventilation units", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("f8c31502-45a8-4c13-a1a1-2b1c1e1561ad"), Code="02494", Description="Mechanical exhaust units", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("780637d3-5c47-4cf1-a0d7-57559b73cff3"), Code="02495", Description="Mechanical supply units", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("5bbeccde-879c-4f34-b7bb-e6dd3f88bcc9"), Code="09999", Description="Other units", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("724d9b97-d7cf-4067-a696-d0683e5fbc75"), Code="02492", Description="Window ventilation units", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
