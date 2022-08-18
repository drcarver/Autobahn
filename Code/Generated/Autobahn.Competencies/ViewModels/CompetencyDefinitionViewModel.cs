//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefinition View Model
     /// </summary>
    public partial class CompetencyDefinitionViewModel : ViewModelBase, Interfaces.ICompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinition";

        // member variable for the ChildOfCompetencyDefinitionId property
        private Guid? _ChildOfCompetencyDefinitionId;

        // CompetencyDefParentCode -- (backing property for Competency Definition Parent Code)
        private System.String _CompetencyDefParentCode;

        // CompetencyDefParentId -- (backing property for Competency Definition Parent Identifier)
        private Guid _CompetencyDefParentId;

        // CompetencyDefParentUrl -- (backing property for Competency Definition Parent URL)
        private System.String _CompetencyDefParentUrl;

        // CompetencyDefSequence -- (backing property for Competency Definition Sequence)
        private System.String _CompetencyDefSequence;

        // member variable for the CompetencyFrameworkId property
        private Guid _CompetencyFrameworkId;

        // ConceptKeyword -- (backing property for Competency Definition Concept Keyword)
        private System.String _ConceptKeyword;

        // ConceptTerm -- (backing property for Competency Definition Concept Term)
        private System.String _ConceptTerm;

        // CurrentVersionIndicator -- (backing property for Competency Definition Current Version Indicator)
        private System.Boolean? _CurrentVersionIndicator;

        // Identifier -- (backing property for Competency Definition Identifier)
        private System.String _Identifier;

        // License -- (backing property for Competency Definition License)
        private System.String _License;

        // Notes -- (backing property for Competency Definition Notes)
        private System.String _Notes;

        // PreviousVersionIdentifier -- (backing property for Competency Definition Previous Version Identifier)
        private System.String _PreviousVersionIdentifier;

        // RefBloomsTaxonomyDomainId -- (backing property for Competency Definition Blooms Taxonomy Domain)
        private Guid? _RefBloomsTaxonomyDomainId;

        // RefCompetencyDefNodeAccessibilityProfileId -- (backing property for Competency Definition Node Accessibility Profile)
        private Guid? _RefCompetencyDefNodeAccessibilityProfileId;

        // RefCompetencyDefTestabilityTypeId -- (backing property for Competency Definition Testability Type)
        private Guid? _RefCompetencyDefTestabilityTypeId;

        // RefLanguageId -- (backing property for Competency Definition Language)
        private Guid? _RefLanguageId;

        // RefMultipleIntelligenceTypeId -- (backing property for Competency Definition Multiple Intelligence)
        private Guid? _RefMultipleIntelligenceTypeId;

        // ShortName -- (backing property for Competency Definition Short Name)
        private System.String _ShortName;

        // Statement -- (backing property for Competency Definition Statement)
        private System.String _Statement;

        // TextComplexityMaximumValue -- (backing property for Competency Definition Text Complexity Maximum Value)
        private System.Decimal? _TextComplexityMaximumValue;

        // TextComplexityMinimumValue -- (backing property for Competency Definition Text Complexity Minimum Value)
        private System.Decimal? _TextComplexityMinimumValue;

        // TextComplexitySystem -- (backing property for Competency Definition Text Complexity System)
        private System.String _TextComplexitySystem;

        // Type -- (backing property for Competency Definition Type)
        private System.String _Type;

        // TypeURL -- (backing property for Competency Definition Type URL)
        private System.String _TypeURL;

        // member variable for the TypicalAgeRange property
        private System.String _TypicalAgeRange;

        // TypicalAgeRangeMaximum -- (backing property for Competency Definition Typical Age Range Maximum)
        private System.Int32? _TypicalAgeRangeMaximum;

        // TypicalAgeRangeMinimum -- (backing property for Competency Definition Typical Age Range Minimum)
        private System.Int32? _TypicalAgeRangeMinimum;

        // URL -- (backing property for Competency Definition URL)
        private System.String _URL;

        // ValidEndDate -- (backing property for Competency Definition Valid End Date)
        private System.DateTime? _ValidEndDate;

        // ValidStartDate -- (backing property for Competency Definition Valid Start Date)
        private System.DateTime? _ValidStartDate;

        // Version -- (backing property for Competency Definition Version)
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IChildOfCompetencyDefinition"/> model
        /// </summary>
        public Guid? ChildOfCompetencyDefinitionId { get => _ChildOfCompetencyDefinitionId; set => SetProperty(ref _ChildOfCompetencyDefinitionId, value); }

        /// <summary>
        /// Competency Definition Parent Code
        /// <para>
        /// A human-referenceable code designated by the publisher to identify the parent item in the hierarchy of competency definitions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19873">Competency Definition Parent Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CompetencyDefParentCode { get => _CompetencyDefParentCode; set => SetProperty(ref _CompetencyDefParentCode, value); }

        /// <summary>
        /// Competency Definition Parent Identifier
        /// <para>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the parent item in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19872">Competency Definition Parent Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid CompetencyDefParentId { get => _CompetencyDefParentId; set => SetProperty(ref _CompetencyDefParentId, value); }

        /// <summary>
        /// Competency Definition Parent URL
        /// <para>
        /// A network-resolvable Uniform Resource Locator (URL) pointing to the authoritative reference for the hierarchal parent of the competency definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20078">Competency Definition Parent URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CompetencyDefParentUrl { get => _CompetencyDefParentUrl; set => SetProperty(ref _CompetencyDefParentUrl, value); }

        /// <summary>
        /// Competency Definition Sequence
        /// <para>
        /// A set of one or more alphanumeric characters and/or symbols denoting the positioning of the statement being described in a sequential listing of statements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20549">Competency Definition Sequence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CompetencyDefSequence { get => _CompetencyDefSequence; set => SetProperty(ref _CompetencyDefSequence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyFramework"/> model
        /// </summary>
        public Guid CompetencyFrameworkId { get => _CompetencyFrameworkId; set => SetProperty(ref _CompetencyFrameworkId, value); }

        /// <summary>
        /// Competency Definition Concept Keyword
        /// <para>
        /// The significant topicality of the competency definition using free-text keywords and phrases.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19887">Competency Definition Concept Keyword</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// Competency Definition Concept Term
        /// <para>
        /// The topicality of the competency definition, e.g. "Pythagorean Theorem," "Trigonometric functions," "Forces and energy," "Scientific method," "Oral history," etc.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19888">Competency Definition Concept Term</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ConceptTerm { get => _ConceptTerm; set => SetProperty(ref _ConceptTerm, value); }

        /// <summary>
        /// Competency Definition Current Version Indicator
        /// <para>
        /// Indicates that this is the most current version of the Competency Definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20499">Competency Definition Current Version Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CurrentVersionIndicator { get => _CurrentVersionIndicator; set => SetProperty(ref _CurrentVersionIndicator, value); }

        /// <summary>
        /// Competency Definition Identifier
        /// <para>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19666">Competency Definition Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Competency Definition License
        /// <para>
        /// The full text or URL reference to a legal document giving official permission to do something with the competency definition statement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19883">Competency Definition License</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// Competency Definition Notes
        /// <para>
        /// Information about the derivation of a Competency Definition Statement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20215">Competency Definition Notes</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Notes { get => _Notes; set => SetProperty(ref _Notes, value); }

        /// <summary>
        /// Competency Definition Previous Version Identifier
        /// <para>
        /// The unique identifier of the previous version of the Competency Definition if the statement was modified.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20498">Competency Definition Previous Version Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PreviousVersionIdentifier { get => _PreviousVersionIdentifier; set => SetProperty(ref _PreviousVersionIdentifier, value); }

        /// <summary>
        /// Competency Definition Blooms Taxonomy Domain
        /// <para>
        /// Classification of the Competency Definition using Bloom's Taxonomy Domains.�
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19875">Competency Definition Blooms Taxonomy Domain</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBloomsTaxonomyDomainId { get => _RefBloomsTaxonomyDomainId; set => SetProperty(ref _RefBloomsTaxonomyDomainId, value); }

        /// <summary>
        /// Competency Definition Node Accessibility Profile
        /// <para>
        /// When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20377">Competency Definition Node Accessibility Profile</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCompetencyDefNodeAccessibilityProfileId { get => _RefCompetencyDefNodeAccessibilityProfileId; set => SetProperty(ref _RefCompetencyDefNodeAccessibilityProfileId, value); }

        /// <summary>
        /// Competency Definition Testability Type
        /// <para>
        /// Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20380">Competency Definition Testability Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCompetencyDefTestabilityTypeId { get => _RefCompetencyDefTestabilityTypeId; set => SetProperty(ref _RefCompetencyDefTestabilityTypeId, value); }

        /// <summary>
        /// Competency Definition Language
        /// <para>
        /// The default language of the text used for the content in the competency definition statement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19881">Competency Definition Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Competency Definition Multiple Intelligence
        /// <para>
        /// Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19876">Competency Definition Multiple Intelligence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMultipleIntelligenceTypeId { get => _RefMultipleIntelligenceTypeId; set => SetProperty(ref _RefMultipleIntelligenceTypeId, value); }

        /// <summary>
        /// Competency Definition Short Name
        /// <para>
        /// The short name or label for the competency definition or its node in a competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20378">Competency Definition Short Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// Competency Definition Statement
        /// <para>
        /// The text of the statement. The textual content that either describes a specific competency or describes a less granular group of competencies within the taxonomy of the competency framework.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19667">Competency Definition Statement</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Statement { get => _Statement; set => SetProperty(ref _Statement, value); }

        /// <summary>
        /// Competency Definition Text Complexity Maximum Value
        /// <para>
        /// The maximum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20115">Competency Definition Text Complexity Maximum Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? TextComplexityMaximumValue { get => _TextComplexityMaximumValue; set => SetProperty(ref _TextComplexityMaximumValue, value); }

        /// <summary>
        /// Competency Definition Text Complexity Minimum Value
        /// <para>
        /// The minimum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20114">Competency Definition Text Complexity Minimum Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? TextComplexityMinimumValue { get => _TextComplexityMinimumValue; set => SetProperty(ref _TextComplexityMinimumValue, value); }

        /// <summary>
        /// Competency Definition Text Complexity System
        /// <para>
        /// The scaling system used to specify the text complexity of a competency item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19910">Competency Definition Text Complexity System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// Competency Definition Type
        /// <para>
        /// The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a textual label.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19668">Competency Definition Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Type { get => _Type; set => SetProperty(ref _Type, value); }

        /// <summary>
        /// Competency Definition Type URL
        /// <para>
        /// The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a URI referencing a controlled vocabulary.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20738">Competency Definition Type URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TypeURL { get => _TypeURL; set => SetProperty(ref _TypeURL, value); }

        public System.String TypicalAgeRange { get => _TypicalAgeRange; set => SetProperty(ref _TypicalAgeRange, value); }

        /// <summary>
        /// Competency Definition Typical Age Range Maximum
        /// <para>
        /// The typical maximum age at which a person learns the defined competency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20890">Competency Definition Typical Age Range Maximum</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// Competency Definition Typical Age Range Minimum
        /// <para>
        /// The typical minimum age at which a person learns the defined competency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20889">Competency Definition Typical Age Range Minimum</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// Competency Definition URL
        /// <para>
        /// A network-resolvable Uniform Resource Locator (URL) pointing to the authoritative reference for the competency definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19874">Competency Definition URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String URL { get => _URL; set => SetProperty(ref _URL, value); }

        /// <summary>
        /// Competency Definition Valid End Date
        /// <para>
        /// The year, month and day the competency definition was deprecated/replaced by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20483">Competency Definition Valid End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// Competency Definition Valid Start Date
        /// <para>
        /// The year, month and day the competency definition was adopted by the jurisdiction in which it was intended to apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20484">Competency Definition Valid Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// Competency Definition Version
        /// <para>
        /// A label assigned by the publisher indicating the version of the competency framework statement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20216">Competency Definition Version</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildOfCompetencyDefinitionId = model.ChildOfCompetencyDefinitionId; // 
            CompetencyDefParentCode = model.CompetencyDefParentCode; // Competency Definition Parent Code
            CompetencyDefParentId = model.CompetencyDefParentId; // Competency Definition Parent Identifier
            CompetencyDefParentUrl = model.CompetencyDefParentUrl; // Competency Definition Parent URL
            CompetencyDefSequence = model.CompetencyDefSequence; // Competency Definition Sequence
            CompetencyFrameworkId = model.CompetencyFrameworkId; // 
            ConceptKeyword = model.ConceptKeyword; // Competency Definition Concept Keyword
            ConceptTerm = model.ConceptTerm; // Competency Definition Concept Term
            CurrentVersionIndicator = model.CurrentVersionIndicator; // Competency Definition Current Version Indicator
            Identifier = model.Identifier; // Competency Definition Identifier
            License = model.License; // Competency Definition License
            Notes = model.Notes; // Competency Definition Notes
            PreviousVersionIdentifier = model.PreviousVersionIdentifier; // Competency Definition Previous Version Identifier
            RefBloomsTaxonomyDomainId = model.RefBloomsTaxonomyDomainId; // Competency Definition Blooms Taxonomy Domain
            RefCompetencyDefNodeAccessibilityProfileId = model.RefCompetencyDefNodeAccessibilityProfileId; // Competency Definition Node Accessibility Profile
            RefCompetencyDefTestabilityTypeId = model.RefCompetencyDefTestabilityTypeId; // Competency Definition Testability Type
            RefLanguageId = model.RefLanguageId; // Competency Definition Language
            RefMultipleIntelligenceTypeId = model.RefMultipleIntelligenceTypeId; // Competency Definition Multiple Intelligence
            ShortName = model.ShortName; // Competency Definition Short Name
            Statement = model.Statement; // Competency Definition Statement
            TextComplexityMaximumValue = model.TextComplexityMaximumValue; // Competency Definition Text Complexity Maximum Value
            TextComplexityMinimumValue = model.TextComplexityMinimumValue; // Competency Definition Text Complexity Minimum Value
            TextComplexitySystem = model.TextComplexitySystem; // Competency Definition Text Complexity System
            Type = model.Type; // Competency Definition Type
            TypeURL = model.TypeURL; // Competency Definition Type URL
            TypicalAgeRange = model.TypicalAgeRange; // 
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // Competency Definition Typical Age Range Maximum
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // Competency Definition Typical Age Range Minimum
            URL = model.URL; // Competency Definition URL
            ValidEndDate = model.ValidEndDate; // Competency Definition Valid End Date
            ValidStartDate = model.ValidStartDate; // Competency Definition Valid Start Date
            Version = model.Version; // Competency Definition Version
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMultipleIntelligenceType List
        /// <summary>
        /// The complete <see cref="RefMultipleIntelligenceType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMultipleIntelligenceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c11aa9e2-69e5-45d3-b59d-ad1393888785"), Code="Linguistic", Description="Linguistic", Definition="The learning standard item or competency fits into the Linguistic intelligence modality. ", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("22a21eaf-cbb6-4ef6-b0c1-dbc2a3065eaf"), Code="Logic-mathematical", Description="Logic-mathematical", Definition="The learning standard item or competency fits into the Logic-mathematical intelligence modality.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("38cf0c16-86bc-4dd1-a267-a84588470984"), Code="Musical", Description="Musical", Definition="The learning standard item or competency fits into the Musical intelligence modality.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("f44c6430-4e66-4c65-97d2-cc5e3bcf13ba"), Code="Spatial", Description="Spatial", Definition="The learning standard item or competency fits into the Spatial intelligence modality.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d7e1dcf-2e5c-4170-8e38-b7830cea5a96"), Code="BodilyKinesthetic", Description="Bodily/kinesthetic", Definition="The learning standard item or competency fits into the Bodily/kinesthetic intelligence modality.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd9858d0-4d68-453f-b977-0015147f1be6"), Code="Interpersonal", Description="Interpersonal", Definition="The learning standard item or competency fits into the Interpersonal intelligence modality.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("465ac233-102c-4393-8959-1c1c748e876a"), Code="Intrapersonal", Description="Intrapersonal", Definition="The learning standard item or competency fits into the Intrapersonal intelligence modality.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("1ed5c14a-4a8f-4a7b-95e0-f03524118fec"), Code="Naturalistic", Description="Naturalistic", Definition="The learning standard item or competency fits into the Naturalistic intelligence modality.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion
    }
}
