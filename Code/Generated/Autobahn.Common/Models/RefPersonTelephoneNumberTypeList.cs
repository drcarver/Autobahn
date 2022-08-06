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
        public static List<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypeList = new List<RefPersonTelephoneNumberType>
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e6dbb415-f887-41c6-ac98-7e936f6c0cad"), Code="Home", Description="Home phone number", Definition="Home phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("35f86b3a-1a30-416d-9fd6-40e9ab00ab62"), Code="Work", Description="Work phone number", Definition="Work phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e90861f4-a433-45ae-9eeb-df28d018e644"), Code="Mobile", Description="Mobile phone number", Definition="Mobile phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e23d62cc-0ccf-44e8-94da-8c84c07b512f"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("9c9662fe-44a0-4599-a553-94935baa2d94"), Code="Other", Description="Other", Definition="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefPersonTelephoneNumberType Pick List
         /// </summary>
        public static List<RefPersonTelephoneNumberType> RefPersonTelephoneNumberTypePickList = new List<RefPersonTelephoneNumberType>
        {
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e6dbb415-f887-41c6-ac98-7e936f6c0cad"), Code="Home", Description="Home phone number", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("35f86b3a-1a30-416d-9fd6-40e9ab00ab62"), Code="Work", Description="Work phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e90861f4-a433-45ae-9eeb-df28d018e644"), Code="Mobile", Description="Mobile phone number", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("e23d62cc-0ccf-44e8-94da-8c84c07b512f"), Code="Fax", Description="Fax number", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonTelephoneNumberType { Id=Guid.Parse("9c9662fe-44a0-4599-a553-94935baa2d94"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
