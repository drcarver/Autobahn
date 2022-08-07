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
        /// The complete <see cref="RefBuildingSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingSystemTypeModel> RefBuildingSystemTypeList = new List<RefBuildingSystemTypeModel>
        {
            new RefBuildingSystemType { Id=Guid.Parse("85b4320e-6468-4c60-924f-bf4b575141bf"), Code="02455", Description="Air distribution system", Definition="The primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSystemType { Id=Guid.Parse("934df413-3882-4f6d-96ac-6e6cbac4a346"), Code="02456", Description="Communications system", Definition="The types of systems, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSystemType { Id=Guid.Parse("02604967-e407-4d8e-8169-a411654e48c4"), Code="02454", Description="Cooling generation system", Definition="The type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSystemType { Id=Guid.Parse("cd0f40dc-d661-4e1c-98bb-fb5787b31cdb"), Code="02452", Description="Electrical system", Definition="The type of system that collects and distributes electricity throughout the building or site.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSystemType { Id=Guid.Parse("4ed5f3df-6480-4d50-8230-e2dddeb107f5"), Code="02459", Description="Fire protection system", Definition="The type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSystemType { Id=Guid.Parse("13c5851e-bbee-49a5-8b31-674d1ac29ac4"), Code="02453", Description="Heating generation system", Definition="The method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSystemType { Id=Guid.Parse("43a202e4-7849-43f0-8fd3-7234d5eec422"), Code="02460", Description="Mechanical system", Definition="The major manufactured systems required to operated in a building to achieve thermal and air quality comfort.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSystemType { Id=Guid.Parse("69f45e68-d6ba-42ae-8ac7-410801d382e3"), Code="02451", Description="Plumbing system", Definition="The component of an on-site system for supplying, eliminating, and treating water.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSystemType { Id=Guid.Parse("217a489b-f936-4103-99ba-f96aa7dae24e"), Code="02458", Description="Security system", Definition="The type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSystemType { Id=Guid.Parse("fe32d99e-3498-48f3-8b1c-85c81713e6cd"), Code="02457", Description="Technology wiring", Definition="The means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSystemType { Id=Guid.Parse("d87d37ad-3c84-4bfb-94b7-07bd9aa343ab"), Code="02461", Description="Vertical transportation", Definition="The type of system used to convey persons or freight between floors.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefBuildingSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingSystemType { Id=Guid.Parse("85b4320e-6468-4c60-924f-bf4b575141bf"), Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSystemType { Id=Guid.Parse("934df413-3882-4f6d-96ac-6e6cbac4a346"), Description="Communications system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSystemType { Id=Guid.Parse("02604967-e407-4d8e-8169-a411654e48c4"), Description="Cooling generation system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSystemType { Id=Guid.Parse("cd0f40dc-d661-4e1c-98bb-fb5787b31cdb"), Description="Electrical system", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSystemType { Id=Guid.Parse("4ed5f3df-6480-4d50-8230-e2dddeb107f5"), Description="Fire protection system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSystemType { Id=Guid.Parse("13c5851e-bbee-49a5-8b31-674d1ac29ac4"), Description="Heating generation system", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingSystemType { Id=Guid.Parse("43a202e4-7849-43f0-8fd3-7234d5eec422"), Description="Mechanical system", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingSystemType { Id=Guid.Parse("69f45e68-d6ba-42ae-8ac7-410801d382e3"), Description="Plumbing system", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingSystemType { Id=Guid.Parse("217a489b-f936-4103-99ba-f96aa7dae24e"), Description="Security system", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingSystemType { Id=Guid.Parse("fe32d99e-3498-48f3-8b1c-85c81713e6cd"), Description="Technology wiring", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingSystemType { Id=Guid.Parse("d87d37ad-3c84-4bfb-94b7-07bd9aa343ab"), Description="Vertical transportation", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
