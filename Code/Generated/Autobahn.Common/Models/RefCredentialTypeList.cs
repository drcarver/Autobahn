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
        public static List<RefCredentialType> RefCredentialTypeList = new List<RefCredentialType> =
        {
            new RefCredentialType { Id=Guid.Parse("579f6f95-5f8e-421b-a2d2-fcd13f8e0b7f"), Code="Certification is specified as the  category of credential a person holds.", Description="Certification", Definition="", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("3622287b-8821-436c-8960-322345508051"), Code="Endorsement is specified as the  category of credential a person holds.", Description="Endorsement", Definition="", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("0941e43e-6911-46d9-a163-56fe6d3f7e4c"), Code="Licensure is specified as the  category of credential a person holds.", Description="Licensure", Definition="", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("ab742a5f-8b08-40e1-9d1b-3600da8bce50"), Code="Other is specified as the  category of credential a person holds.", Description="Other", Definition="", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("5ae7e669-c4bd-476c-acf4-f39fae80a403"), Code="Registration is specified as the  category of credential a person holds.", Description="Registration", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialType Pick List
         /// </summary>
        public static List<RefCredentialType> RefCredentialTypePickList = new List<RefCredentialType> =
        {
            new RefCredentialType { Id=Guid.Parse("579f6f95-5f8e-421b-a2d2-fcd13f8e0b7f"), Code="Certification is specified as the  category of credential a person holds.", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("3622287b-8821-436c-8960-322345508051"), Code="Endorsement is specified as the  category of credential a person holds.", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("0941e43e-6911-46d9-a163-56fe6d3f7e4c"), Code="Licensure is specified as the  category of credential a person holds.", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("ab742a5f-8b08-40e1-9d1b-3600da8bce50"), Code="Other is specified as the  category of credential a person holds.", SortOrder=0 },
            new RefCredentialType { Id=Guid.Parse("5ae7e669-c4bd-476c-acf4-f39fae80a403"), Code="Registration is specified as the  category of credential a person holds.", SortOrder=0 },
       };
   }
}
