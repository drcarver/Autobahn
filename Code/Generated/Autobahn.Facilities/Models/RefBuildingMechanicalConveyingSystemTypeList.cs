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
        /// The complete <see cref="RefBuildingMechanicalConveyingSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingMechanicalConveyingSystemTypeModel> RefBuildingMechanicalConveyingSystemTypeList = new List<RefBuildingMechanicalConveyingSystemTypeModel>
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("de68e544-8aaa-4656-9f1b-c6895df2130b"), Code="02516", Description="Elevator", Definition="Elevator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("f1bdaa86-b972-4990-9388-ea7af62f6d8c"), Code="02517", Description="Escalator", Definition="Escalator is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("86058ab8-a153-463c-b784-742681a01ebb"), Code="13593", Description="Lift", Definition="Lift is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("073401d0-699c-4fbe-95e5-ac78672f5f1d"), Code="13594", Description="Moving Walk", Definition="Moving Walk is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("848f4922-85dd-448a-8964-7c3f88d87a6b"), Code="13595", Description="Other conveying system", Definition="Other conveying system is specified as a mechanical means for moving people and equipment within buildings.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefBuildingMechanicalConveyingSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingMechanicalConveyingSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("de68e544-8aaa-4656-9f1b-c6895df2130b"), Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("f1bdaa86-b972-4990-9388-ea7af62f6d8c"), Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("86058ab8-a153-463c-b784-742681a01ebb"), Description="Lift", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("073401d0-699c-4fbe-95e5-ac78672f5f1d"), Description="Moving Walk", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingMechanicalConveyingSystemType { Id=Guid.Parse("848f4922-85dd-448a-8964-7c3f88d87a6b"), Description="Other conveying system", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
