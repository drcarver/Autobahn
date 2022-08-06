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
        /// The complete <see cref="RefTelephoneNumberType"> List
         /// </summary>
        public static List<RefTelephoneNumberType> RefTelephoneNumberTypeList = new List<RefTelephoneNumberType> =
        {
            new RefTelephoneNumberType { Id=Guid.Parse("3618639e-25e7-47fe-a1d3-aee11d46c29e"), Code="Home phone number is the type of communication number listed for a person.", Description="Home", Definition="", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("8700f277-7097-4573-808e-888795b038ae"), Code="Work phone number is the type of communication number listed for a person.", Description="Work", Definition="", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("61283ce7-60d8-42ae-8cf2-60a0ea713f6f"), Code="Mobile phone number is the type of communication number listed for a person.", Description="Mobile", Definition="", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("438f9eea-c49b-44cb-87a0-3099ba210dab"), Code="Fax number is the type of communication number listed for a person.", Description="Fax", Definition="", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("6042fb88-348e-4f34-8206-6fe2a45838a5"), Code="The type of communication number listed for a person is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTelephoneNumberType Pick List
         /// </summary>
        public static List<RefTelephoneNumberType> RefTelephoneNumberTypePickList = new List<RefTelephoneNumberType> =
        {
            new RefTelephoneNumberType { Id=Guid.Parse("3618639e-25e7-47fe-a1d3-aee11d46c29e"), Code="Home phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("8700f277-7097-4573-808e-888795b038ae"), Code="Work phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("61283ce7-60d8-42ae-8cf2-60a0ea713f6f"), Code="Mobile phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("438f9eea-c49b-44cb-87a0-3099ba210dab"), Code="Fax number is the type of communication number listed for a person.", SortOrder=0 },
            new RefTelephoneNumberType { Id=Guid.Parse("6042fb88-348e-4f34-8206-6fe2a45838a5"), Code="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
