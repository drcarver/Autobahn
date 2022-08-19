//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolViewModel.cs
//* Name:       Accreditation Agency Name
//* Definition: The full name of an agency that accredited a school.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The full name of an agency that accredited a school.
     /// </summary>
    public partial class K12SchoolViewModel : ViewModelBase, Interfaces.IK12School
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12School";

        // AccreditationAgencyName -- (backing property for Accreditation Agency Name)
        private System.String _AccreditationAgencyName;

        // CharterSchoolApprovalYear -- (backing property for Charter School Approval Year)
        private System.String _CharterSchoolApprovalYear;

        // CharterSchoolContractApprovalDate -- (backing property for Charter School Contract Approval Date)
        private System.DateTime? _CharterSchoolContractApprovalDate;

        // CharterSchoolContractIdNumber -- (backing property for Charter School Contract Id Number)
        private System.String _CharterSchoolContractIdNumber;

        // CharterSchoolContractRenewalDate -- (backing property for Charter School Contract Renewal Date)
        private System.DateTime? _CharterSchoolContractRenewalDate;

        // CharterSchoolIndicator -- (backing property for Charter School Indicator)
        private System.Boolean? _CharterSchoolIndicator;

        // CharterSchoolOpenEnrollmentIndicator -- (backing property for Charter School Open Enrollment Indicator)
        private System.Boolean? _CharterSchoolOpenEnrollmentIndicator;

        // member variable for the K12CharterSchoolAuthorizerAgencyId property
        private Guid? _K12CharterSchoolAuthorizerAgencyId;

        // K12CharterSchoolManagementOrganizationId -- (backing property for Charter School Management Organization Type)
        private Guid? _K12CharterSchoolManagementOrganizationId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefAdministrativeFundingControlId -- (backing property for Administrative Funding Control)
        private Guid? _RefAdministrativeFundingControlId;

        // RefCharterSchoolTypeId -- (backing property for Charter School Type)
        private Guid? _RefCharterSchoolTypeId;

        // RefIncreasedLearningTimeTypeId -- (backing property for Increased Learning Time Type)
        private Guid? _RefIncreasedLearningTimeTypeId;

        // RefSchoolLevelId -- (backing property for School Level)
        private Guid? _RefSchoolLevelId;

        // RefSchoolTypeId -- (backing property for School Type)
        private Guid? _RefSchoolTypeId;

        // RefStatePovertyDesignationId -- (backing property for State Poverty Designation)
        private Guid? _RefStatePovertyDesignationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AccreditationAgencyName { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        /// <summary>
        /// Charter School Approval Year
        /// <para>
        /// The school year in which a charter school was initially approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20259">Charter School Approval Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CharterSchoolApprovalYear { get => _CharterSchoolApprovalYear; set => SetProperty(ref _CharterSchoolApprovalYear, value); }

        /// <summary>
        /// Charter School Contract Approval Date
        /// <para>
        /// The effective date of the contract (or charter) that an approved charter school authorizer authorized the charter school to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20633">Charter School Contract Approval Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CharterSchoolContractApprovalDate { get => _CharterSchoolContractApprovalDate; set => SetProperty(ref _CharterSchoolContractApprovalDate, value); }

        /// <summary>
        /// Charter School Contract Id Number
        /// <para>
        /// The unique number the SEA assigns to the contract (or charter) that authorizes the charter school to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20632">Charter School Contract Id Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CharterSchoolContractIdNumber { get => _CharterSchoolContractIdNumber; set => SetProperty(ref _CharterSchoolContractIdNumber, value); }

        /// <summary>
        /// Charter School Contract Renewal Date
        /// <para>
        /// The date by which the charter school must renew its contract (or charter) with an approved charter school authorizer in order to continue to operate in the state under the state's charter school legislation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20634">Charter School Contract Renewal Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CharterSchoolContractRenewalDate { get => _CharterSchoolContractRenewalDate; set => SetProperty(ref _CharterSchoolContractRenewalDate, value); }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// Charter School Open Enrollment Indicator
        /// <para>
        /// Indicates that the charter school offers open enrollment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20524">Charter School Open Enrollment Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CharterSchoolOpenEnrollmentIndicator { get => _CharterSchoolOpenEnrollmentIndicator; set => SetProperty(ref _CharterSchoolOpenEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get => _K12CharterSchoolAuthorizerAgencyId; set => SetProperty(ref _K12CharterSchoolAuthorizerAgencyId, value); }

        /// <summary>
        /// Charter School Management Organization Type
        /// <para>
        /// The type of organization that is a separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20631">Charter School Management Organization Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? K12CharterSchoolManagementOrganizationId { get => _K12CharterSchoolManagementOrganizationId; set => SetProperty(ref _K12CharterSchoolManagementOrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Administrative Funding Control
        /// <para>
        /// The type of education institution as classified by its funding source.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19012">Administrative Funding Control</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Charter School Type
        /// <para>
        /// The category of charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19686">Charter School Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCharterSchoolTypeId { get => _RefCharterSchoolTypeId; set => SetProperty(ref _RefCharterSchoolTypeId, value); }

        /// <summary>
        /// Increased Learning Time Type
        /// <para>
        /// The types of increased learning time provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19164">Increased Learning Time Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// School Level
        /// <para>
        /// An indication of the level of the education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19241">School Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSchoolLevelId { get => _RefSchoolLevelId; set => SetProperty(ref _RefSchoolLevelId, value); }

        /// <summary>
        /// School Type
        /// <para>
        /// The type of education institution as classified by its primary focus. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19242">School Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSchoolTypeId { get => _RefSchoolTypeId; set => SetProperty(ref _RefSchoolTypeId, value); }

        /// <summary>
        /// State Poverty Designation
        /// <para>
        /// The designation of a school's poverty quartile for purposes of determining classes taught by highly qualified teachers in high and low poverty schools, according to state's indicator of poverty.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19578">State Poverty Designation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStatePovertyDesignationId { get => _RefStatePovertyDesignationId; set => SetProperty(ref _RefStatePovertyDesignationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12School model)
        {
            IsBusy = true;
            Id = model.Id;
            AccreditationAgencyName = model.AccreditationAgencyName; // Accreditation Agency Name
            CharterSchoolApprovalYear = model.CharterSchoolApprovalYear; // Charter School Approval Year
            CharterSchoolContractApprovalDate = model.CharterSchoolContractApprovalDate; // Charter School Contract Approval Date
            CharterSchoolContractIdNumber = model.CharterSchoolContractIdNumber; // Charter School Contract Id Number
            CharterSchoolContractRenewalDate = model.CharterSchoolContractRenewalDate; // Charter School Contract Renewal Date
            CharterSchoolIndicator = model.CharterSchoolIndicator; // Charter School Indicator
            CharterSchoolOpenEnrollmentIndicator = model.CharterSchoolOpenEnrollmentIndicator; // Charter School Open Enrollment Indicator
            K12CharterSchoolAuthorizerAgencyId = model.K12CharterSchoolAuthorizerAgencyId; // 
            K12CharterSchoolManagementOrganizationId = model.K12CharterSchoolManagementOrganizationId; // Charter School Management Organization Type
            OrganizationId = model.OrganizationId; // 
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // Administrative Funding Control
            RefCharterSchoolTypeId = model.RefCharterSchoolTypeId; // Charter School Type
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // Increased Learning Time Type
            RefSchoolLevelId = model.RefSchoolLevelId; // School Level
            RefSchoolTypeId = model.RefSchoolTypeId; // School Type
            RefStatePovertyDesignationId = model.RefStatePovertyDesignationId; // State Poverty Designation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSchoolLevel List
        /// <summary>
        /// The complete Accreditation Agency Name List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("73b8bb61-2553-453c-a18e-c5619ea8956b"), Code="00013", Description="Adult", Definition="Adult is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("303b83f8-610f-4d52-b701-9e7d5feea38d"), Code="01302", Description="All levels", Definition="The institution serves all levels.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c7e50fc-307c-47df-a4ce-49456eddc472"), Code="01304", Description="Elementary", Definition="Elementary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("84e86e2a-67e5-4509-b5f8-96ad061533f3"), Code="02402", Description="High school", Definition="High school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("08d1c838-07b3-4548-bdc2-4badae451adf"), Code="00787", Description="Infant/toddler", Definition="Infant/toddler is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("d98709b0-09c5-4960-a118-737865a53bf5"), Code="02399", Description="Intermediate", Definition="Intermediate is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("70e09f38-a216-4453-a650-91acf106f5f3"), Code="02602", Description="Junior high school", Definition="Junior high school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("c1919892-0fb9-4cea-8d14-dc3f155db95e"), Code="02400", Description="Middle", Definition="Middle is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("22772187-c28c-4497-8a9c-f8bd4369bc8c"), Code="01981", Description="Pre-kindergarten/early childhood", Definition="Pre-kindergarten/early childhood is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("6a25ea0e-591b-44ce-bf1a-570fad34f992"), Code="02397", Description="Primary", Definition="Primary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("bab66d24-8e13-479c-beff-1b425c178ed5"), Code="02403", Description="Secondary", Definition="Secondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("2243281a-0fa6-47fd-b8a4-3f95709907d0"), Code="73066", Description="Joint secondary and postsecondary", Definition="Joint secondary and postsecondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion

        #region RefSchoolType List
        /// <summary>
        /// The complete Accreditation Agency Name List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ca423500-aa46-4f94-976e-b3e8cac4a905"), Code="Regular", Description="Regular School", Definition="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7040d3fb-3fed-4fd2-bb92-05ec3d29913a"), Code="Special", Description="Special Education School", Definition="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f2fb7611-0676-43c8-aac7-c3eb51c1cb85"), Code="CareerAndTechnical", Description="Career and Technical Education School", Definition="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("40453b3a-80c2-47cc-9dc3-cdf1ae4dbaf6"), Code="Alternative", Description="Alternative Education School", Definition="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("1067a55c-a85d-45ff-b4c4-25f66069d0c1"), Code="Reportable", Description="Reportable Program", Definition="The permitted value \u0022reportable program\u0022 is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefStatePovertyDesignation List
        /// <summary>
        /// The complete Accreditation Agency Name List
        /// </summary>
        private static List<ReferenceModelBase> RefStatePovertyDesignationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("522160d0-0cf4-4b26-b18e-8e602b615280"), Code="HighQuartile", Description=" High poverty quartile school", Definition="The school is a high poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd3dccb7-61b0-4c47-a274-300e8803fb16"), Code="LowQuartile", Description="Low poverty quartile school", Definition="The school is a low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1374cf46-bc86-4286-bf13-96fc26973a7e"), Code="Neither", Description="Neither high nor low poverty quartile school", Definition="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
