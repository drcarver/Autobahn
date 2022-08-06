//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProfessionalTechnicalCredentialTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProfessionalTechnicalCredentialType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProfessionalTechnicalCredentialType"> List
         /// </summary>
        public static List<RefProfessionalTechnicalCredentialType> RefProfessionalTechnicalCredentialTypeList = new List<RefProfessionalTechnicalCredentialType>
        {
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("8bc6a76b-4c0c-4af8-915e-b5a07df4b39a"), Code="OccupationalLicense", Description="Occupational License", Definition="Occupational License was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("7a5b6e0f-25df-48ca-9b7e-72935ee3d6bf"), Code="IndustryCertification", Description="Industry-recognized Certification", Definition="Industry-recognized Certification was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("32f3b770-3bf5-43f7-9a76-f36d2af5e0d8"), Code="ApprenticeshipCertificate", Description="Apprenticeship Certificate", Definition="Apprenticeship Certificate was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("7c2c64a5-c4e8-4223-8aee-f12e970a6561"), Code="EmployerCertification", Description="Employer certification", Definition="Employer certification was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("5.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("f6fd0810-54e4-462f-823f-87e998443942"), Code="PreEmploymentTraining", Description="Pre-employment training certificate", Definition="Pre-employment training certificate was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("7.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("c92a71cc-4830-49d3-9049-c5a3fc6f6034"), Code="OtherOccupational", Description="Other recognized occupational skills credential", Definition="Other recognized occupational skills credential was conferred for competency in a specific area measured by a set of pre-established standards.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefProfessionalTechnicalCredentialType Pick List
         /// </summary>
        public static List<RefProfessionalTechnicalCredentialType> RefProfessionalTechnicalCredentialTypePickList = new List<RefProfessionalTechnicalCredentialType>
        {
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("8bc6a76b-4c0c-4af8-915e-b5a07df4b39a"), Code="OccupationalLicense", Description="Occupational License", SortOrder=Convert.ToDecimal("1.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("7a5b6e0f-25df-48ca-9b7e-72935ee3d6bf"), Code="IndustryCertification", Description="Industry-recognized Certification", SortOrder=Convert.ToDecimal("2.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("32f3b770-3bf5-43f7-9a76-f36d2af5e0d8"), Code="ApprenticeshipCertificate", Description="Apprenticeship Certificate", SortOrder=Convert.ToDecimal("3.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("7c2c64a5-c4e8-4223-8aee-f12e970a6561"), Code="EmployerCertification", Description="Employer certification", SortOrder=Convert.ToDecimal("5.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("f6fd0810-54e4-462f-823f-87e998443942"), Code="PreEmploymentTraining", Description="Pre-employment training certificate", SortOrder=Convert.ToDecimal("7.00") },
            new RefProfessionalTechnicalCredentialType { Id=Guid.Parse("c92a71cc-4830-49d3-9049-c5a3fc6f6034"), Code="OtherOccupational", Description="Other recognized occupational skills credential", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
