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
            new ReferenceModelBase { Id=Guid.Parse("5ff74b2b-0409-47cc-b815-216f6d6b7599"), Code="LEA", Description="Local Education Agency", Definition="Local Education Agency is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("a60ca710-7634-4b58-9564-7be62f076f11"), Code="PostsecondaryInstitution", Description="Postsecondary Institution", Definition="Postsecondary Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("6e8eb84c-325d-41c8-8995-f9f400cb7211"), Code="CommunityBasedOrganization", Description="Community-Based Organization", Definition="Community-Based Organization is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("c3fb8523-3a7f-44d9-b35a-d59e5d612227"), Code="Library", Description="Library", Definition="Library is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("6aff6ce5-eaa7-4b68-906f-76a3be9e0af1"), Code="CorrectionalInstitution", Description="Correctional Institution", Definition="Correctional Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("9604f27e-15e6-47b2-a0b5-446544542653"), Code="OtherInstitution", Description="Other Institution", Definition="Other Institution is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("ca5203f7-9cf9-475d-8cc9-7f26cd17cc9a"), Code="OtherAgency", Description="Other state or local government agency", Definition="Other state or local government agency is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("3232ac59-cdeb-4f77-82d0-c8d7016d466c"), Code="Other", Description="Other", Definition="Other is specified as the type of institution responsible for providing adult education instructional services.", SortOrder=Convert.ToDecimal("1") },
            new ReferenceModelBase { Id=Guid.Parse("08c179c4-5d41-4786-8c95-68407e697645"), Code="Employer", Description="Employer", Definition="A business, firm, institution, or other organization for whom an individual works (including self-employment) in return for financial or other compensation.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b4bc83fe-3d28-46dc-8081-de8ed9d02924"), Code="K12School", Description="K12 School", Definition="An institution that provides educational services; has one or more grade groups (PK through 12); has one or more teachers; is located in one or more buildings; has an assigned administrator(s).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("f395c310-c8e6-47d2-9ca5-8b48a07b5454"), Code="LEA", Description="Local Education Agency (LEA)", Definition="An administrative unit at the local level which exists primarily to operate schools or to contract for educational services. These units may or may not be co-extensive with county, city, or town boundaries.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("1d98e460-9964-4eec-919c-1d78660ec82a"), Code="IEU", Description="Intermediate Educational Unit (IEU)", Definition="A regional, multi-services public agency authorized by State law to develop, manage, and provide services, programs, or other support (e.g., construction, food services, technology services) to LEAs.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("344ab87d-a968-476a-aaea-cf18583bc8e2"), Code="SEA", Description="State Education Agency (SEA)", Definition="The agency of the state charged with primary responsibility for coordinating and supervising public instruction, including the setting of standards for elementary and secondary instruction programs, and it is the state agency that administers federal grant programs.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("32ebd021-4096-403a-86db-3e08e9ed39e2"), Code="Recruiter", Description="Recruiter", Definition="An organization responsible for identifying and/or selecting prospective employees to fill vacant positions in an organization.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("6dbef9fd-cfb6-456f-9c7c-d1dbfee0256e"), Code="EmployeeBenefitCarrier", Description="Employee Benefit Carrier", Definition="An organization or institution that administers benefit plans or services to a staff member.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("7b9fe4ba-21ac-4441-8885-e2b7f3c33cbd"), Code="EmployeeBenefitContributor", Description="Employee Benefit Contributor", Definition="An individual or organization that contributes monetary, in kind, or other types of contributions to an employee's benefit plan.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("5fb7183d-be12-41b7-85c0-7fbc63c8dcf7"), Code="ProfessionalMembershipOrganization", Description="Professional Membership Organization", Definition="An association or corporation established for the purpose of providing services on a nonprofit basis to its members.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("298425bc-d8f2-4a20-9555-1fbe5142731b"), Code="EducationInstitution", Description="Education Institution", Definition="A public or private institution, organization, or agency that provides instructional or support services to students or staff at any level.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("f539eddd-206d-4195-a3d1-c5833abf0449"), Code="StaffDevelopmentProvider", Description="Staff Development Provider", Definition="An individual or organization who provides a planned, structured process through which an individual improves his or her job-related knowledge, skills, or attitudes. Such a process is deigned to enable a staff member to grow within a profession or organization or to attain an initial or additional credential.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("1a96e064-3291-4409-b85d-5a820030dc60"), Code="Facility", Description="Facility", Definition="An installation in which an organization is housed; includes all buildings, structures, and other stationary items that are located on a single site or on contiguous or adjacent sites and that are used for district or system administrative purposes.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("2a9d4cfe-e494-4133-bd22-2460b801059a"), Code="Course", Description="Course", Definition="The organization of subject matter and related learning experiences provided for the instruction of students on a regular or systematic basis, usually for a predetermined period of time (e.g., a semester or two-week workshop) to an individual or group of students (e.g., a class).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("6a8642c3-f462-4386-bda6-9d6b3a44fe5e"), Code="CourseSection", Description="Course Section", Definition="A setting in which organized instruction of course content is provided to one or more students for a given period of time.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("32fbf754-afe1-4cf4-b832-7af032e8fcb5"), Code="Program", Description="Program", Definition="An organization that supplements the regular school program or serves as early childhood education and care for children prior to reaching school-attendance age. These programs and services are often, but not solely, available through federal, state, or local agencies, non-profit organizations and/or other community-based organizations (or assistance provided by these entities). Services may be instructional or non-instructional in nature, may be direct or in-direct, and may be provided within or outside of a school building.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("ec50266d-0d56-4f41-bf85-143ad870dd0b"), Code="PostsecondaryInstitution", Description="Postsecondary Institution", Definition="An organization that provides educational programs for individuals who have completed or otherwise left educational programs in secondary school(s).", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("aede4ec4-e89f-457e-a034-a4720afec869"), Code="AdultEducationProvider", Description="Adult Education Provider", Definition="An organization with information about programs that help adults get the basic skills they need to be productive workers, family members, and citizens.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("0ca22c5a-f9d1-42d5-80d1-ef1b4598b8d2"), Code="ServiceProvider", Description="Service Provider", Definition="An organization responsible for administering services to an individual or organization participating in a program or receiving services.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("2fd3244e-fd7f-4594-bdd5-2d3160a5d467"), Code="AffiliatedInstitution", Description="Affiliated Institution", Definition="An institution that has an ongoing, functional relationship with the education institution in order to provide improved educational experiences to an individual and/or the school.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("f9de0a9d-2848-4cc8-befb-06f4eb3a5e89"), Code="GoverningBoard", Description="Governing Board", Definition="An institution that is responsible for the policy decisions of an educational entity.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("b8d4c39c-09ff-4711-8bbd-f8fa8a9d2cac"), Code="CredentialingOrganization", Description="Credentialing Organization", Definition="An institution, organization, federation, or other such group that is responsible for accrediting or endorsing an individual's preparation, skills, or performance.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("7ff0d7f3-6377-4bcf-bcce-fbb62c77da1a"), Code="AccreditingOrganization", Description="Accrediting Organization", Definition="An authority that reviews an organization's educational program and staff for quality, and certifies whether the organization meets a minimal set of standards.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("5fd0d2f2-c3c3-4a98-889c-0aee27056158"), Code="EducationOrganizationNetwork", Description="Education Organization Network", Definition="A self-organized membership network of peer-level educational organizations intended to provide shared services or collective procurement.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("cb598eeb-48a2-46be-9675-225e5133320f"), Code="IDEAPartCLeadAgency", Description=" IDEA Part C Lead Agency", Definition="The lead agency within a State/Jurisdiction responsible for administering IDEA Part C.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("8ccc65bb-ebda-476c-a744-dead5f646484"), Code="CharterSchoolManagementOrganization", Description="Charter School Management Organization", Definition="A separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools. (see Charter School Management Organization Type)", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("adbfaa31-5e35-4dab-83bf-7684262d4fa8"), Code="CharterSchoolAuthorizingOrganization", Description="Charter School Authorizing Organization", Definition="An organization responsible for authorizing charter schools.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("7f0e3ace-a749-485b-bf3f-bf341e60041a"), Code="EmergencyResponseAgency", Description="Emergency Response Agency", Definition="The local, state, or federal agency that has primary responsibility for responding to an emergency situation.", SortOrder=Convert.ToDecimal("2") },
            new ReferenceModelBase { Id=Guid.Parse("d6757915-fda4-4726-8f0e-e2d0fbd5c78b"), Code="EarlyCollege", Description="Early College", Definition="An institution in which all students participate in a comprehensive plan that integrates their high school course of study and an intentionally designed authentic postsecondary experience leading to their regular high school diploma, an official college transcript and transferable college credit towards a recognized postsecondary degree or credential.", SortOrder=Convert.ToDecimal("2") },
        };
        #endregion
    }
}
