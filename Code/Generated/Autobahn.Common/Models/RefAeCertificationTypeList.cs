//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAeCertificationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAeCertificationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeCertificationTypeModel"> List
         /// </summary>
        public static List<RefAeCertificationTypeModel> RefAeCertificationTypeList = new List<RefAeCertificationTypeModel>
        {
            new RefAeCertificationType { Id=Guid.Parse("61c12377-9bab-4f65-90fb-f7174e77c2b2"), Code="AdultEducationCertification", Description="Adult Education Certification", Definition="Adult Education Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeCertificationType { Id=Guid.Parse("c4c19b68-1c9d-4b0c-a202-d3524e431284"), Code="K-12Certification", Description="K-12 Certification", Definition="K-12 Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeCertificationType { Id=Guid.Parse("95222167-1dae-44b1-ade1-abf5d94c758f"), Code="SpecialEducationCertification", Description="Special Education Certification", Definition="Special Education Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeCertificationType { Id=Guid.Parse("fa001ed1-af2e-4437-b50c-c3eafe5ee8b5"), Code="TESOLCertification", Description="Teachers of English to Speakers of Other Languages (TESOL) Certification", Definition="Teachers of English to Speakers of Other Languages (TESOL) Certification is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeCertificationType { Id=Guid.Parse("02773cbb-fb40-4536-a35b-b20c10a63d30"), Code="None", Description="None", Definition="None is specified as the category of certification a person holds.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefAeCertificationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAeCertificationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAeCertificationType { Id=Guid.Parse("61c12377-9bab-4f65-90fb-f7174e77c2b2"), Description="Adult Education Certification", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeCertificationType { Id=Guid.Parse("c4c19b68-1c9d-4b0c-a202-d3524e431284"), Description="K-12 Certification", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeCertificationType { Id=Guid.Parse("95222167-1dae-44b1-ade1-abf5d94c758f"), Description="Special Education Certification", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeCertificationType { Id=Guid.Parse("fa001ed1-af2e-4437-b50c-c3eafe5ee8b5"), Description="Teachers of English to Speakers of Other Languages (TESOL) Certification", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeCertificationType { Id=Guid.Parse("02773cbb-fb40-4536-a35b-b20c10a63d30"), Description="None", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
