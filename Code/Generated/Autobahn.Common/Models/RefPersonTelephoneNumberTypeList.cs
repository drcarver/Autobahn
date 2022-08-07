//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonTelephoneNumberTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonTelephoneNumberType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonTelephoneNumberTypeModel"> List
         /// </summary>
        public static List<RefPersonTelephoneNumberTypeModel> RefPersonTelephoneNumberTypeList = new List<RefPersonTelephoneNumberTypeModel>
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("cffbf651-66a3-4310-8b1e-2ce1ed8f2e94"), Code="Home", Description="Home phone number", Definition="Home phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("b9fe9391-93e5-483c-b918-b556ef8eccaf"), Code="Work", Description="Work phone number", Definition="Work phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("c14acda3-33dd-4993-ba28-aff7436d6f4b"), Code="Mobile", Description="Mobile phone number", Definition="Mobile phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e29cb79a-e5cd-4524-a930-febbf981fc61"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("b1a42ef5-0a27-4e63-aebc-c72abeac6e59"), Code="Other", Description="Other", Definition="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefPersonTelephoneNumberType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPersonTelephoneNumberTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("cffbf651-66a3-4310-8b1e-2ce1ed8f2e94"), Description="Home phone number", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("b9fe9391-93e5-483c-b918-b556ef8eccaf"), Description="Work phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("c14acda3-33dd-4993-ba28-aff7436d6f4b"), Description="Mobile phone number", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e29cb79a-e5cd-4524-a930-febbf981fc61"), Description="Fax number", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("b1a42ef5-0a27-4e63-aebc-c72abeac6e59"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
