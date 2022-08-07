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
        /// The complete <see cref="RefBuildingSecuritySystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingSecuritySystemTypeModel> RefBuildingSecuritySystemTypeList = new List<RefBuildingSecuritySystemTypeModel>
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("be99248f-9237-4e29-ab76-616c35d1f408"), Code="02508", Description="Card access control system", Definition="Card access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("2b2fcab9-82d5-45fe-be6f-1f68daae1491"), Code="02507", Description="Intrusion detection system", Definition="Intrusion detection system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("234fdd9a-a5ec-4bfe-a0b3-df83d0724410"), Code="02509", Description="Keypad access control system", Definition="Keypad access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("76caf335-3361-4083-9af7-48ba86ac516e"), Code="02510", Description="Metal detector", Definition="Metal detector is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("43c4334e-87a2-49d9-8697-5bc90a4cd5eb"), Code="02499", Description="Video", Definition="Video is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("60f7b541-0f57-458b-ac78-104eea4c4be4"), Code="09999", Description="Other", Definition="Other is specified as the type of system that protects the facility from intrusion.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingSecuritySystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingSecuritySystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("be99248f-9237-4e29-ab76-616c35d1f408"), Description="Card access control system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("2b2fcab9-82d5-45fe-be6f-1f68daae1491"), Description="Intrusion detection system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("234fdd9a-a5ec-4bfe-a0b3-df83d0724410"), Description="Keypad access control system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("76caf335-3361-4083-9af7-48ba86ac516e"), Description="Metal detector", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("43c4334e-87a2-49d9-8697-5bc90a4cd5eb"), Description="Video", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("60f7b541-0f57-458b-ac78-104eea4c4be4"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
