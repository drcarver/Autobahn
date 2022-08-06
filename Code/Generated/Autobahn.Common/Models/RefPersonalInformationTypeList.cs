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
        public static List<RefPersonalInformationType> RefPersonalInformationTypeList = new List<RefPersonalInformationType>
        {
            new RefPersonalInformationType { Id=Guid.Parse("aaacf46c-1a47-4ed0-894f-f49f2b682f6a"), Code="Address", Description="Address", Definition="Address is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationType { Id=Guid.Parse("b80ba0cb-fc11-448a-a2bc-9c0040ab8395"), Code="Birthdate", Description="Birthdate", Definition="Birthdate is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationType { Id=Guid.Parse("a4ba3a3a-10b4-4d1e-b716-1e962d3c6a1d"), Code="Name", Description="Name", Definition="Name is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationType { Id=Guid.Parse("f7f67a39-8dfa-45c9-9cdd-7848f0f47a82"), Code="TelephoneNumber", Description="Telephone Number", Definition="Telephone Number is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefPersonalInformationType Pick List
         /// </summary>
        public static List<RefPersonalInformationType> RefPersonalInformationTypePickList = new List<RefPersonalInformationType>
        {
            new RefPersonalInformationType { Id=Guid.Parse("aaacf46c-1a47-4ed0-894f-f49f2b682f6a"), Code="Address", Description="Address", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationType { Id=Guid.Parse("b80ba0cb-fc11-448a-a2bc-9c0040ab8395"), Code="Birthdate", Description="Birthdate", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationType { Id=Guid.Parse("a4ba3a3a-10b4-4d1e-b716-1e962d3c6a1d"), Code="Name", Description="Name", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationType { Id=Guid.Parse("f7f67a39-8dfa-45c9-9cdd-7848f0f47a82"), Code="TelephoneNumber", Description="Telephone Number", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
