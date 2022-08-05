//**********************************************************
//* DomainName: Autobahn.Competencies
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

        // member variable for the CompetencyFrameworkId property
        private Guid _CompetencyFrameworkId;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the URL property
        private System.String _URL;

        // member variable for the Type property
        private System.String _Type;

        // member variable for the Statement property
        private System.String _Statement;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the TypicalAgeRange property
        private System.String _TypicalAgeRange;

        // member variable for the TextComplexitySystem property
        private System.String _TextComplexitySystem;

        // member variable for the TextComplexityMinimumValue property
        private System.Decimal? _TextComplexityMinimumValue;

        // member variable for the TextComplexityMaximumValue property
        private System.Decimal? _TextComplexityMaximumValue;

        // member variable for the ConceptTerm property
        private System.String _ConceptTerm;

        // member variable for the ConceptKeyword property
        private System.String _ConceptKeyword;

        // member variable for the License property
        private System.String _License;

        // member variable for the Notes property
        private System.String _Notes;

        // member variable for the CompetencyDefParentId property
        private Guid _CompetencyDefParentId;

        // member variable for the CompetencyDefParentCode property
        private System.String _CompetencyDefParentCode;

        // member variable for the CompetencyDefParentUrl property
        private System.String _CompetencyDefParentUrl;

        // member variable for the ChildOf_CompetencyDefinitionId property
        private Guid? _ChildOf_CompetencyDefinitionId;

        // member variable for the CurrentVersionIndicator property
        private System.Boolean? _CurrentVersionIndicator;

        // member variable for the PreviousVersionIdentifier property
        private System.String _PreviousVersionIdentifier;

        // member variable for the ValidStartDate property
        private System.DateTime? _ValidStartDate;

        // member variable for the ValidEndDate property
        private System.DateTime? _ValidEndDate;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the CompetencyDefSequence property
        private System.String _CompetencyDefSequence;

        // member variable for the TypeURL property
        private System.String _TypeURL;

        // member variable for the TypicalAgeRangeMaximum property
        private System.Int32? _TypicalAgeRangeMaximum;

        // member variable for the TypicalAgeRangeMinimum property
        private System.Int32? _TypicalAgeRangeMinimum;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefBloomsTaxonomyDomainId property
        private Guid? _RefBloomsTaxonomyDomainId;

        // member variable for the RefMultipleIntelligenceTypeId property
        private Guid? _RefMultipleIntelligenceTypeId;

        // member variable for the RefCompetencyDefNodeAccessibilityProfileId property
        private Guid? _RefCompetencyDefNodeAccessibilityProfileId;

        // member variable for the RefCompetencyDefTestabilityTypeId property
        private Guid? _RefCompetencyDefTestabilityTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the CompetencyDefinitionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyFrameworkId"/> model
        /// </summary>
        public Guid CompetencyFrameworkId { get => _CompetencyFrameworkId; set => SetProperty(ref _CompetencyFrameworkId, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String URL  { get => _URL; set => SetProperty(ref _URL, value); }

        public System.String Type  { get => _Type; set => SetProperty(ref _Type, value); }

        public System.String Statement  { get => _Statement; set => SetProperty(ref _Statement, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.String TypicalAgeRange  { get => _TypicalAgeRange; set => SetProperty(ref _TypicalAgeRange, value); }

        public System.String TextComplexitySystem  { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        public System.Decimal? TextComplexityMinimumValue { get => _TextComplexityMinimumValue; set => SetProperty(ref _TextComplexityMinimumValue, value); }

        public System.Decimal? TextComplexityMaximumValue { get => _TextComplexityMaximumValue; set => SetProperty(ref _TextComplexityMaximumValue, value); }

        public System.String ConceptTerm  { get => _ConceptTerm; set => SetProperty(ref _ConceptTerm, value); }

        public System.String ConceptKeyword  { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        public System.String License  { get => _License; set => SetProperty(ref _License, value); }

        public System.String Notes  { get => _Notes; set => SetProperty(ref _Notes, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefParentId"/> model
        /// </summary>
        public Guid CompetencyDefParentId { get => _CompetencyDefParentId; set => SetProperty(ref _CompetencyDefParentId, value); }

        public System.String CompetencyDefParentCode  { get => _CompetencyDefParentCode; set => SetProperty(ref _CompetencyDefParentCode, value); }

        public System.String CompetencyDefParentUrl  { get => _CompetencyDefParentUrl; set => SetProperty(ref _CompetencyDefParentUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_CompetencyDefinitionId"/> model
        /// </summary>
        public Guid? ChildOf_CompetencyDefinitionId { get => _ChildOf_CompetencyDefinitionId; set => SetProperty(ref _ChildOf_CompetencyDefinitionId, value); }

        public System.Boolean? CurrentVersionIndicator { get => _CurrentVersionIndicator; set => SetProperty(ref _CurrentVersionIndicator, value); }

        public System.String PreviousVersionIdentifier  { get => _PreviousVersionIdentifier; set => SetProperty(ref _PreviousVersionIdentifier, value); }

        public System.DateTime? ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        public System.DateTime? ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        public System.String ShortName  { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        public System.String CompetencyDefSequence  { get => _CompetencyDefSequence; set => SetProperty(ref _CompetencyDefSequence, value); }

        public System.String TypeURL  { get => _TypeURL; set => SetProperty(ref _TypeURL, value); }

        public System.Int32? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        public System.Int32? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBloomsTaxonomyDomainId"/> model
        /// </summary>
        public Guid? RefBloomsTaxonomyDomainId { get => _RefBloomsTaxonomyDomainId; set => SetProperty(ref _RefBloomsTaxonomyDomainId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMultipleIntelligenceTypeId"/> model
        /// </summary>
        public Guid? RefMultipleIntelligenceTypeId { get => _RefMultipleIntelligenceTypeId; set => SetProperty(ref _RefMultipleIntelligenceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefNodeAccessibilityProfileId"/> model
        /// </summary>
        public Guid? RefCompetencyDefNodeAccessibilityProfileId { get => _RefCompetencyDefNodeAccessibilityProfileId; set => SetProperty(ref _RefCompetencyDefNodeAccessibilityProfileId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefTestabilityTypeId"/> model
        /// </summary>
        public Guid? RefCompetencyDefTestabilityTypeId { get => _RefCompetencyDefTestabilityTypeId; set => SetProperty(ref _RefCompetencyDefTestabilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencyFrameworkId = model.CompetencyFrameworkId;
            Identifier = model.Identifier;
            Code = model.Code;
            URL = model.URL;
            Type = model.Type;
            Statement = model.Statement;
            Version = model.Version;
            TypicalAgeRange = model.TypicalAgeRange;
            TextComplexitySystem = model.TextComplexitySystem;
            TextComplexityMinimumValue = model.TextComplexityMinimumValue;
            TextComplexityMaximumValue = model.TextComplexityMaximumValue;
            ConceptTerm = model.ConceptTerm;
            ConceptKeyword = model.ConceptKeyword;
            License = model.License;
            Notes = model.Notes;
            CompetencyDefParentId = model.CompetencyDefParentId;
            CompetencyDefParentCode = model.CompetencyDefParentCode;
            CompetencyDefParentUrl = model.CompetencyDefParentUrl;
            ChildOf_CompetencyDefinitionId = model.ChildOf_CompetencyDefinitionId;
            CurrentVersionIndicator = model.CurrentVersionIndicator;
            PreviousVersionIdentifier = model.PreviousVersionIdentifier;
            ValidStartDate = model.ValidStartDate;
            ValidEndDate = model.ValidEndDate;
            ShortName = model.ShortName;
            CompetencyDefSequence = model.CompetencyDefSequence;
            TypeURL = model.TypeURL;
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum;
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum;
            RefLanguageId = model.RefLanguageId;
            RefBloomsTaxonomyDomainId = model.RefBloomsTaxonomyDomainId;
            RefMultipleIntelligenceTypeId = model.RefMultipleIntelligenceTypeId;
            RefCompetencyDefNodeAccessibilityProfileId = model.RefCompetencyDefNodeAccessibilityProfileId;
            RefCompetencyDefTestabilityTypeId = model.RefCompetencyDefTestabilityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
