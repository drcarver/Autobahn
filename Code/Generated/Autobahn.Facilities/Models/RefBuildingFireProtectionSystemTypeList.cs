//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingFireProtectionSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingFireProtectionSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingFireProtectionSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingFireProtectionSystemTypeModel> RefBuildingFireProtectionSystemTypeList = new List<RefBuildingFireProtectionSystemTypeModel>
        {
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("bc0c3a9f-16a3-4d5c-8376-da850a97273e"), Code="02513", Description="Alarms", Definition="Alarms is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("2b57fe3d-8326-4e1d-bcc6-d87784ef6d3e"), Code="02511", Description="Automatic sprinkler", Definition="Automatic sprinkler is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("d3cebcac-6056-4ad3-85d8-17969242ce0e"), Code="13579", Description="Fire protection specialists", Definition="Fire protection specialists is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("042bec44-ca5f-40d6-aeae-598791f21dbc"), Code="02512", Description="Fire pump/extinguishers", Definition="Fire pump/extinguishers is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("ca71acfb-4280-4e94-8e26-88819f6286f0"), Code="02514", Description="Kitchen fire suppressor system", Definition="Kitchen fire suppressor system is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("1b73da2a-07af-4f56-9776-30b83d1a6042"), Code="13580", Description="Other fire protection systems", Definition="Other fire protection systems is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("81453607-fe34-47df-a138-2a395826f41d"), Code="13581", Description="Standpipes", Definition="Standpipes is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("0262386b-5877-4698-b28a-5db78f8d4aa3"), Code="09999", Description="Other", Definition="Other is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingFireProtectionSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingFireProtectionSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("bc0c3a9f-16a3-4d5c-8376-da850a97273e"), Description="Alarms", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("2b57fe3d-8326-4e1d-bcc6-d87784ef6d3e"), Description="Automatic sprinkler", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("d3cebcac-6056-4ad3-85d8-17969242ce0e"), Description="Fire protection specialists", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("042bec44-ca5f-40d6-aeae-598791f21dbc"), Description="Fire pump/extinguishers", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("ca71acfb-4280-4e94-8e26-88819f6286f0"), Description="Kitchen fire suppressor system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("1b73da2a-07af-4f56-9776-30b83d1a6042"), Description="Other fire protection systems", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("81453607-fe34-47df-a138-2a395826f41d"), Description="Standpipes", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("0262386b-5877-4698-b28a-5db78f8d4aa3"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
