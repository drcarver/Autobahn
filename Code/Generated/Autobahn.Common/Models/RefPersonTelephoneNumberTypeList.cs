//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonTelephoneNumberTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonTelephoneNumberType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonTelephoneNumberType"> List
         /// </summary>
        public static List<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypeList = new List<RefPersonTelephoneNumberType> =
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("a526aca1-f0e8-4d9d-953f-de57810a813d"), Code="Home phone number is the type of communication number listed for a person.", Description="Home", Definition="", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e6703dcc-7a48-4e38-9e4b-60313dbc338f"), Code="Work phone number is the type of communication number listed for a person.", Description="Work", Definition="", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("845d8aed-1d84-474d-900f-c98dd93043d2"), Code="Mobile phone number is the type of communication number listed for a person.", Description="Mobile", Definition="", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("eacd7057-8c2c-4ded-9a47-0c35b36ed8e8"), Code="Fax number is the type of communication number listed for a person.", Description="Fax", Definition="", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("38c22ed0-2354-4424-970c-b41cf713d263"), Code="The type of communication number listed for a person is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPersonTelephoneNumberType Pick List
         /// </summary>
        public static List<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypePickList = new List<RefPersonTelephoneNumberType> =
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("a526aca1-f0e8-4d9d-953f-de57810a813d"), Code="Home phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e6703dcc-7a48-4e38-9e4b-60313dbc338f"), Code="Work phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("845d8aed-1d84-474d-900f-c98dd93043d2"), Code="Mobile phone number is the type of communication number listed for a person.", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("eacd7057-8c2c-4ded-9a47-0c35b36ed8e8"), Code="Fax number is the type of communication number listed for a person.", SortOrder=0 },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("38c22ed0-2354-4424-970c-b41cf713d263"), Code="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
