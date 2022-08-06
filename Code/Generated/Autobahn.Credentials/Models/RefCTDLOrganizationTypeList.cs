//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCTDLOrganizationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The list of RefCTDLOrganizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCTDLOrganizationType"> List
         /// </summary>
        public static List<RefCTDLOrganizationType> RefCTDLOrganizationTypeList = new List<RefCTDLOrganizationType>
        {
            new RefCTDLOrganizationType { Id=Guid.Parse("08855c68-5501-4dde-aca6-480384c374e5"), Code="AssessmentBody", Description="Assessment Body", Definition="Primarily offers access to assessments for credentials as a service.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9206d585-2201-45b3-87a7-3381d59edf8a"), Code="Business", Description="Business", Definition="An organization that primarily sells products or services and employs one or more individuals.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2a5d67fd-5e53-4d71-97fa-be743b38af62"), Code="BusinessAssociation", Description="Business or Industry Association", Definition="A membership organization primarily engaged in promoting the interests of their business members and providing them with services that may involve the provision of education and credentialing services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5b257256-9187-446f-88d2-9a76d344d522"), Code="CertificationBody", Description="Certification Body", Definition="An independent, third-party organization that operates a certification program. A certification body may or may not be governmental, and may or may not have regulatory authority.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("244445c2-1b92-40b5-be57-bce91295d51d"), Code="FourYear", Description="Four-Year College", Definition="Authorized postsecondary institution that primarily offers bachelor or higher degrees, but may also award associate degrees.  Includes free-standing medical, law or other first-professional schools, schools that offer postbaccalaureate certificates only, those that offer graduate programs only, etc.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("7740ece5-23d0-4472-bb12-61df00e2ce0d"), Code="Government", Description="Government Agency", Definition="An organization in the public sector at the federal, state or local levels.  Includes quasi-governmental organizations, special districts (e.g., libraries), corrections organizations, etc., except college and school districts. Is also responsible for the oversight and administration of specific functions other than the military services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("154c874f-e1d9-4862-b215-18f7d5ab1558"), Code="HighSchool", Description="High School", Definition="A secondary school providing instruction and educational services that do not focus primarily on career and technical education or alternative education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5d2da446-a8e3-4ae6-90fd-0583ecfa5a88"), Code="LaborUnion", Description="Labor Union", Definition="A membership organization of workers formed for the purpose of advancing its members' interests in respect to wages, benefits, and working conditions.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("706a387f-27fe-4c71-a6c9-fbef85408da7"), Code="Magnet", Description="Magnet/Competitive Admissions School", Definition="A public school offering special instruction and programs not available elsewhere, designed to attract a more diverse student body from throughout a school district.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("0c6ee72a-581d-42d4-bede-b754b17ecacb"), Code="Military", Description="Military", Definition="The armed services of a government entity.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("bfe333a6-6c9d-45bb-9676-f2a320650734"), Code="NonTraditional", Description="Alternative/Non-Traditional School", Definition="A secondary school that: 1) addresses needs of students which cannot typically be met in a regular school; 2) provides nontraditional education; and 3) falls outside of the categories of regular, magnet/special program emphasis, or career and technical education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("ece7106a-f248-46ad-b2bc-866480afeac2"), Code="Postsecondary", Description="Postsecondary Educational Institution", Definition="An organization such as a college or university: (1) whose sole purpose is to provide postsecondary education defined as the provision of a formal instructional program whose curriculum is designed primarily for students who are beyond the compulsory age for high school and (2) has the authority to award degrees. This includes programs whose purpose is academic, vocational, and continuing professional education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9bcbd064-c238-46ad-8317-c711bd397df8"), Code="PrimarilyOnline", Description="Primarily Online", Definition="An organization that primarily operates online.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("a3485f8b-74e1-46cc-bcf3-b76d6cb8e6ce"), Code="ProfessionalAssociation", Description="Professional Association", Definition="A membership organization primarily engaged in promoting the interests of a particular profession, the interests of individuals engaged in that profession, and providing them with services that may involve the provision of education and credentialing services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("0c5619c9-9cf4-4e2a-82a9-1841c3a91b84"), Code="QualityAssurance", Description="Quality Assurance Body", Definition="External body that performs accreditation, endorsement, approval, and/or recognition of a credential issuer.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2d022a55-8a1f-4cc6-8194-ffb1eaf2b6d0"), Code="SecondarySchool", Description="Secondary School", Definition="A secondary school primarily providing education to students at the ninth grade or higher.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8774ee82-bb34-413c-8155-cc67c94717e0"), Code="Technical", Description="Career and Technical School", Definition="A secondary school that focuses primarily on providing formal preparation for skilled, technical or professional occupations or careers.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("609cd9bd-ee2e-41d3-94fb-695902ba003c"), Code="TrainingProvider", Description="Education and Training Provider", Definition="An organization whose major purpose is to provide education and training services but is not a postsecondary education institution with the authority to award degrees. Includes community-based organizations, non-degree granting proprietary schools which are education and training providers that are recognized by states as schools and are Title IV eligible but do not award degrees, etc.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("c4661a8c-a1bb-43c8-af15-5eab3e05c0b6"), Code="TwoYear", Description="Two-Year College", Definition="Authorized postsecondary institution that primarily offers associate degrees, but may also award higher degrees.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5e603548-fe59-4f2f-9747-4f8e3405d2c4"), Code="Vendor", Description="Vendor", Definition="Sells, maintains, and issues credentials for its own products and services for public access and use.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefCTDLOrganizationType Pick List
         /// </summary>
        public static List<RefCTDLOrganizationType> RefCTDLOrganizationTypePickList = new List<RefCTDLOrganizationType>
        {
            new RefCTDLOrganizationType { Id=Guid.Parse("08855c68-5501-4dde-aca6-480384c374e5"), Code="AssessmentBody", Description="Assessment Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9206d585-2201-45b3-87a7-3381d59edf8a"), Code="Business", Description="Business", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2a5d67fd-5e53-4d71-97fa-be743b38af62"), Code="BusinessAssociation", Description="Business or Industry Association", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5b257256-9187-446f-88d2-9a76d344d522"), Code="CertificationBody", Description="Certification Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("244445c2-1b92-40b5-be57-bce91295d51d"), Code="FourYear", Description="Four-Year College", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("7740ece5-23d0-4472-bb12-61df00e2ce0d"), Code="Government", Description="Government Agency", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("154c874f-e1d9-4862-b215-18f7d5ab1558"), Code="HighSchool", Description="High School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5d2da446-a8e3-4ae6-90fd-0583ecfa5a88"), Code="LaborUnion", Description="Labor Union", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("706a387f-27fe-4c71-a6c9-fbef85408da7"), Code="Magnet", Description="Magnet/Competitive Admissions School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("0c6ee72a-581d-42d4-bede-b754b17ecacb"), Code="Military", Description="Military", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("bfe333a6-6c9d-45bb-9676-f2a320650734"), Code="NonTraditional", Description="Alternative/Non-Traditional School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("ece7106a-f248-46ad-b2bc-866480afeac2"), Code="Postsecondary", Description="Postsecondary Educational Institution", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9bcbd064-c238-46ad-8317-c711bd397df8"), Code="PrimarilyOnline", Description="Primarily Online", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("a3485f8b-74e1-46cc-bcf3-b76d6cb8e6ce"), Code="ProfessionalAssociation", Description="Professional Association", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("0c5619c9-9cf4-4e2a-82a9-1841c3a91b84"), Code="QualityAssurance", Description="Quality Assurance Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2d022a55-8a1f-4cc6-8194-ffb1eaf2b6d0"), Code="SecondarySchool", Description="Secondary School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8774ee82-bb34-413c-8155-cc67c94717e0"), Code="Technical", Description="Career and Technical School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("609cd9bd-ee2e-41d3-94fb-695902ba003c"), Code="TrainingProvider", Description="Education and Training Provider", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("c4661a8c-a1bb-43c8-af15-5eab3e05c0b6"), Code="TwoYear", Description="Two-Year College", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("5e603548-fe59-4f2f-9747-4f8e3405d2c4"), Code="Vendor", Description="Vendor", SortOrder=Convert.ToDecimal("") },
       };
   }
}
