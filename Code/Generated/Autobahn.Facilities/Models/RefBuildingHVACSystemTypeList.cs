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
        public static List<RefBuildingHVACSystemType> RefBuildingHVACSystemTypeList = new List<RefBuildingHVACSystemType>
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("4e9bb5f2-0a8b-4d02-a1f9-b0a1cc473296"), Code="13585", Description="Air distribution system", Definition="Air distribution system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("5719b295-46db-42ba-9be7-092a629e2a71"), Code="13586", Description="Controls and instrumentation", Definition="Controls and instrumentation is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("3c367d2a-37c9-491a-9b3f-d48006d75815"), Code="13587", Description="Cooling generation systems", Definition="Cooling generation systems is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("aa8f430b-46fd-46d5-96f0-a4285b38412f"), Code="13588", Description="Energy supply", Definition="Energy supply is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("8509b8ae-a5d1-4334-b2b9-04846d42aff9"), Code="13589", Description="Heat generating system", Definition="Heat generating system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a8532321-a57b-4bb8-999f-1822e3e2b541"), Code="13590", Description="Other HVAC systems and equipment", Definition="Other HVAC systems and equipment is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("df3920dc-c12f-4a30-a1b8-59b142a13aec"), Code="13591", Description="Systems testing and balancing", Definition="Systems testing and balancing is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a46d2d70-1ede-40b4-8c2f-ed027cd7f775"), Code="13592", Description="Terminal and package units", Definition="Terminal and package units is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefBuildingHVACSystemType Pick List
         /// </summary>
        public static List<RefBuildingHVACSystemType> RefBuildingHVACSystemTypePickList = new List<RefBuildingHVACSystemType>
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("4e9bb5f2-0a8b-4d02-a1f9-b0a1cc473296"), Code="13585", Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("5719b295-46db-42ba-9be7-092a629e2a71"), Code="13586", Description="Controls and instrumentation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("3c367d2a-37c9-491a-9b3f-d48006d75815"), Code="13587", Description="Cooling generation systems", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("aa8f430b-46fd-46d5-96f0-a4285b38412f"), Code="13588", Description="Energy supply", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("8509b8ae-a5d1-4334-b2b9-04846d42aff9"), Code="13589", Description="Heat generating system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a8532321-a57b-4bb8-999f-1822e3e2b541"), Code="13590", Description="Other HVAC systems and equipment", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("df3920dc-c12f-4a30-a1b8-59b142a13aec"), Code="13591", Description="Systems testing and balancing", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("a46d2d70-1ede-40b4-8c2f-ed027cd7f775"), Code="13592", Description="Terminal and package units", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
