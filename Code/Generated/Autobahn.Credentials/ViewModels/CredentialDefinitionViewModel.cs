//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefinitionViewModel.cs
//* Name:       Credential Definition Alternate Name
//* Definition: An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
     /// </summary>
    public partial class CredentialDefinitionViewModel : ViewModelBase, Interfaces.ICredentialDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefinition";

        // AlternateName -- (backing property for Credential Definition Alternate Name)
        private System.String _AlternateName;

        // CredentialDefDateEffective -- (backing property for Credential Definition Date Effective)
        private System.DateTime? _CredentialDefDateEffective;

        // CredentialDefinitionTerminalDegreeIndicator -- (backing property for Credential Definition Terminal Degree Indicator)
        private System.Boolean? _CredentialDefinitionTerminalDegreeIndicator;

        // CredentialNAICSIndustryType -- (backing property for Credential Definition NAICS Industry Type)
        private System.String _CredentialNAICSIndustryType;

        // EmploymentNAICSCode -- (backing property for Employment NAICS Code)
        private System.String _EmploymentNAICSCode;

        // ImageUrl -- (backing property for Credential Image URL)
        private System.String _ImageUrl;

        // JurisdictionRegion -- (backing property for Credential Definition Jurisdiction Region)
        private System.String _JurisdictionRegion;

        // JurisdictionRegionException -- (backing property for Credential Definition Jurisdiction Region Exception)
        private System.String _JurisdictionRegionException;

        // Keywords -- (backing property for Credential Definition Keywords)
        private System.String _Keywords;

        // RefCareerClusterId -- (backing property for Career Cluster)
        private Guid? _RefCareerClusterId;

        // RefCipCodeId -- (backing property for Classification of Instructional Program Code)
        private Guid? _RefCipCodeId;

        // RefCredentialDefIntendedPurposeTypeId -- (backing property for Credential Definition Intended Purpose Type)
        private Guid? _RefCredentialDefIntendedPurposeTypeId;

        // RefCredentialDefStatusTypeId -- (backing property for Credential Definition Status Type)
        private Guid? _RefCredentialDefStatusTypeId;

        // RefCredentialDefVerificationTypeId -- (backing property for Credential Definition Verification Type)
        private Guid? _RefCredentialDefVerificationTypeId;

        // member variable for the RefCTDLAudienceLevelTypeId property
        private Guid? _RefCTDLAudienceLevelTypeId;

        // RefONETSOCOccupationTypeId -- (backing property for O*NET-SOC Occupation Type)
        private Guid? _RefONETSOCOccupationTypeId;

        // Title -- (backing property for Credential Definition Title)
        private System.String _Title;

        // ValidationMethodDescription -- (backing property for Credential Definition Validation Method Description)
        private System.String _ValidationMethodDescription;

        // Version -- (backing property for Credential Definition Version)
        private System.Decimal? _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AlternateName { get => _AlternateName; set => SetProperty(ref _AlternateName, value); }

        /// <summary>
        /// Credential Definition Date Effective
        /// <para>
        /// Effective date of the content of a credential definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CredentialDefDateEffective { get => _CredentialDefDateEffective; set => SetProperty(ref _CredentialDefDateEffective, value); }

        /// <summary>
        /// Credential Definition Terminal Degree Indicator
        /// <para>
        /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get => _CredentialDefinitionTerminalDegreeIndicator; set => SetProperty(ref _CredentialDefinitionTerminalDegreeIndicator, value); }

        /// <summary>
        /// Credential Definition NAICS Industry Type
        /// <para>
        /// The North American Industry Classification System (NAICS) class identifier for an industry associated with the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20723">Credential Definition NAICS Industry Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CredentialNAICSIndustryType { get => _CredentialNAICSIndustryType; set => SetProperty(ref _CredentialNAICSIndustryType, value); }

        /// <summary>
        /// Employment NAICS Code
        /// <para>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EmploymentNAICSCode { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        /// <summary>
        /// Credential Image URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ImageUrl { get => _ImageUrl; set => SetProperty(ref _ImageUrl, value); }

        /// <summary>
        /// Credential Definition Jurisdiction Region
        /// <para>
        /// The geo-political region in which the credential is applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String JurisdictionRegion { get => _JurisdictionRegion; set => SetProperty(ref _JurisdictionRegion, value); }

        /// <summary>
        /// Credential Definition Jurisdiction Region Exception
        /// <para>
        /// A geo-political region in which the credential does not apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String JurisdictionRegionException { get => _JurisdictionRegionException; set => SetProperty(ref _JurisdictionRegionException, value); }

        /// <summary>
        /// Credential Definition Keywords
        /// <para>
        /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Keywords { get => _Keywords; set => SetProperty(ref _Keywords, value); }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Credential Definition Intended Purpose Type
        /// <para>
        /// The intended type of application of the credential by the holder.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get => _RefCredentialDefIntendedPurposeTypeId; set => SetProperty(ref _RefCredentialDefIntendedPurposeTypeId, value); }

        /// <summary>
        /// Credential Definition Status Type
        /// <para>
        /// The status of the credential offered by a credentialing organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get => _RefCredentialDefStatusTypeId; set => SetProperty(ref _RefCredentialDefStatusTypeId, value); }

        /// <summary>
        /// Credential Definition Verification Type
        /// <para>
        /// A resource describing the means by which someone can verify whether a credential has been attained by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get => _RefCredentialDefVerificationTypeId; set => SetProperty(ref _RefCredentialDefVerificationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLAudienceLevelType"/> model
        /// </summary>
        public Guid? RefCTDLAudienceLevelTypeId { get => _RefCTDLAudienceLevelTypeId; set => SetProperty(ref _RefCTDLAudienceLevelTypeId, value); }

        /// <summary>
        /// O*NET-SOC Occupation Type
        /// <para>
        /// The O*NET-SOC taxonomy defines the set of occupations across the world of work based on the Standard Occupational Classification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20737">O*NET-SOC Occupation Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefONETSOCOccupationTypeId { get => _RefONETSOCOccupationTypeId; set => SetProperty(ref _RefONETSOCOccupationTypeId, value); }

        /// <summary>
        /// Credential Definition Title
        /// <para>
        /// The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19893">Credential Definition Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Credential Definition Validation Method Description
        /// <para>
        /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ValidationMethodDescription { get => _ValidationMethodDescription; set => SetProperty(ref _ValidationMethodDescription, value); }

        /// <summary>
        /// Credential Definition Version
        /// <para>
        /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            AlternateName = model.AlternateName; // Credential Definition Alternate Name
            CredentialDefDateEffective = model.CredentialDefDateEffective; // Credential Definition Date Effective
            CredentialDefinitionTerminalDegreeIndicator = model.CredentialDefinitionTerminalDegreeIndicator; // Credential Definition Terminal Degree Indicator
            CredentialNAICSIndustryType = model.CredentialNAICSIndustryType; // Credential Definition NAICS Industry Type
            EmploymentNAICSCode = model.EmploymentNAICSCode; // Employment NAICS Code
            ImageUrl = model.ImageUrl; // Credential Image URL
            JurisdictionRegion = model.JurisdictionRegion; // Credential Definition Jurisdiction Region
            JurisdictionRegionException = model.JurisdictionRegionException; // Credential Definition Jurisdiction Region Exception
            Keywords = model.Keywords; // Credential Definition Keywords
            RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
            RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
            RefCredentialDefIntendedPurposeTypeId = model.RefCredentialDefIntendedPurposeTypeId; // Credential Definition Intended Purpose Type
            RefCredentialDefStatusTypeId = model.RefCredentialDefStatusTypeId; // Credential Definition Status Type
            RefCredentialDefVerificationTypeId = model.RefCredentialDefVerificationTypeId; // Credential Definition Verification Type
            RefCTDLAudienceLevelTypeId = model.RefCTDLAudienceLevelTypeId; // 
            RefONETSOCOccupationTypeId = model.RefONETSOCOccupationTypeId; // O*NET-SOC Occupation Type
            Title = model.Title; // Credential Definition Title
            ValidationMethodDescription = model.ValidationMethodDescription; // Credential Definition Validation Method Description
            Version = model.Version; // Credential Definition Version
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefCtdlAudienceLevelType List
        /// <summary>
        /// The complete Credential Definition Alternate Name List
        /// </summary>
        private static List<ReferenceModelBase> RefCtdlAudienceLevelTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8b1f9745-d7ed-45db-93e7-e48f0c4be761"), Code="ApprenticeshipCertificate", Description="Apprenticeship Certificate", Definition="Credential earned through work-based learning and earn-and-learn models that meet standards and are applicable to industry trades and professions.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f92cb7e4-44c1-4408-9682-fe2b9b7c7f9c"), Code="AssociateDegree", Description="Associate Degree", Definition="College/university award for students typically completing the first one to two years of post secondary school education.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f9eeefc-dee7-4d2a-8f41-43e00dbba2b9"), Code="BachelorDegree", Description="Bachelor Degree", Definition="College/university award for students typically completing three to five years of education where course work and activities advance skills beyond those of the first one to two years of college/university study.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e1aa88ad-26c0-445c-93ec-c8579fe54882"), Code="Badge", Description="Badge", Definition="Recognition designed to be displayed as a marker of accomplishment, activity, achievement, skill, interest, association, or identity.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("02b9f6bd-40f7-48de-bd72-470d4a06ea57"), Code="Certificate", Description="Certificate", Definition="Credential that designates requisite knowledge and skills of an occupation, profession, or academic program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("a7036ba0-5088-45f2-adfe-e5476d15b76f"), Code="Certification", Description="Certification", Definition="Time-limited, revocable, renewable credential awarded by an authoritative body for demonstrating the knowledge, skills, and abilities to perform specific tasks or an occupation.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("52d1cf73-78ed-427d-a97d-e65cb5506585"), Code="ConditionProfile", Description="Condition Profile", Definition="Entity describing a constraint, prerequisite, entry condition, or requirement.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca74a512-b8be-4fda-94e3-4152d177f4a1"), Code="Credential", Description="Credential", Definition="Qualification, achievement, personal or organizational quality, or aspect of an identity typically used to indicate suitability. The ceterms:Credential class is broadly defined to encompass credentials used across domains and communities of practice. The class should be used only when speaking of credentials in general. Subclasses of ceterms:Credential as defined by Credential Engine (or other communities) should be used when referencing specific types of credentials.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d39dd73-23b3-475c-8aec-38746cc237dd"), Code="Degree", Description="Degree", Definition="Academic credential conferred upon completion of a program or course of study, typically over multiple years at a college or university.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a309b0a-e950-4b9f-a93e-faa67ff7be8e"), Code="DigitalBadge", Description="Digital Badge", Definition="Badge offered in digital form.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("08ca7bc2-b488-4c4b-9997-093a97e83cce"), Code="Diploma", Description="Diploma", Definition="Credential awarded by educational institutions for successful completion of a course of study or its equivalent.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("0a387b9e-50ca-4660-8f17-376c28c543b3"), Code="DoctoralDegree", Description="Doctoral Degree", Definition="Highest credential award for students who have completed both a bachelor's degree and a master's degree or their equivalent as well as independent research and/or a significant project or paper.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("c334f7a6-1c51-4f48-8139-da7a39b8650f"), Code="GeneralEducationDevelopment", Description="General Education Development", Definition="Credential awarded by examination that demonstrates that an individual has acquired secondary school-level academic skills.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("c05ef35a-65b7-43c0-a47f-ae50ee971b5b"), Code="JourneymanCertificate", Description="Journeyman Certificate", Definition="Credential awarded to skilled workers on successful completion of an apprenticeship in industry trades and professions.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("17b61633-7a7b-4e8c-a548-25b57c680153"), Code="License", Description="License", Definition="Credential awarded by a government agency that constitutes legal authority to do a specific job and/or utilize a specific item, system or infrastructure and are typically earned through some combination of degree or certificate attainment, certifications, assessments, work experience, and/or fees, and are time-limited and must be renewed periodically.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("afe5d5c4-c39f-44aa-be3e-f337bb1ad8de"), Code="MasterCertificate", Description="Master Certificate", Definition="Credential awarded upon demonstration through apprenticeship of the highest level of skills and performance in industry trades and professions.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("0367ea2b-5868-4dfe-b6fa-5a30821a23ce"), Code="MasterDegree", Description="Master Degree", Definition="Credential awarded for a graduate level course of study where course work and activities advance skills beyond those of the bachelor's degree or its equivalent.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfa62069-c412-4498-8b4a-2db37fcea7b7"), Code="MicroCredential", Description="Micro Credential", Definition="Credential that addresses a subset of field-specific knowledge, skills, or competencies; often developmental with relationships to other micro-credentials and field credentials.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("b108f4b0-f89f-4bf7-bd1c-c1ca7c8c52d6"), Code="OpenBadge", Description="Open Badge", Definition="Visual symbol containing verifiable claims in accordance with the Open Badges specification and delivered digitally.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("2644785c-fad0-4ab3-aace-c98bb0ca9693"), Code="ProfessionalDoctorate", Description="Professional Doctorate", Definition="Doctoral degree conferred upon completion of a program providing the knowledge and skills for the recognition, credential, or license required for professional practice.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("291e7356-a05b-4bfc-99f6-9288cc223f5f"), Code="QualityAssuranceCredential", Description="Quality Assurance Credential", Definition="Credential assuring that an organization, program, or awarded credential meets prescribed requirements and may include development and administration of qualifying examinations.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("97817d4c-99e5-4e4f-915f-c6a26d1f4a1a"), Code="ResearchDoctorate", Description="Research Doctorate", Definition="Doctoral degree conferred for advanced work beyond the master level, including the preparation and defense of a thesis or dissertation based on original research, or the planning and execution of an original project demonstrating substantial artistic or scholarly achievement.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("af65c074-52e8-4239-a330-82f69f4f1649"), Code="SecondarySchoolDiploma", Description="Secondary School Diploma", Definition="Diploma awarded by secondary education institutions for successful completion of a secondary school program of study.", SortOrder=Convert.ToDecimal("23.00") },
        };
        #endregion

        #region RefONETSOCOccupationType List
        /// <summary>
        /// The complete Credential Definition Alternate Name List
        /// </summary>
        private static List<ReferenceModelBase> RefONETSOCOccupationTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
