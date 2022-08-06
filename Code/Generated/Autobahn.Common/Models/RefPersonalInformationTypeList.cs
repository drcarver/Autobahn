//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonalInformationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonalInformationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonalInformationType"> List
         /// </summary>
        public static List<RefPersonalInformationType> RefPersonalInformationTypeList = new List<RefPersonalInformationType> =
        {
            new RefPersonalInformationType { Id=Guid.Parse("72a9cb0b-65fe-40e2-8157-4d9133dd90a8"), Code="Address is the type of personal information verified through the Personal Information Verification evidence.", Description="Address", Definition="", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("2b202cde-a29a-4918-aaab-6a043af31d0c"), Code="Birthdate is the type of personal information verified through the Personal Information Verification evidence.", Description="Birthdate", Definition="", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("23dc4c25-5bb9-4811-a8a4-d1538e782937"), Code="Name is the type of personal information verified through the Personal Information Verification evidence.", Description="Name", Definition="", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("0a1797e0-5c84-499b-b09e-7b037f558b51"), Code="Telephone Number is the type of personal information verified through the Personal Information Verification evidence.", Description="TelephoneNumber", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPersonalInformationType Pick List
         /// </summary>
        public static List<RefPersonalInformationType> RefPersonalInformationTypePickList = new List<RefPersonalInformationType> =
        {
            new RefPersonalInformationType { Id=Guid.Parse("72a9cb0b-65fe-40e2-8157-4d9133dd90a8"), Code="Address is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("2b202cde-a29a-4918-aaab-6a043af31d0c"), Code="Birthdate is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("23dc4c25-5bb9-4811-a8a4-d1538e782937"), Code="Name is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=0 },
            new RefPersonalInformationType { Id=Guid.Parse("0a1797e0-5c84-499b-b09e-7b037f558b51"), Code="Telephone Number is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=0 },
       };
   }
}
