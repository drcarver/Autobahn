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
        public static List<RefAeCertificationType> RefAeCertificationTypeList = new List<RefAeCertificationType>
        {
            new RefAeCertificationType { Id=Guid.Parse("c0add7e4-f027-44f0-b066-be0252f0ecff"), Code="AdultEducationCertification", Description="Adult Education Certification", Definition="Adult Education Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeCertificationType { Id=Guid.Parse("e81dd2ee-8a08-4354-9089-21e009203818"), Code="K-12Certification", Description="K-12 Certification", Definition="K-12 Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeCertificationType { Id=Guid.Parse("f218ccf5-4f6e-4960-bdcf-3ee91a927565"), Code="SpecialEducationCertification", Description="Special Education Certification", Definition="Special Education Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeCertificationType { Id=Guid.Parse("562a5eda-0aa4-424e-9c32-5b4237edb484"), Code="TESOLCertification", Description="Teachers of English to Speakers of Other Languages (TESOL) Certification", Definition="Teachers of English to Speakers of Other Languages (TESOL) Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeCertificationType { Id=Guid.Parse("e7e8cafd-7b32-4b4c-9632-dfb2a03a2da7"), Code="None", Description="None", Definition="None is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefAeCertificationType Pick List
         /// </summary>
        public static List<RefAeCertificationType> RefAeCertificationTypePickList = new List<RefAeCertificationType>
        {
            new RefAeCertificationType { Id=Guid.Parse("c0add7e4-f027-44f0-b066-be0252f0ecff"), Code="AdultEducationCertification", Description="Adult Education Certification", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeCertificationType { Id=Guid.Parse("e81dd2ee-8a08-4354-9089-21e009203818"), Code="K-12Certification", Description="K-12 Certification", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeCertificationType { Id=Guid.Parse("f218ccf5-4f6e-4960-bdcf-3ee91a927565"), Code="SpecialEducationCertification", Description="Special Education Certification", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeCertificationType { Id=Guid.Parse("562a5eda-0aa4-424e-9c32-5b4237edb484"), Code="TESOLCertification", Description="Teachers of English to Speakers of Other Languages (TESOL) Certification", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeCertificationType { Id=Guid.Parse("e7e8cafd-7b32-4b4c-9632-dfb2a03a2da7"), Code="None", Description="None", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
