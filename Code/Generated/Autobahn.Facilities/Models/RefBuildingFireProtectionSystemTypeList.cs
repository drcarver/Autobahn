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
        /// The complete <see cref="RefBuildingFireProtectionSystemType"> List
         /// </summary>
        public static List<RefBuildingFireProtectionSystemType> RefBuildingFireProtectionSystemTypeList = new List<RefBuildingFireProtectionSystemType>
        {
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("ca3aa8c1-9134-471f-9305-3354ff3cd029"), Code="02513", Description="Alarms", Definition="Alarms is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("d7b521bf-b87c-41f8-8cea-e9929ccb457b"), Code="02511", Description="Automatic sprinkler", Definition="Automatic sprinkler is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("f8df3198-2eaf-41ff-96a7-3306fadb73d7"), Code="13579", Description="Fire protection specialists", Definition="Fire protection specialists is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("71016019-ea43-41d1-a4a7-5c46510046f0"), Code="02512", Description="Fire pump/extinguishers", Definition="Fire pump/extinguishers is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("7ff970b9-6d6d-4182-8ec7-9256e44de9a4"), Code="02514", Description="Kitchen fire suppressor system", Definition="Kitchen fire suppressor system is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("c8ace21e-a455-407a-a637-c93f62611ed7"), Code="13580", Description="Other fire protection systems", Definition="Other fire protection systems is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("864e1f32-6d32-4e37-82f7-cae94a4c1d09"), Code="13581", Description="Standpipes", Definition="Standpipes is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("86bfb497-63b4-4023-b5f3-57d627a3684a"), Code="09999", Description="Other", Definition="Other is specified as the type of system that protects the facility against fire.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingFireProtectionSystemType Pick List
         /// </summary>
        public static List<RefBuildingFireProtectionSystemType> RefBuildingFireProtectionSystemTypePickList = new List<RefBuildingFireProtectionSystemType>
        {
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("ca3aa8c1-9134-471f-9305-3354ff3cd029"), Code="02513", Description="Alarms", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("d7b521bf-b87c-41f8-8cea-e9929ccb457b"), Code="02511", Description="Automatic sprinkler", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("f8df3198-2eaf-41ff-96a7-3306fadb73d7"), Code="13579", Description="Fire protection specialists", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("71016019-ea43-41d1-a4a7-5c46510046f0"), Code="02512", Description="Fire pump/extinguishers", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("7ff970b9-6d6d-4182-8ec7-9256e44de9a4"), Code="02514", Description="Kitchen fire suppressor system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("c8ace21e-a455-407a-a637-c93f62611ed7"), Code="13580", Description="Other fire protection systems", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("864e1f32-6d32-4e37-82f7-cae94a4c1d09"), Code="13581", Description="Standpipes", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingFireProtectionSystemType { Id=Guid.Parse("86bfb497-63b4-4023-b5f3-57d627a3684a"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
