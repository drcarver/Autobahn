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
        /// The complete <see cref="RefBuildingVerticalTransportationSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingVerticalTransportationSystemTypeModel> RefBuildingVerticalTransportationSystemTypeList = new List<RefBuildingVerticalTransportationSystemTypeModel>
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("33888ae5-eb5d-4919-b643-1eea50358e92"), Code="02516", Description="Elevator", Definition="Elevator is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("c95b45ea-a2ce-4cdc-9e28-ed6bc9b0ae12"), Code="02517", Description="Escalator", Definition="Escalator is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("4a217806-903e-4495-a2d6-0aab44b4aa82"), Code="02515", Description="Stairs", Definition="Stairs is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("72aa9595-f479-4c92-89ef-872e8e5e09b3"), Code="09999", Description="Other", Definition="Other is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingVerticalTransportationSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingVerticalTransportationSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("33888ae5-eb5d-4919-b643-1eea50358e92"), Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("c95b45ea-a2ce-4cdc-9e28-ed6bc9b0ae12"), Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("4a217806-903e-4495-a2d6-0aab44b4aa82"), Description="Stairs", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("72aa9595-f479-4c92-89ef-872e8e5e09b3"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
