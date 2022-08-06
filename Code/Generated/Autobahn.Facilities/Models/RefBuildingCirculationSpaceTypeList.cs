//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCirculationSpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCirculationSpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCirculationSpaceType"> List
         /// </summary>
        public static List<RefBuildingCirculationSpaceType> RefBuildingCirculationSpaceTypeList = new List<RefBuildingCirculationSpaceType>
        {
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("03ea20d8-2664-4590-b57b-22300be4e03d"), Code="02516", Description="Elevator", Definition="Elevator is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b1255fcf-a1b2-417b-a500-9aa2ef157edd"), Code="02517", Description="Escalator", Definition="Escalator is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("ad291e36-3a53-4808-a18e-c4bd632efb69"), Code="02774", Description="Hallway", Definition="Hallway is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("e52d44ea-2d5e-41e8-91bf-bec8eb3d5665"), Code="13619", Description="Handicap Access Ramp", Definition="Handicap access ramp is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b9ce94f9-bce5-4a75-b521-53933b11f896"), Code="13593", Description="Lift", Definition="Lift is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("d99b125f-fc33-442d-b99d-bf33b1cd917c"), Code="02776", Description="Lobby", Definition="Lobby is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("6ef4addb-2756-43e2-8fa2-b06c58185b3c"), Code="13594", Description="Moving Walk", Definition="Moving walk is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("d18e3549-983c-4807-9d09-3b1ee1184a5c"), Code="02775", Description="Stairway", Definition="Stairway is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("f8e32f2c-3b44-4b17-86e0-bef6ede07ca8"), Code="09999", Description="Other", Definition="Other is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingCirculationSpaceType Pick List
         /// </summary>
        public static List<RefBuildingCirculationSpaceType> RefBuildingCirculationSpaceTypePickList = new List<RefBuildingCirculationSpaceType>
        {
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("03ea20d8-2664-4590-b57b-22300be4e03d"), Code="02516", Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b1255fcf-a1b2-417b-a500-9aa2ef157edd"), Code="02517", Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("ad291e36-3a53-4808-a18e-c4bd632efb69"), Code="02774", Description="Hallway", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("e52d44ea-2d5e-41e8-91bf-bec8eb3d5665"), Code="13619", Description="Handicap Access Ramp", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b9ce94f9-bce5-4a75-b521-53933b11f896"), Code="13593", Description="Lift", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("d99b125f-fc33-442d-b99d-bf33b1cd917c"), Code="02776", Description="Lobby", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("6ef4addb-2756-43e2-8fa2-b06c58185b3c"), Code="13594", Description="Moving Walk", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("d18e3549-983c-4807-9d09-3b1ee1184a5c"), Code="02775", Description="Stairway", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("f8e32f2c-3b44-4b17-86e0-bef6ede07ca8"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
