//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingSecuritySystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingSecuritySystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingSecuritySystemType"> List
         /// </summary>
        public static List<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypeList = new List<RefBuildingSecuritySystemType>
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("faa61483-8584-4b19-9480-c48e6ac10f96"), Code="02508", Description="Card access control system", Definition="Card access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("62f1fe19-b3de-4447-91e5-3bc438a17699"), Code="02507", Description="Intrusion detection system", Definition="Intrusion detection system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("33b95bf4-bb19-4a00-ab73-f28e16a6dced"), Code="02509", Description="Keypad access control system", Definition="Keypad access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("246ed5a5-28df-4fcf-a83f-421c9ddb12dc"), Code="02510", Description="Metal detector", Definition="Metal detector is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("c00f6fd9-e165-4eae-94ed-3ec132659117"), Code="02499", Description="Video", Definition="Video is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("0b2ea169-3d7c-415a-b87b-92debb06296c"), Code="09999", Description="Other", Definition="Other is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingSecuritySystemType Pick List
         /// </summary>
        public static List<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypePickList = new List<RefBuildingSecuritySystemType>
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("faa61483-8584-4b19-9480-c48e6ac10f96"), Code="02508", Description="Card access control system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("62f1fe19-b3de-4447-91e5-3bc438a17699"), Code="02507", Description="Intrusion detection system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("33b95bf4-bb19-4a00-ab73-f28e16a6dced"), Code="02509", Description="Keypad access control system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("246ed5a5-28df-4fcf-a83f-421c9ddb12dc"), Code="02510", Description="Metal detector", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("c00f6fd9-e165-4eae-94ed-3ec132659117"), Code="02499", Description="Video", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("0b2ea169-3d7c-415a-b87b-92debb06296c"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
