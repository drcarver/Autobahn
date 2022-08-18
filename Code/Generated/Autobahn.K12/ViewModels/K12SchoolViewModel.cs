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
            new ReferenceModelBase { Id=Guid.Parse("84298c90-1309-4d62-8976-cb09315de738"), Code="00013", Description="Adult", Definition="Adult is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("850659c4-0f88-473e-ad6e-fcb238cd35b5"), Code="01302", Description="All levels", Definition="The institution serves all levels.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1cf91379-83be-482c-8df9-fd01be5fdf55"), Code="01304", Description="Elementary", Definition="Elementary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("c35e17ac-9f95-4013-8670-426fb9a7d17c"), Code="02402", Description="High school", Definition="High school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("cda33fe5-170b-4a51-a393-bff0e5996c76"), Code="00787", Description="Infant/toddler", Definition="Infant/toddler is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("630b973a-92eb-48c2-85ce-e367fbdafb57"), Code="02399", Description="Intermediate", Definition="Intermediate is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("4cc41da7-90be-4cab-837e-7f8e0213c7ba"), Code="02602", Description="Junior high school", Definition="Junior high school is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("d3ef784e-d9af-4e25-a98a-6d03f14aa017"), Code="02400", Description="Middle", Definition="Middle is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee089a56-ed6b-4a6e-ac5e-1ec4c1f14b40"), Code="01981", Description="Pre-kindergarten/early childhood", Definition="Pre-kindergarten/early childhood is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("89132d59-cea8-4e64-98a2-4b09a0a8c693"), Code="02397", Description="Primary", Definition="Primary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ac27499b-964d-489a-a9b6-2286a4013c72"), Code="02403", Description="Secondary", Definition="Secondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a78fbfa7-b5f9-44ba-a302-a30b3fe65a56"), Code="73066", Description="Joint secondary and postsecondary", Definition="Joint secondary and postsecondary is an education level that the education institution serves.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion

        #region RefSchoolType List
        /// <summary>
        /// The complete Accreditation Agency Name List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5ec9d14c-5340-4e16-bfbf-78c501290f85"), Code="Regular", Description="Regular School", Definition="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f070107f-c77c-4b72-8fec-fe1d0513504a"), Code="Special", Description="Special Education School", Definition="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7aa278af-d07a-4fad-a30d-fa2a4b982362"), Code="CareerAndTechnical", Description="Career and Technical Education School", Definition="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("76481b27-94c3-4c76-9354-5a14452f17e7"), Code="Alternative", Description="Alternative Education School", Definition="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("aaf275b5-6c18-44e8-aef7-a39fb76b6415"), Code="Reportable", Description="Reportable Program", Definition="The permitted value \u0022reportable program\u0022 is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefStatePovertyDesignation List
        /// <summary>
        /// The complete Accreditation Agency Name List
        /// </summary>
        private static List<ReferenceModelBase> RefStatePovertyDesignationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b09a7414-71e6-4aff-9262-afb85b9846f8"), Code="HighQuartile", Description=" High poverty quartile school", Definition="The school is a high poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("10d5b44c-7657-4b4e-b1bc-0f0465533ba3"), Code="LowQuartile", Description="Low poverty quartile school", Definition="The school is a low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfe80ec6-0547-4c87-8966-bfb4226a94ac"), Code="Neither", Description="Neither high nor low poverty quartile school", Definition="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
