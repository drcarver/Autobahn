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
        /// The complete <see cref="RefBuildingCirculationSpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingCirculationSpaceTypeModel> RefBuildingCirculationSpaceTypeList = new List<RefBuildingCirculationSpaceTypeModel>
        {
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("86645c68-6558-4d1f-a7c3-a046c4f2eb37"), Code="02516", Description="Elevator", Definition="Elevator is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("323857e3-379a-4a2e-9c71-8cf24bbc19d9"), Code="02517", Description="Escalator", Definition="Escalator is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("716fb88f-7d3c-4607-9291-2af761e76b59"), Code="02774", Description="Hallway", Definition="Hallway is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("922f0194-243b-43d2-9082-86c76b186f06"), Code="13619", Description="Handicap Access Ramp", Definition="Handicap access ramp is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("70b25228-afbc-49a5-8442-559bd022eab8"), Code="13593", Description="Lift", Definition="Lift is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("dfb1a80b-1b33-4117-a74f-2cfa4948e7b1"), Code="02776", Description="Lobby", Definition="Lobby is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("820153af-96cf-48d0-a223-13860be65911"), Code="13594", Description="Moving Walk", Definition="Moving walk is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("ccae0790-0220-4cdd-9b9b-0362aa206a01"), Code="02775", Description="Stairway", Definition="Stairway is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b21691f9-ff68-4dda-9a2b-176c929da9cb"), Code="09999", Description="Other", Definition="Other is specified as a space designed to enable people to move within the building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCirculationSpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCirculationSpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("86645c68-6558-4d1f-a7c3-a046c4f2eb37"), Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("323857e3-379a-4a2e-9c71-8cf24bbc19d9"), Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("716fb88f-7d3c-4607-9291-2af761e76b59"), Description="Hallway", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("922f0194-243b-43d2-9082-86c76b186f06"), Description="Handicap Access Ramp", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("70b25228-afbc-49a5-8442-559bd022eab8"), Description="Lift", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("dfb1a80b-1b33-4117-a74f-2cfa4948e7b1"), Description="Lobby", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("820153af-96cf-48d0-a223-13860be65911"), Description="Moving Walk", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("ccae0790-0220-4cdd-9b9b-0362aa206a01"), Description="Stairway", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCirculationSpaceType { Id=Guid.Parse("b21691f9-ff68-4dda-9a2b-176c929da9cb"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
