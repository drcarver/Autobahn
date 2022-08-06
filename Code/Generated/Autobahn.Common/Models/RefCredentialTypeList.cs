//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCredentialTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCredentialType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialType"> List
         /// </summary>
        public static List<RefCredentialType> RefCredentialTypeList = new List<RefCredentialType>
        {
            new RefCredentialType { Id=Guid.Parse("c56455f6-54b9-4e40-8395-426709ee19b9"), Code="Certification", Description="Certification", Definition="Certification is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialType { Id=Guid.Parse("33832ad3-bbf5-4083-90c5-4533bdf505f2"), Code="Endorsement", Description="Endorsement", Definition="Endorsement is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialType { Id=Guid.Parse("164f2f60-2040-43dd-a33c-b7c71abb392f"), Code="Licensure", Description="Licensure", Definition="Licensure is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialType { Id=Guid.Parse("440e5c2e-5d3b-4523-ab4f-b55d6c072670"), Code="Other", Description="Other", Definition="Other is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialType { Id=Guid.Parse("3273f646-f932-427a-b820-30f386b54cf9"), Code="Registration", Description="Registration", Definition="Registration is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefCredentialType Pick List
         /// </summary>
        public static List<RefCredentialType> RefCredentialTypePickList = new List<RefCredentialType>
        {
            new RefCredentialType { Id=Guid.Parse("c56455f6-54b9-4e40-8395-426709ee19b9"), Code="Certification", Description="Certification", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialType { Id=Guid.Parse("33832ad3-bbf5-4083-90c5-4533bdf505f2"), Code="Endorsement", Description="Endorsement", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialType { Id=Guid.Parse("164f2f60-2040-43dd-a33c-b7c71abb392f"), Code="Licensure", Description="Licensure", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialType { Id=Guid.Parse("440e5c2e-5d3b-4523-ab4f-b55d6c072670"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialType { Id=Guid.Parse("3273f646-f932-427a-b820-30f386b54cf9"), Code="Registration", Description="Registration", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
