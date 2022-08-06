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
        public static List<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypeList = new List<RefBuildingVerticalTransportationSystemType>
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("8092169d-7503-4b2b-bbb3-522a7ac55ec6"), Code="02516", Description="Elevator", Definition="Elevator is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("6c145863-7daa-4999-a318-23e12c8228f3"), Code="02517", Description="Escalator", Definition="Escalator is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("62f50a09-0701-4c4b-919c-2956856f9c5c"), Code="02515", Description="Stairs", Definition="Stairs is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("41755e08-24a9-43ca-957c-74dae3070a4b"), Code="09999", Description="Other", Definition="Other is specified as the type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingVerticalTransportationSystemType Pick List
         /// </summary>
        public static List<RefBuildingVerticalTransportationSystemType> RefBuildingVerticalTransportationSystemTypePickList = new List<RefBuildingVerticalTransportationSystemType>
        {
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("8092169d-7503-4b2b-bbb3-522a7ac55ec6"), Code="02516", Description="Elevator", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("6c145863-7daa-4999-a318-23e12c8228f3"), Code="02517", Description="Escalator", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("62f50a09-0701-4c4b-919c-2956856f9c5c"), Code="02515", Description="Stairs", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingVerticalTransportationSystemType { Id=Guid.Parse("41755e08-24a9-43ca-957c-74dae3070a4b"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
