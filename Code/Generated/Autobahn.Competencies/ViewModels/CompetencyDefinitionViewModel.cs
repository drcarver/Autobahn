//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencyDefinitionViewModel
     /// </summary>
    public partial class CompetencyDefinitionViewModel : ViewModelBase, Interfaces.ICompetencyDefinition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CompetencyDefinition";

        // member variable for the ChildOfCompetencyDefinitionId property
        private Guid? _ChildOfCompetencyDefinitionId;

        // member variable for the CompetencyDefParentCode property
        private System.String _CompetencyDefParentCode;

        // member variable for the CompetencyDefParentId property
        private Guid _CompetencyDefParentId;

        // member variable for the CompetencyDefParentUrl property
        private System.String _CompetencyDefParentUrl;

        // member variable for the CompetencyDefSequence property
        private System.String _CompetencyDefSequence;

        // member variable for the CompetencyFrameworkId property
        private Guid _CompetencyFrameworkId;

        // member variable for the ConceptKeyword property
        private System.String _ConceptKeyword;

        // member variable for the ConceptTerm property
        private System.String _ConceptTerm;

        // member variable for the CurrentVersionIndicator property
        private System.Boolean? _CurrentVersionIndicator;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the License property
        private System.String _License;

        // member variable for the Notes property
        private System.String _Notes;

        // member variable for the PreviousVersionIdentifier property
        private System.String _PreviousVersionIdentifier;

        // member variable for the RefBloomsTaxonomyDomainId property
        private Guid? _RefBloomsTaxonomyDomainId;

        // member variable for the RefCompetencyDefNodeAccessibilityProfileId property
        private Guid? _RefCompetencyDefNodeAccessibilityProfileId;

        // member variable for the RefCompetencyDefTestabilityTypeId property
        private Guid? _RefCompetencyDefTestabilityTypeId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefMultipleIntelligenceTypeId property
        private Guid? _RefMultipleIntelligenceTypeId;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the Statement property
        private System.String _Statement;

        // member variable for the TextComplexityMaximumValue property
        private System.Decimal? _TextComplexityMaximumValue;

        // member variable for the TextComplexityMinimumValue property
        private System.Decimal? _TextComplexityMinimumValue;

        // member variable for the TextComplexitySystem property
        private System.String _TextComplexitySystem;

        // member variable for the Type property
        private System.String _Type;

        // member variable for the TypeURL property
        private System.String _TypeURL;

        // member variable for the TypicalAgeRange property
        private System.String _TypicalAgeRange;

        // member variable for the TypicalAgeRangeMaximum property
        private System.Int32? _TypicalAgeRangeMaximum;

        // member variable for the TypicalAgeRangeMinimum property
        private System.Int32? _TypicalAgeRangeMinimum;

        // member variable for the URL property
        private System.String _URL;

        // member variable for the ValidEndDate property
        private System.DateTime? _ValidEndDate;

        // member variable for the ValidStartDate property
        private System.DateTime? _ValidStartDate;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefinitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOfCompetencyDefinition"/> model
        /// </summary>
        public Guid? ChildOfCompetencyDefinitionId { get => _ChildOfCompetencyDefinitionId; set => SetProperty(ref _ChildOfCompetencyDefinitionId, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String CompetencyDefParentCode { get => _CompetencyDefParentCode; set => SetProperty(ref _CompetencyDefParentCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencyDefParent"/> model
        /// </summary>
        public Guid CompetencyDefParentId { get => _CompetencyDefParentId; set => SetProperty(ref _CompetencyDefParentId, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String CompetencyDefParentUrl { get => _CompetencyDefParentUrl; set => SetProperty(ref _CompetencyDefParentUrl, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String CompetencyDefSequence { get => _CompetencyDefSequence; set => SetProperty(ref _CompetencyDefSequence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencyFramework"/> model
        /// </summary>
        public Guid CompetencyFrameworkId { get => _CompetencyFrameworkId; set => SetProperty(ref _CompetencyFrameworkId, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String ConceptTerm { get => _ConceptTerm; set => SetProperty(ref _ConceptTerm, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.Boolean? CurrentVersionIndicator { get => _CurrentVersionIndicator; set => SetProperty(ref _CurrentVersionIndicator, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String Notes { get => _Notes; set => SetProperty(ref _Notes, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String PreviousVersionIdentifier { get => _PreviousVersionIdentifier; set => SetProperty(ref _PreviousVersionIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBloomsTaxonomyDomain"/> model
        /// </summary>
        public Guid? RefBloomsTaxonomyDomainId { get => _RefBloomsTaxonomyDomainId; set => SetProperty(ref _RefBloomsTaxonomyDomainId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefNodeAccessibilityProfile"/> model
        /// </summary>
        public Guid? RefCompetencyDefNodeAccessibilityProfileId { get => _RefCompetencyDefNodeAccessibilityProfileId; set => SetProperty(ref _RefCompetencyDefNodeAccessibilityProfileId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefTestabilityType"/> model
        /// </summary>
        public Guid? RefCompetencyDefTestabilityTypeId { get => _RefCompetencyDefTestabilityTypeId; set => SetProperty(ref _RefCompetencyDefTestabilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMultipleIntelligenceType"/> model
        /// </summary>
        public Guid? RefMultipleIntelligenceTypeId { get => _RefMultipleIntelligenceTypeId; set => SetProperty(ref _RefMultipleIntelligenceTypeId, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String Statement { get => _Statement; set => SetProperty(ref _Statement, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.Decimal? TextComplexityMaximumValue { get => _TextComplexityMaximumValue; set => SetProperty(ref _TextComplexityMaximumValue, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.Decimal? TextComplexityMinimumValue { get => _TextComplexityMinimumValue; set => SetProperty(ref _TextComplexityMinimumValue, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String Type { get => _Type; set => SetProperty(ref _Type, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String TypeURL { get => _TypeURL; set => SetProperty(ref _TypeURL, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String TypicalAgeRange { get => _TypicalAgeRange; set => SetProperty(ref _TypicalAgeRange, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.Int32? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.Int32? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.String URL { get => _URL; set => SetProperty(ref _URL, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.DateTime? ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
        /// </summary>
        public System.DateTime? ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
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
            ChildOfCompetencyDefinitionId = model.ChildOfCompetencyDefinitionId;
            CompetencyDefParentCode = model.CompetencyDefParentCode;
            CompetencyDefParentId = model.CompetencyDefParentId;
            CompetencyDefParentUrl = model.CompetencyDefParentUrl;
            CompetencyDefSequence = model.CompetencyDefSequence;
            CompetencyFrameworkId = model.CompetencyFrameworkId;
            ConceptKeyword = model.ConceptKeyword;
            ConceptTerm = model.ConceptTerm;
            CurrentVersionIndicator = model.CurrentVersionIndicator;
            Identifier = model.Identifier;
            License = model.License;
            Notes = model.Notes;
            PreviousVersionIdentifier = model.PreviousVersionIdentifier;
            RefBloomsTaxonomyDomainId = model.RefBloomsTaxonomyDomainId;
            RefCompetencyDefNodeAccessibilityProfileId = model.RefCompetencyDefNodeAccessibilityProfileId;
            RefCompetencyDefTestabilityTypeId = model.RefCompetencyDefTestabilityTypeId;
            RefLanguageId = model.RefLanguageId;
            RefMultipleIntelligenceTypeId = model.RefMultipleIntelligenceTypeId;
            ShortName = model.ShortName;
            Statement = model.Statement;
            TextComplexityMaximumValue = model.TextComplexityMaximumValue;
            TextComplexityMinimumValue = model.TextComplexityMinimumValue;
            TextComplexitySystem = model.TextComplexitySystem;
            Type = model.Type;
            TypeURL = model.TypeURL;
            TypicalAgeRange = model.TypicalAgeRange;
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum;
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum;
            URL = model.URL;
            ValidEndDate = model.ValidEndDate;
            ValidStartDate = model.ValidStartDate;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
