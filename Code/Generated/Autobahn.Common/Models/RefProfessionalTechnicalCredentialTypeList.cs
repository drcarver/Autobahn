//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProfessionalTechnicalCredentialTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProfessionalTechnicalCredentialType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProfessionalTechnicalCredentialTypeModel"> List
         /// </summary>
        public static List<RefProfessionalTechnicalCredentialTypeModel> RefProfessionalTechnicalCredentialTypeList = new List<RefProfessionalTechnicalCredentialTypeModel>
        {
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("8f1f9353-b43d-404a-ab36-733a897add10"), Code="OccupationalLicense", Description="Occupational License", Definition="Occupational License was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("bc165326-d8a3-4e04-b40a-ef2b0476da0a"), Code="IndustryCertification", Description="Industry-recognized Certification", Definition="Industry-recognized Certification was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("2e5d5bca-a0f2-44ad-96ef-bfe64142569d"), Code="ApprenticeshipCertificate", Description="Apprenticeship Certificate", Definition="Apprenticeship Certificate was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("2aeed9fa-c76d-4ce1-a620-f50a6b52769f"), Code="EmployerCertification", Description="Employer certification", Definition="Employer certification was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("96bc440f-5078-4385-8800-84b0efafc198"), Code="PreEmploymentTraining", Description="Pre-employment training certificate", Definition="Pre-employment training certificate was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("7.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("fee6cc31-af41-44f3-b55e-f6638f21d014"), Code="OtherOccupational", Description="Other recognized occupational skills credential", Definition="Other recognized occupational skills credential was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefProfessionalTechnicalCredentialType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProfessionalTechnicalCredentialTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("8f1f9353-b43d-404a-ab36-733a897add10"), Description="Occupational License", SortOrder=Convert.ToDecimal("1.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("bc165326-d8a3-4e04-b40a-ef2b0476da0a"), Description="Industry-recognized Certification", SortOrder=Convert.ToDecimal("2.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("2e5d5bca-a0f2-44ad-96ef-bfe64142569d"), Description="Apprenticeship Certificate", SortOrder=Convert.ToDecimal("3.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("2aeed9fa-c76d-4ce1-a620-f50a6b52769f"), Description="Employer certification", SortOrder=Convert.ToDecimal("5.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("96bc440f-5078-4385-8800-84b0efafc198"), Description="Pre-employment training certificate", SortOrder=Convert.ToDecimal("7.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("fee6cc31-af41-44f3-b55e-f6638f21d014"), Description="Other recognized occupational skills credential", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
