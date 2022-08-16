//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the Code property
        private  _Code;

        // member variable for the CompetencyDefParentCode property
        private  _CompetencyDefParentCode;

        // member variable for the CompetencyDefParentId property
        private  _CompetencyDefParentId;

        // member variable for the CompetencyDefParentUrl property
        private  _CompetencyDefParentUrl;

        // member variable for the CompetencyDefSequence property
        private  _CompetencyDefSequence;

        // member variable for the ConceptKeyword property
        private  _ConceptKeyword;

        // member variable for the ConceptTerm property
        private  _ConceptTerm;

        // member variable for the CurrentVersionIndicator property
        private  _CurrentVersionIndicator;

        // member variable for the Identifier property
        private Guid? _Identifier;

        // member variable for the License property
        private  _License;

        // member variable for the Notes property
        private  _Notes;

        // member variable for the PreviousVersionIdentifier property
        private  _PreviousVersionIdentifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBloomsTaxonomyDomainId property
        private  _RefBloomsTaxonomyDomainId;

        // member variable for the RefCompetencyDefNodeAccessibilityProfileId property
        private  _RefCompetencyDefNodeAccessibilityProfileId;

        // member variable for the RefCompetencyDefTestabilityTypeId property
        private  _RefCompetencyDefTestabilityTypeId;

        // member variable for the RefLanguageId property
        private  _RefLanguageId;

        // member variable for the RefMultipleIntelligenceTypeId property
        private  _RefMultipleIntelligenceTypeId;

        // member variable for the ShortName property
        private  _ShortName;

        // member variable for the Statement property
        private  _Statement;

        // member variable for the TextComplexityMaximumValue property
        private  _TextComplexityMaximumValue;

        // member variable for the TextComplexityMinimumValue property
        private  _TextComplexityMinimumValue;

        // member variable for the TextComplexitySystem property
        private  _TextComplexitySystem;

        // member variable for the Type property
        private  _Type;

        // member variable for the TypeURL property
        private  _TypeURL;

        // member variable for the TypicalAgeRangeMaximum property
        private  _TypicalAgeRangeMaximum;

        // member variable for the TypicalAgeRangeMinimum property
        private  _TypicalAgeRangeMinimum;

        // member variable for the URL property
        private  _URL;

        // member variable for the ValidEndDate property
        private  _ValidEndDate;

        // member variable for the ValidStartDate property
        private  _ValidStartDate;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Code { get => _Code; set => SetProperty(ref _Code, value); }

        /// <summary>
        /// </summary>
        public  CompetencyDefParentCode { get => _CompetencyDefParentCode; set => SetProperty(ref _CompetencyDefParentCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencyDefParent"/> model
        /// </summary>
        public  CompetencyDefParentId { get => _CompetencyDefParentId; set => SetProperty(ref _CompetencyDefParentId, value); }

        /// <summary>
        /// </summary>
        public  CompetencyDefParentUrl { get => _CompetencyDefParentUrl; set => SetProperty(ref _CompetencyDefParentUrl, value); }

        /// <summary>
        /// </summary>
        public  CompetencyDefSequence { get => _CompetencyDefSequence; set => SetProperty(ref _CompetencyDefSequence, value); }

        /// <summary>
        /// </summary>
        public  ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// </summary>
        public  ConceptTerm { get => _ConceptTerm; set => SetProperty(ref _ConceptTerm, value); }

        /// <summary>
        /// </summary>
        public  CurrentVersionIndicator { get => _CurrentVersionIndicator; set => SetProperty(ref _CurrentVersionIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  License { get => _License; set => SetProperty(ref _License, value); }

        /// <summary>
        /// </summary>
        public  Notes { get => _Notes; set => SetProperty(ref _Notes, value); }

        /// <summary>
        /// </summary>
        public  PreviousVersionIdentifier { get => _PreviousVersionIdentifier; set => SetProperty(ref _PreviousVersionIdentifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBloomsTaxonomyDomain"/> model
        /// </summary>
        public  RefBloomsTaxonomyDomainId { get => _RefBloomsTaxonomyDomainId; set => SetProperty(ref _RefBloomsTaxonomyDomainId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefNodeAccessibilityProfile"/> model
        /// </summary>
        public  RefCompetencyDefNodeAccessibilityProfileId { get => _RefCompetencyDefNodeAccessibilityProfileId; set => SetProperty(ref _RefCompetencyDefNodeAccessibilityProfileId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefTestabilityType"/> model
        /// </summary>
        public  RefCompetencyDefTestabilityTypeId { get => _RefCompetencyDefTestabilityTypeId; set => SetProperty(ref _RefCompetencyDefTestabilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public  RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMultipleIntelligenceType"/> model
        /// </summary>
        public  RefMultipleIntelligenceTypeId { get => _RefMultipleIntelligenceTypeId; set => SetProperty(ref _RefMultipleIntelligenceTypeId, value); }

        /// <summary>
        /// </summary>
        public  ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// </summary>
        public  Statement { get => _Statement; set => SetProperty(ref _Statement, value); }

        /// <summary>
        /// </summary>
        public  TextComplexityMaximumValue { get => _TextComplexityMaximumValue; set => SetProperty(ref _TextComplexityMaximumValue, value); }

        /// <summary>
        /// </summary>
        public  TextComplexityMinimumValue { get => _TextComplexityMinimumValue; set => SetProperty(ref _TextComplexityMinimumValue, value); }

        /// <summary>
        /// </summary>
        public  TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// </summary>
        public  Type { get => _Type; set => SetProperty(ref _Type, value); }

        /// <summary>
        /// </summary>
        public  TypeURL { get => _TypeURL; set => SetProperty(ref _TypeURL, value); }

        /// <summary>
        /// </summary>
        public  TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// </summary>
        public  TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// </summary>
        public  URL { get => _URL; set => SetProperty(ref _URL, value); }

        /// <summary>
        /// </summary>
        public  ValidEndDate { get => _ValidEndDate; set => SetProperty(ref _ValidEndDate, value); }

        /// <summary>
        /// </summary>
        public  ValidStartDate { get => _ValidStartDate; set => SetProperty(ref _ValidStartDate, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICompetencyDefinition model)
        {
            IsBusy = true;
            Id = model.Id;
            Code = model.Code; // 
            CompetencyDefParentCode = model.CompetencyDefParentCode; // 
            CompetencyDefParentId = model.CompetencyDefParentId; // 
            CompetencyDefParentUrl = model.CompetencyDefParentUrl; // 
            CompetencyDefSequence = model.CompetencyDefSequence; // 
            ConceptKeyword = model.ConceptKeyword; // 
            ConceptTerm = model.ConceptTerm; // 
            CurrentVersionIndicator = model.CurrentVersionIndicator; // 
            Identifier = model.Identifier; // 
            License = model.License; // 
            Notes = model.Notes; // 
            PreviousVersionIdentifier = model.PreviousVersionIdentifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBloomsTaxonomyDomainId = model.RefBloomsTaxonomyDomainId; // 
            RefCompetencyDefNodeAccessibilityProfileId = model.RefCompetencyDefNodeAccessibilityProfileId; // 
            RefCompetencyDefTestabilityTypeId = model.RefCompetencyDefTestabilityTypeId; // 
            RefLanguageId = model.RefLanguageId; // 
            RefMultipleIntelligenceTypeId = model.RefMultipleIntelligenceTypeId; // 
            ShortName = model.ShortName; // 
            Statement = model.Statement; // 
            TextComplexityMaximumValue = model.TextComplexityMaximumValue; // 
            TextComplexityMinimumValue = model.TextComplexityMinimumValue; // 
            TextComplexitySystem = model.TextComplexitySystem; // 
            Type = model.Type; // 
            TypeURL = model.TypeURL; // 
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // 
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // 
            URL = model.URL; // 
            ValidEndDate = model.ValidEndDate; // 
            ValidStartDate = model.ValidStartDate; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
