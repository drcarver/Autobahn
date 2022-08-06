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
        public static List<RefTelephoneNumberType> RefTelephoneNumberTypeList = new List<RefTelephoneNumberType>
        {
            new RefTelephoneNumberType { Id=Guid.Parse("943cba74-1c92-43e8-8822-f2e49370fb32"), Code="Home", Description="Home phone number", Definition="Home phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("cbf79431-185d-4b20-9743-a9b0819a70db"), Code="Work", Description="Work phone number", Definition="Work phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("1ea3b336-00ed-41de-92d1-c6eb4a47a475"), Code="Mobile", Description="Mobile phone number", Definition="Mobile phone number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("37330137-13e1-4cf8-a331-a645028467e2"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for a person.", SortOrder=Convert.ToDecimal("7.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("144c5566-f433-4a3d-b48b-7285443e70e1"), Code="Other", Description="Other", Definition="The type of communication number listed for a person is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefTelephoneNumberType Pick List
         /// </summary>
        public static List<RefTelephoneNumberType> RefTelephoneNumberTypePickList = new List<RefTelephoneNumberType>
        {
            new RefTelephoneNumberType { Id=Guid.Parse("943cba74-1c92-43e8-8822-f2e49370fb32"), Code="Home", Description="Home phone number", SortOrder=Convert.ToDecimal("1.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("cbf79431-185d-4b20-9743-a9b0819a70db"), Code="Work", Description="Work phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("1ea3b336-00ed-41de-92d1-c6eb4a47a475"), Code="Mobile", Description="Mobile phone number", SortOrder=Convert.ToDecimal("5.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("37330137-13e1-4cf8-a331-a645028467e2"), Code="Fax", Description="Fax number", SortOrder=Convert.ToDecimal("7.00") },
            new RefTelephoneNumberType { Id=Guid.Parse("144c5566-f433-4a3d-b48b-7285443e70e1"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
