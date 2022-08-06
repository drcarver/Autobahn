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
        public static List<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypeList = new List<RefBuildingMechanicalConveyingSystemType>
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("a3ed0739-cfd2-4d0a-bc3a-28e2ae23ce05"), Code="02516", Description="Elevator", Definition="Elevator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("14378e9b-81ef-4121-8230-bed3df6339b5"), Code="02517", Description="Escalator", Definition="Escalator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("b9ca1fa1-4dbe-4ce7-b01b-5ec95579e32a"), Code="13593", Description="Lift", Definition="Lift is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("82e71335-7f57-44b7-9504-6cf60c44bf35"), Code="13594", Description="Moving Walk", Definition="Moving Walk is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("510064f2-9200-42ae-b83b-3de3408ad077"), Code="13595", Description="Other conveying system", Definition="Other conveying system is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefBuildingMechanicalConveyingSystemType Pick List
         /// </summary>
        public static List<RefBuildingMechanicalConveyingSystemType> RefBuildingMechanicalConveyingSystemTypePickList = new List<RefBuildingMechanicalConveyingSystemType>
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("a3ed0739-cfd2-4d0a-bc3a-28e2ae23ce05"), Code="02516", Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("14378e9b-81ef-4121-8230-bed3df6339b5"), Code="02517", Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("b9ca1fa1-4dbe-4ce7-b01b-5ec95579e32a"), Code="13593", Description="Lift", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("82e71335-7f57-44b7-9504-6cf60c44bf35"), Code="13594", Description="Moving Walk", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("510064f2-9200-42ae-b83b-3de3408ad077"), Code="13595", Description="Other conveying system", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
