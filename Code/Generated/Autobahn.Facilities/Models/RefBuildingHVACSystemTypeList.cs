//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingHVACSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingHVACSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingHVACSystemType"> List
         /// </summary>
        public static List<RefBuildingHVACSystemType> RefBuildingHVACSystemTypeList = new List<RefBuildingHVACSystemType> =
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("d4234ce6-db8d-4236-9529-ddbfd9561664"), Code="Air distribution system is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13585", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("3a2439c9-5521-46a3-8b47-ac7a3dad0351"), Code="Controls and instrumentation is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13586", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a783318c-7c60-47a0-8944-f0ad69e2197d"), Code="Cooling generation systems is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13587", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("70dbdaa9-d371-4eee-b366-aea2c41da7c7"), Code="Energy supply is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13588", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("cd040f00-77f7-4a7d-b528-643a155e3884"), Code="Heat generating system is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13589", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("945f03c4-5a47-4d0c-a652-1afa2c705b2f"), Code="Other HVAC systems and equipment is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13590", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("eede1971-dc0e-4475-8b43-64e721d187da"), Code="Systems testing and balancing is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13591", Definition="", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("c949af4c-e9b7-4527-a795-e62a6227dc9e"), Code="Terminal and package units is specified as the building service system that provides for heating, ventilation and air-conditioning.", Description="13592", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingHVACSystemType Pick List
         /// </summary>
        public static List<RefBuildingHVACSystemType> RefBuildingHVACSystemTypePickList = new List<RefBuildingHVACSystemType> =
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("d4234ce6-db8d-4236-9529-ddbfd9561664"), Code="Air distribution system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("3a2439c9-5521-46a3-8b47-ac7a3dad0351"), Code="Controls and instrumentation is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a783318c-7c60-47a0-8944-f0ad69e2197d"), Code="Cooling generation systems is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("70dbdaa9-d371-4eee-b366-aea2c41da7c7"), Code="Energy supply is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("cd040f00-77f7-4a7d-b528-643a155e3884"), Code="Heat generating system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("945f03c4-5a47-4d0c-a652-1afa2c705b2f"), Code="Other HVAC systems and equipment is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("eede1971-dc0e-4475-8b43-64e721d187da"), Code="Systems testing and balancing is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
            new RefBuildingHVACSystemType { Id=Guid.Parse("c949af4c-e9b7-4527-a795-e62a6227dc9e"), Code="Terminal and package units is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=0 },
       };
   }
}
