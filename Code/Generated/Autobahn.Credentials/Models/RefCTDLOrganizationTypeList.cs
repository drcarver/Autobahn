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
        /// The complete <see cref="RefCTDLOrganizationTypeModel"> List
         /// </summary>
        public static List<RefCTDLOrganizationTypeModel> RefCTDLOrganizationTypeList = new List<RefCTDLOrganizationTypeModel>
        {
            new RefCTDLOrganizationType { Id=Guid.Parse("0a61a253-7719-489b-8283-04dfe1762c79"), Code="AssessmentBody", Description="Assessment Body", Definition="Primarily offers access to assessments for credentials as a service.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8f0621ed-61b8-4583-9d18-efa452176d90"), Code="Business", Description="Business", Definition="An organization that primarily sells products or services and employs one or more individuals.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2d319bec-8e4c-4a61-a761-165e07b2cc72"), Code="BusinessAssociation", Description="Business or Industry Association", Definition="A membership organization primarily engaged in promoting the interests of their business members and providing them with services that may involve the provision of education and credentialing services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2e66764e-c75e-44cf-bffe-0911cd26a0b7"), Code="CertificationBody", Description="Certification Body", Definition="An independent, third-party organization that operates a certification program. A certification body may or may not be governmental, and may or may not have regulatory authority.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("d9eac743-43ec-40cd-b9c1-e307afe2dfa7"), Code="FourYear", Description="Four-Year College", Definition="Authorized postsecondary institution that primarily offers bachelor or higher degrees, but may also award associate degrees.  Includes free-standing medical, law or other first-professional schools, schools that offer postbaccalaureate certificates only, those that offer graduate programs only, etc.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("3f5b749e-8fdf-4ef4-9d26-31b4f91ee9b2"), Code="Government", Description="Government Agency", Definition="An organization in the public sector at the federal, state or local levels.  Includes quasi-governmental organizations, special districts (e.g., libraries), corrections organizations, etc., except college and school districts. Is also responsible for the oversight and administration of specific functions other than the military services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("ebd1367b-8589-4316-af00-b688ace11c41"), Code="HighSchool", Description="High School", Definition="A secondary school providing instruction and educational services that do not focus primarily on career and technical education or alternative education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("f81bdedd-ad0c-4437-9338-2fe128951929"), Code="LaborUnion", Description="Labor Union", Definition="A membership organization of workers formed for the purpose of advancing its members' interests in respect to wages, benefits, and working conditions.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2a58c75a-94fd-49e5-8f52-4d074aadf1ee"), Code="Magnet", Description="Magnet/Competitive Admissions School", Definition="A public school offering special instruction and programs not available elsewhere, designed to attract a more diverse student body from throughout a school district.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("60bc4ba1-b88c-4274-8284-4e24075728e2"), Code="Military", Description="Military", Definition="The armed services of a government entity.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("a96b0631-611c-4079-8b05-0b75ebb29f7e"), Code="NonTraditional", Description="Alternative/Non-Traditional School", Definition="A secondary school that: 1) addresses needs of students which cannot typically be met in a regular school; 2) provides nontraditional education; and 3) falls outside of the categories of regular, magnet/special program emphasis, or career and technical education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("4077df99-9dac-4e3c-b7be-14867aa805ea"), Code="Postsecondary", Description="Postsecondary Educational Institution", Definition="An organization such as a college or university: (1) whose sole purpose is to provide postsecondary education defined as the provision of a formal instructional program whose curriculum is designed primarily for students who are beyond the compulsory age for high school and (2) has the authority to award degrees. This includes programs whose purpose is academic, vocational, and continuing professional education.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("93b1dd71-0db2-461e-b800-3f0069ceebea"), Code="PrimarilyOnline", Description="Primarily Online", Definition="An organization that primarily operates online.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("d603c1d4-ec7c-4a2f-aa58-95bb463701bc"), Code="ProfessionalAssociation", Description="Professional Association", Definition="A membership organization primarily engaged in promoting the interests of a particular profession, the interests of individuals engaged in that profession, and providing them with services that may involve the provision of education and credentialing services.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("929356db-87f4-43f8-8c95-0f070cf848f5"), Code="QualityAssurance", Description="Quality Assurance Body", Definition="External body that performs accreditation, endorsement, approval, and/or recognition of a credential issuer.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9a8c31e7-34a2-426f-95fa-3fd3c90c64ba"), Code="SecondarySchool", Description="Secondary School", Definition="A secondary school primarily providing education to students at the ninth grade or higher.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("c5f05667-00ec-440d-8473-06155f1124c7"), Code="Technical", Description="Career and Technical School", Definition="A secondary school that focuses primarily on providing formal preparation for skilled, technical or professional occupations or careers.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("b0a26d09-c811-4b88-93bb-d53ff551d415"), Code="TrainingProvider", Description="Education and Training Provider", Definition="An organization whose major purpose is to provide education and training services but is not a postsecondary education institution with the authority to award degrees. Includes community-based organizations, non-degree granting proprietary schools which are education and training providers that are recognized by states as schools and are Title IV eligible but do not award degrees, etc.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("07670a3c-5896-4877-b2aa-b24a4960a45d"), Code="TwoYear", Description="Two-Year College", Definition="Authorized postsecondary institution that primarily offers associate degrees, but may also award higher degrees.", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8329f4d5-11a4-4c38-b4ed-5e0ea5a89193"), Code="Vendor", Description="Vendor", Definition="Sells, maintains, and issues credentials for its own products and services for public access and use.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefCTDLOrganizationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCTDLOrganizationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCTDLOrganizationType { Id=Guid.Parse("0a61a253-7719-489b-8283-04dfe1762c79"), Description="Assessment Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8f0621ed-61b8-4583-9d18-efa452176d90"), Description="Business", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2d319bec-8e4c-4a61-a761-165e07b2cc72"), Description="Business or Industry Association", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2e66764e-c75e-44cf-bffe-0911cd26a0b7"), Description="Certification Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("d9eac743-43ec-40cd-b9c1-e307afe2dfa7"), Description="Four-Year College", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("3f5b749e-8fdf-4ef4-9d26-31b4f91ee9b2"), Description="Government Agency", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("ebd1367b-8589-4316-af00-b688ace11c41"), Description="High School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("f81bdedd-ad0c-4437-9338-2fe128951929"), Description="Labor Union", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("2a58c75a-94fd-49e5-8f52-4d074aadf1ee"), Description="Magnet/Competitive Admissions School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("60bc4ba1-b88c-4274-8284-4e24075728e2"), Description="Military", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("a96b0631-611c-4079-8b05-0b75ebb29f7e"), Description="Alternative/Non-Traditional School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("4077df99-9dac-4e3c-b7be-14867aa805ea"), Description="Postsecondary Educational Institution", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("93b1dd71-0db2-461e-b800-3f0069ceebea"), Description="Primarily Online", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("d603c1d4-ec7c-4a2f-aa58-95bb463701bc"), Description="Professional Association", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("929356db-87f4-43f8-8c95-0f070cf848f5"), Description="Quality Assurance Body", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("9a8c31e7-34a2-426f-95fa-3fd3c90c64ba"), Description="Secondary School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("c5f05667-00ec-440d-8473-06155f1124c7"), Description="Career and Technical School", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("b0a26d09-c811-4b88-93bb-d53ff551d415"), Description="Education and Training Provider", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("07670a3c-5896-4877-b2aa-b24a4960a45d"), Description="Two-Year College", SortOrder=Convert.ToDecimal("") },
            new RefCTDLOrganizationType { Id=Guid.Parse("8329f4d5-11a4-4c38-b4ed-5e0ea5a89193"), Description="Vendor", SortOrder=Convert.ToDecimal("") },
       };
   }
}
