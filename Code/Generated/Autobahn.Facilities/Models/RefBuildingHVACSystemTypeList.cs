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
        /// The complete <see cref="RefBuildingHVACSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingHVACSystemTypeModel> RefBuildingHVACSystemTypeList = new List<RefBuildingHVACSystemTypeModel>
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("dfd1cccb-8340-4851-93d7-5ac45e4e0151"), Code="13585", Description="Air distribution system", Definition="Air distribution system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("18211003-6e07-44e9-9b08-c3edf8f0aced"), Code="13586", Description="Controls and instrumentation", Definition="Controls and instrumentation is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("ce8daf0f-c29a-4515-8266-092b571a5f5a"), Code="13587", Description="Cooling generation systems", Definition="Cooling generation systems is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("19029b1c-8eec-4536-b3ab-4f6272304f6e"), Code="13588", Description="Energy supply", Definition="Energy supply is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("47c6a22a-ede8-4819-aeaa-50d6bec75191"), Code="13589", Description="Heat generating system", Definition="Heat generating system is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("ba2bf000-e79d-494e-bfc4-fcd2481a0f16"), Code="13590", Description="Other HVAC systems and equipment", Definition="Other HVAC systems and equipment is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("6b7fe4cc-2f5d-45e9-8cc8-169b9340aa41"), Code="13591", Description="Systems testing and balancing", Definition="Systems testing and balancing is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("9f928e8e-ee07-4324-8f55-193b4644a4ca"), Code="13592", Description="Terminal and package units", Definition="Terminal and package units is specified as the building service system that provides for heating, ventilation and air-conditioning.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefBuildingHVACSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingHVACSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingHVACSystemType { Id=Guid.Parse("dfd1cccb-8340-4851-93d7-5ac45e4e0151"), Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("18211003-6e07-44e9-9b08-c3edf8f0aced"), Description="Controls and instrumentation", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("ce8daf0f-c29a-4515-8266-092b571a5f5a"), Description="Cooling generation systems", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("19029b1c-8eec-4536-b3ab-4f6272304f6e"), Description="Energy supply", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("47c6a22a-ede8-4819-aeaa-50d6bec75191"), Description="Heat generating system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("ba2bf000-e79d-494e-bfc4-fcd2481a0f16"), Description="Other HVAC systems and equipment", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("6b7fe4cc-2f5d-45e9-8cc8-169b9340aa41"), Description="Systems testing and balancing", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingHVACSystemType { Id=Guid.Parse("9f928e8e-ee07-4324-8f55-193b4644a4ca"), Description="Terminal and package units", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
