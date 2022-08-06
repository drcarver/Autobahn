//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingSystemType"> List
         /// </summary>
        public static List<RefBuildingSystemType> RefBuildingSystemTypeList = new List<RefBuildingSystemType>
        {
            new RefBuildingSystemType { Id=Guid.Parse("e16e6216-eb0f-4b99-ae5d-353d462012f7"), Code="02455", Description="Air distribution system", Definition="The primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSystemType { Id=Guid.Parse("a15b25a8-e403-470e-b3a0-a274641b33c3"), Code="02456", Description="Communications system", Definition="The types of systems, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5138b531-9e90-4b17-8fc9-6e7e129d46c1"), Code="02454", Description="Cooling generation system", Definition="The type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5e6d09c1-9ad6-45ad-8b42-ac6a07c47e13"), Code="02452", Description="Electrical system", Definition="The type of system that collects and distributes electricity throughout the building or site.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSystemType { Id=Guid.Parse("683be153-c4d8-4f66-a311-1c8dd092a38c"), Code="02459", Description="Fire protection system", Definition="The type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5efbbe0c-1a6e-41a5-9f64-429a8e25ba19"), Code="02453", Description="Heating generation system", Definition="The method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSystemType { Id=Guid.Parse("32353e88-4d80-41b9-b655-4a0c266ec419"), Code="02460", Description="Mechanical system", Definition="The major manufactured systems required to operated in a building to achieve thermal and air quality comfort.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSystemType { Id=Guid.Parse("c0c5cb9a-9fa7-4e7d-8760-957a86d5ba87"), Code="02451", Description="Plumbing system", Definition="The component of an on-site system for supplying, eliminating, and treating water.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSystemType { Id=Guid.Parse("d4a3dc43-6453-4840-a086-b1eb20dffe8e"), Code="02458", Description="Security system", Definition="The type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSystemType { Id=Guid.Parse("e2fc5d9b-967b-482e-9335-56fd873dcb1b"), Code="02457", Description="Technology wiring", Definition="The means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSystemType { Id=Guid.Parse("9389e41f-61ab-49bc-a74e-007f5145c49b"), Code="02461", Description="Vertical transportation", Definition="The type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefBuildingSystemType Pick List
         /// </summary>
        public static List<RefBuildingSystemType> RefBuildingSystemTypePickList = new List<RefBuildingSystemType>
        {
            new RefBuildingSystemType { Id=Guid.Parse("e16e6216-eb0f-4b99-ae5d-353d462012f7"), Code="02455", Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSystemType { Id=Guid.Parse("a15b25a8-e403-470e-b3a0-a274641b33c3"), Code="02456", Description="Communications system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5138b531-9e90-4b17-8fc9-6e7e129d46c1"), Code="02454", Description="Cooling generation system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5e6d09c1-9ad6-45ad-8b42-ac6a07c47e13"), Code="02452", Description="Electrical system", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSystemType { Id=Guid.Parse("683be153-c4d8-4f66-a311-1c8dd092a38c"), Code="02459", Description="Fire protection system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSystemType { Id=Guid.Parse("5efbbe0c-1a6e-41a5-9f64-429a8e25ba19"), Code="02453", Description="Heating generation system", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSystemType { Id=Guid.Parse("32353e88-4d80-41b9-b655-4a0c266ec419"), Code="02460", Description="Mechanical system", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSystemType { Id=Guid.Parse("c0c5cb9a-9fa7-4e7d-8760-957a86d5ba87"), Code="02451", Description="Plumbing system", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSystemType { Id=Guid.Parse("d4a3dc43-6453-4840-a086-b1eb20dffe8e"), Code="02458", Description="Security system", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSystemType { Id=Guid.Parse("e2fc5d9b-967b-482e-9335-56fd873dcb1b"), Code="02457", Description="Technology wiring", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSystemType { Id=Guid.Parse("9389e41f-61ab-49bc-a74e-007f5145c49b"), Code="02461", Description="Vertical transportation", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
