//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefTelephoneNumberTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefTelephoneNumberType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTelephoneNumberTypeModel"> List
         /// </summary>
        public static List<RefTelephoneNumberTypeModel> RefTelephoneNumberTypeList = new List<RefTelephoneNumberTypeModel>
        {
            new RefTelephoneNumberType { Id=Guid.Parse("7b7773f2-d68b-45ce-b78b-358dfa5979da"), Code="Home", Description="Home phone number", Definition="Home phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("bf0d9928-954e-45c5-bf57-e08cb83a1248"), Code="Work", Description="Work phone number", Definition="Work phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("8f84ca8d-b095-4a01-a41f-63f7ce9606ab"), Code="Mobile", Description="Mobile phone number", Definition="Mobile phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("6cf3596a-36ba-408f-98a6-78266b0c8e6b"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("7.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("cf2b8a88-6191-43d1-be40-0d1b4ed6bb01"), Code="Other", Description="Other", Definition="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefTelephoneNumberType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTelephoneNumberTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTelephoneNumberType { Id=Guid.Parse("7b7773f2-d68b-45ce-b78b-358dfa5979da"), Description="Home phone number", SortOrder=Convert.ToDecimal("1.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("bf0d9928-954e-45c5-bf57-e08cb83a1248"), Description="Work phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("8f84ca8d-b095-4a01-a41f-63f7ce9606ab"), Description="Mobile phone number", SortOrder=Convert.ToDecimal("5.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("6cf3596a-36ba-408f-98a6-78266b0c8e6b"), Description="Fax number", SortOrder=Convert.ToDecimal("7.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("cf2b8a88-6191-43d1-be40-0d1b4ed6bb01"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
