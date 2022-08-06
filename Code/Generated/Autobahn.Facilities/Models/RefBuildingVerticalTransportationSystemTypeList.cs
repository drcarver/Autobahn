//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingVerticalTransportationSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingVerticalTransportationSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingVerticalTransportationSystemType"> List
         /// </summary>
        public static List<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypeList = new List<RefBuildingVerticalTransportationSystemType> =
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("a6254883-cd3d-470d-be77-2073291e50f7"), Code="Elevator is specified as the type of system used to convey persons or freight between floors.", Description="02516", Definition="", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("774deffe-1aae-4486-9be4-c1d78a202a60"), Code="Escalator is specified as the type of system used to convey persons or freight between floors.", Description="02517", Definition="", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("5e38dc3a-b405-459a-8fc0-67684a530c36"), Code="Stairs is specified as the type of system used to convey persons or freight between floors.", Description="02515", Definition="", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("9f46d2f7-1d68-470d-9ee9-6fc2e498d71e"), Code="Other is specified as the type of system used to convey persons or freight between floors.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingVerticalTransportationSystemType Pick List
         /// </summary>
        public static List<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypePickList = new List<RefBuildingVerticalTransportationSystemType> =
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("a6254883-cd3d-470d-be77-2073291e50f7"), Code="Elevator is specified as the type of system used to convey persons or freight between floors.", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("774deffe-1aae-4486-9be4-c1d78a202a60"), Code="Escalator is specified as the type of system used to convey persons or freight between floors.", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("5e38dc3a-b405-459a-8fc0-67684a530c36"), Code="Stairs is specified as the type of system used to convey persons or freight between floors.", SortOrder=0 },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("9f46d2f7-1d68-470d-9ee9-6fc2e498d71e"), Code="Other is specified as the type of system used to convey persons or freight between floors.", SortOrder=0 },
       };
   }
}
