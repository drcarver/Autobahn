//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonalInformationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonalInformationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonalInformationTypeModel"> List
         /// </summary>
        public static List<RefPersonalInformationTypeModel> RefPersonalInformationTypeList = new List<RefPersonalInformationTypeModel>
        {
            new RefPersonalInformationType { Id=Guid.Parse("997ed1c3-8f5b-42f8-a5b0-9f26b91318d0"), Code="Address", Description="Address", Definition="Address is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationType { Id=Guid.Parse("938af768-f7ac-41af-96f8-f0a3856cdc28"), Code="Birthdate", Description="Birthdate", Definition="Birthdate is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationType { Id=Guid.Parse("1a350180-616a-4022-a7b1-4cfda30f368d"), Code="Name", Description="Name", Definition="Name is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationType { Id=Guid.Parse("2b52c141-aed7-4270-97d0-770ce97ac937"), Code="TelephoneNumber", Description="Telephone Number", Definition="Telephone Number is the type of personal information verified through the Personal Information Verification evidence.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefPersonalInformationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPersonalInformationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPersonalInformationType { Id=Guid.Parse("997ed1c3-8f5b-42f8-a5b0-9f26b91318d0"), Description="Address", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationType { Id=Guid.Parse("938af768-f7ac-41af-96f8-f0a3856cdc28"), Description="Birthdate", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationType { Id=Guid.Parse("1a350180-616a-4022-a7b1-4cfda30f368d"), Description="Name", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationType { Id=Guid.Parse("2b52c141-aed7-4270-97d0-770ce97ac937"), Description="Telephone Number", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
