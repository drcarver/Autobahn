//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetail View Model
     /// </summary>
    public partial class OrganizationDetailViewModel : ViewModelBase, Interfaces.IOrganizationDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationDetail";

        // Name -- (backing property for Activity Title)
        private System.String _Name;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationTypeId property
        private Guid? _RefOrganizationTypeId;

        // RegionGeoJSON -- (backing property for Organization Region GeoJSON)
        private System.String _RegionGeoJSON;

        // ShortName -- (backing property for Short Name of Institution)
        private System.String _ShortName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Activity Title
        /// <para>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get => _RefOrganizationTypeId; set => SetProperty(ref _RefOrganizationTypeId, value); }

        /// <summary>
        /// Organization Region GeoJSON
        /// <para>
        /// The geo-political area of the organization's facility, building, or site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20731">Organization Region GeoJSON</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RegionGeoJSON { get => _RegionGeoJSON; set => SetProperty(ref _RegionGeoJSON, value); }

        /// <summary>
        /// Short Name of Institution
        /// <para>
        /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // Activity Title
            OrganizationId = model.OrganizationId; // 
            RefOrganizationTypeId = model.RefOrganizationTypeId; // 
            RegionGeoJSON = model.RegionGeoJSON; // Organization Region GeoJSON
            ShortName = model.ShortName; // Short Name of Institution
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationType List
        /// <summary>
        /// The complete <see cref="RefOrganizationType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("070bddf8-ae19-47ed-959c-1db7dfe639d1"), Code="LEA", Description="Local Education Agency", Definition="Local Education Agency is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("7f740f8c-5d68-417b-8b55-a2ca6248e967"), Code="PostsecondaryInstitution", Description="Postsecondary Institution", Definition="Postsecondary Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("07e11022-5a35-4e0f-b393-0e41d2d0dcbf"), Code="CommunityBasedOrganization", Description="Community-Based Organization", Definition="Community-Based Organization is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("b1e413fd-5de0-4f24-8cbd-a40fff82a9ac"), Code="Library", Description="Library", Definition="Library is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("24d13963-5539-4581-8983-f18f9d50e805"), Code="CorrectionalInstitution", Description="Correctional Institution", Definition="Correctional Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("19c441fc-e6f6-43ca-960d-a7c89aa958c9"), Code="OtherInstitution", Description="Other Institution", Definition="Other Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("fd997d48-7f29-48c7-b897-3c90e5393c52"), Code="OtherAgency", Description="Other state or local government agency", Definition="Other state or local government agency is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("24852bd8-e0c6-439f-9650-7b23c3c69686"), Code="Other", Description="Other", Definition="Other is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("d2bcd5b4-82aa-4afb-9603-9276b755a156"), Code="Employer", Description="Employer", Definition="A business, firm, institution, or other organization for whom an individual works (including self-employment) in return for financial or other compensation.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b8c3aff7-23fc-4218-98c9-8de4a5ae4635"), Code="K12School", Description="K12 School", Definition="An institution that provides educational services; has one or more grade groups (PK through 12); has one or more teachers; is located in one or more buildings; has an assigned administrator(s).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("45c86f74-6b46-4d48-9857-ad04412389d1"), Code="LEA", Description="Local Education Agency (LEA)", Definition="An administrative unit at the local level which exists primarily to operate schools or to contract for educational services. These units may or may not be co-extensive with county, city, or town boundaries.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("cf65ccbe-4c80-437f-8eb4-d087703f9bcb"), Code="IEU", Description="Intermediate Educational Unit (IEU)", Definition="A regional, multi-services public agency authorized by State law to develop, manage, and provide services, programs, or other support (e.g., construction, food services, technology services) to LEAs.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("25304aca-80e1-4c31-acf5-67d82317e9e5"), Code="SEA", Description="State Education Agency (SEA)", Definition="The agency of the state charged with primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instruction programs, and it is the state agency that administers federal grant programs.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b63ddba8-d3d8-4eb7-8ddf-90c2142edb99"), Code="Recruiter", Description="Recruiter", Definition="An organization responsible for identifying and/or selecting prospective employees to fill vacant positions in an organization.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("451f8f8d-cacc-42ae-b8b0-89f28afa6642"), Code="EmployeeBenefitCarrier", Description="Employee Benefit Carrier", Definition="An organization or institution that administers benefit plans or services to a staff member.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("af732f50-9a1a-4876-855d-8b4751647600"), Code="EmployeeBenefitContributor", Description="Employee Benefit Contributor", Definition="An individual or organization that contributes monetary, in kind, or other types of contributions to an employee's benefit plan.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b1f52971-769d-4662-9eae-dcc07323fb6b"), Code="ProfessionalMembershipOrganization", Description="Professional Membership Organization", Definition="An association or corporation established for the purpose of providing services on a nonprofit basis to its members.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("d142890f-10a8-4067-9aa0-d3f4a0e6980e"), Code="EducationInstitution", Description="Education Institution", Definition="A public or private institution, organization, or agency that provides instructional or support services to students or staff at any level.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("73ab238a-f422-4860-932a-f5823c74b8b6"), Code="StaffDevelopmentProvider", Description="Staff Development Provider", Definition="An individual or organization who provides a planned, structured process through which an individual improves his or her job-related knowledge, skills, or attitudes. Such a process is deigned to enable a staff member to grow within a profession or organization or to attain an initial or additional credential.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("1416c6d1-36e8-4d84-9c1e-097cf2a7fa56"), Code="Facility", Description="Facility", Definition="An installation in which an organization is housed; includes all buildings, structures, and other stationary items that are located on a single site or on contiguous or adjacent sites and that are used for district or system administrative purposes.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("560b56a9-6b02-45d0-95b5-b0798e122ee1"), Code="Course", Description="Course", Definition="The organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis, usually for a predetermined period of time (e.g., a semester or two-week workshop) to an individual or group of students (e.g., a class).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("bea1cbdb-6202-4b65-8e8a-1ff3af61bc26"), Code="CourseSection", Description="Course Section", Definition="A setting in which organized instruction of course content is provided to one or more students for a given period of time.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("14030caf-ac77-4bde-96c3-81dfe349f107"), Code="Program", Description="Program", Definition="An organization that supplements the regular school program or serves as early childhood education and care for children prior to reaching school-attendance age. These programs and services are often, but not solely, available through federal, state, or local agencies, non-profit organizations and/or other community-based organizations (or assistance provided by these entities). Services may be instructional or non-instructional in nature, may be direct or in-direct, and may be provided within or outside of a school building.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("8d77a27a-a0cd-4094-bd64-9e5a28c44f1a"), Code="PostsecondaryInstitution", Description="Postsecondary Institution", Definition="An organization that provides educational programs for individuals who have completed or otherwise left educational programs in secondary school(s).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("32c3ae85-7cb7-40a3-8034-1fc0bb18a8e2"), Code="AdultEducationProvider", Description="Adult Education Provider", Definition="An organization with information about programs that help adults get the basic skills they need to be productive workers, family members, and citizens.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("c09f5de8-0ea3-4c6c-88f1-17898fc91ec2"), Code="ServiceProvider", Description="Service Provider", Definition="An organization responsible for administering services to an individual or organization participating in a program or receiving services.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("caa5dd9e-c6d3-4fe6-96a8-4741200667e2"), Code="AffiliatedInstitution", Description="Affiliated Institution", Definition="An institution that has an ongoing, functional relationship with the education institution in order to provide improved educational experiences to an individual and/or the school.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("0b4a5549-9879-408f-b486-c0a8ad020de8"), Code="GoverningBoard", Description="Governing Board", Definition="An institution that is responsible for the policy decisions of an educational entity.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b6bddc64-e48c-48bf-ae3e-a860637f148e"), Code="CredentialingOrganization", Description="Credentialing Organization", Definition="An institution, organization, federation, or other such group that is responsible for accrediting or endorsing an individual's preparation, skills, or performance.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("553da1fe-136b-4aad-870e-f8946aa51fd2"), Code="AccreditingOrganization", Description="Accrediting Organization", Definition="An authority that reviews an organization's educational program and staff for quality, and certifies whether the organization meets a minimal set of standards.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("0165051c-8246-4a0a-ad0f-ea41d737dd6b"), Code="EducationOrganizationNetwork", Description="Education Organization Network", Definition="A self-organized membership network of peer-level educational organizations intended to provide shared services or collective procurement.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("d719b8a8-e121-4d47-95dc-624d5a5ba3cc"), Code="IDEAPartCLeadAgency", Description=" IDEA Part C Lead Agency", Definition="The lead agency within a State/Jurisdiction responsible for administering IDEA Part C.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("8d467b7c-c6bb-4c15-87f5-0e9e9f65bc6f"), Code="CharterSchoolManagementOrganization", Description="Charter School Management Organization", Definition="A separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools. (see Charter School Management Organization Type)", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("29920401-511e-465c-861d-99400354afe0"), Code="CharterSchoolAuthorizingOrganization", Description="Charter School Authorizing Organization", Definition="An organization responsible for authorizing charter schools.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("8b305534-7bb6-49a7-9cf5-1eade0aa61fc"), Code="EmergencyResponseAgency", Description="Emergency Response Agency", Definition="The local, state, or federal agency that has primary responsibility for responding to an emergency situation.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("18f023f3-c99f-4dd8-98a6-8783b916d462"), Code="EarlyCollege", Description="Early College", Definition="An institution in which all students participate in a comprehensive plan that integrates their high school course of study and an intentionally designed authentic postsecondary experience leading to their regular high school diploma, an official college transcript and transferable college credit towards a recognized postsecondary degree or credential.", SortOrder=Convert.ToDecimal("2") },
        };
        #endregion
    }
}
