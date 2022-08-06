//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingMechanicalConveyingSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingMechanicalConveyingSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingMechanicalConveyingSystemType"> List
         /// </summary>
        public static List<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypeList = new List<RefBuildingMechanicalConveyingSystemType> =
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("3b412144-8994-4a5b-aa17-758ff4389f0c"), Code="Elevator is specified as a mechanical means for moving people and equipment within buildings.", Description="02516", Definition="", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("3d1503eb-4e5b-438e-954e-9042cf7fea47"), Code="Escalator is specified as a mechanical means for moving people and equipment within buildings.", Description="02517", Definition="", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("113fde31-bf8f-422a-9d5e-2cacbece38a8"), Code="Lift is specified as a mechanical means for moving people and equipment within buildings.", Description="13593", Definition="", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("854bcd09-2b77-4855-8228-dc1941f40e8f"), Code="Moving Walk is specified as a mechanical means for moving people and equipment within buildings.", Description="13594", Definition="", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("5fbf3361-5366-411c-85c4-b3e728418dab"), Code="Other conveying system is specified as a mechanical means for moving people and equipment within buildings.", Description="13595", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingMechanicalConveyingSystemType Pick List
         /// </summary>
        public static List<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypePickList = new List<RefBuildingMechanicalConveyingSystemType> =
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("3b412144-8994-4a5b-aa17-758ff4389f0c"), Code="Elevator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("3d1503eb-4e5b-438e-954e-9042cf7fea47"), Code="Escalator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("113fde31-bf8f-422a-9d5e-2cacbece38a8"), Code="Lift is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("854bcd09-2b77-4855-8228-dc1941f40e8f"), Code="Moving Walk is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=0 },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("5fbf3361-5366-411c-85c4-b3e728418dab"), Code="Other conveying system is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=0 },
       };
   }
}
