//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAeCertificationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAeCertificationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeCertificationType"> List
         /// </summary>
        public static List<RefAeCertificationType> RefAeCertificationTypeList = new List<RefAeCertificationType> =
        {
            new RefAeCertificationType { Id=Guid.Parse("77e1da47-c1a7-4d54-a7c8-0c54cb84c730"), Code="Adult Education Certification is specified as the category of certification a person holds.", Description="AdultEducationCertification", Definition="", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("046a8458-0acd-4b08-8ec0-f89974470355"), Code="K-12 Certification is specified as the category of certification a person holds.", Description="K-12Certification", Definition="", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("52ec1187-4849-45d1-b842-ccf8e5ed5299"), Code="Special Education Certification is specified as the category of certification a person holds.", Description="SpecialEducationCertification", Definition="", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("335ff0f1-f647-4756-bbb0-5f44173a7c21"), Code="Teachers of English to Speakers of Other Languages (TESOL) Certification is specified as the category of certification a person holds.", Description="TESOLCertification", Definition="", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("59bd5df5-9161-47cf-b35c-a40ac64b9f4b"), Code="None is specified as the category of certification a person holds.", Description="None", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAeCertificationType Pick List
         /// </summary>
        public static List<RefAeCertificationType> RefAeCertificationTypePickList = new List<RefAeCertificationType> =
        {
            new RefAeCertificationType { Id=Guid.Parse("77e1da47-c1a7-4d54-a7c8-0c54cb84c730"), Code="Adult Education Certification is specified as the category of certification a person holds.", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("046a8458-0acd-4b08-8ec0-f89974470355"), Code="K-12 Certification is specified as the category of certification a person holds.", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("52ec1187-4849-45d1-b842-ccf8e5ed5299"), Code="Special Education Certification is specified as the category of certification a person holds.", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("335ff0f1-f647-4756-bbb0-5f44173a7c21"), Code="Teachers of English to Speakers of Other Languages (TESOL) Certification is specified as the category of certification a person holds.", SortOrder=0 },
            new RefAeCertificationType { Id=Guid.Parse("59bd5df5-9161-47cf-b35c-a40ac64b9f4b"), Code="None is specified as the category of certification a person holds.", SortOrder=0 },
       };
   }
}
