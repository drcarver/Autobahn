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
        public static List<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypeList = new List<RefBuildingSecuritySystemType> =
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("e3c4095f-3ac7-411c-97d6-d5830957dfb6"), Code="Card access control system is specified as the type of system that protects the facility from intrusion.", Description="02508", Definition="", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("14304b7d-20ce-4bc3-a845-2463fa1a7737"), Code="Intrusion detection system is specified as the type of system that protects the facility from intrusion.", Description="02507", Definition="", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("eb2ecf05-43fb-4002-9942-7d31b31e9cd7"), Code="Keypad access control system is specified as the type of system that protects the facility from intrusion.", Description="02509", Definition="", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("aa142996-d454-483e-96d4-b10789136360"), Code="Metal detector is specified as the type of system that protects the facility from intrusion.", Description="02510", Definition="", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("9383f87b-c72f-43c4-8704-7133754f2a93"), Code="Video is specified as the type of system that protects the facility from intrusion.", Description="02499", Definition="", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("6a25aa30-e796-456f-b4be-4372d56fc7bf"), Code="Other is specified as the type of system that protects the facility from intrusion.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingSecuritySystemType Pick List
         /// </summary>
        public static List<RefBuildingSecuritySystemType> RefBuildingSecuritySystemTypePickList = new List<RefBuildingSecuritySystemType> =
        {
            new RefBuildingSecuritySystemType { Id=Guid.Parse("e3c4095f-3ac7-411c-97d6-d5830957dfb6"), Code="Card access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("14304b7d-20ce-4bc3-a845-2463fa1a7737"), Code="Intrusion detection system is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("eb2ecf05-43fb-4002-9942-7d31b31e9cd7"), Code="Keypad access control system is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("aa142996-d454-483e-96d4-b10789136360"), Code="Metal detector is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("9383f87b-c72f-43c4-8704-7133754f2a93"), Code="Video is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
            new RefBuildingSecuritySystemType { Id=Guid.Parse("6a25aa30-e796-456f-b4be-4372d56fc7bf"), Code="Other is specified as the type of system that protects the facility from intrusion.", SortOrder=0 },
       };
   }
}
