//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItem";

        // member variable for the AdaptiveIndicator property
        private  _AdaptiveIndicator;

        // member variable for the AllottedTime property
        private  _AllottedTime;

        // member variable for the AssessmentFormSectionItemFieldTestIndicator property
        private  _AssessmentFormSectionItemFieldTestIndicator;

        // member variable for the AssessmentItemBankIdentifier property
        private  _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private  _AssessmentItemBankName;

        // member variable for the BodyText property
        private  _BodyText;

        // member variable for the Difficulty property
        private  _Difficulty;

        // member variable for the DistractorAnalysis property
        private  _DistractorAnalysis;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the LinkingItemIndicator property
        private  _LinkingItemIndicator;

        // member variable for the MaximumScore property
        private  _MaximumScore;

        // member variable for the MinimumScore property
        private  _MinimumScore;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentItemTypeId property
        private Guid? _RefAssessmentItemTypeId;

        // member variable for the RefNaepAspectsOfReadingId property
        private  _RefNaepAspectsOfReadingId;

        // member variable for the RefNaepMathComplexityLevelId property
        private  _RefNaepMathComplexityLevelId;

        // member variable for the RefTextComplexitySystemId property
        private  _RefTextComplexitySystemId;

        // member variable for the ReleaseStatus property
        private  _ReleaseStatus;

        // member variable for the Stem property
        private  _Stem;

        // member variable for the Stimulus property
        private  _Stimulus;

        // member variable for the TextComplexityValue property
        private  _TextComplexityValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        /// <summary>
        /// </summary>
        public  AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFormSectionItemFieldTestIndicator { get => _AssessmentFormSectionItemFieldTestIndicator; set => SetProperty(ref _AssessmentFormSectionItemFieldTestIndicator, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// </summary>
        public  BodyText { get => _BodyText; set => SetProperty(ref _BodyText, value); }

        /// <summary>
        /// </summary>
        public  Difficulty { get => _Difficulty; set => SetProperty(ref _Difficulty, value); }

        /// <summary>
        /// </summary>
        public  DistractorAnalysis { get => _DistractorAnalysis; set => SetProperty(ref _DistractorAnalysis, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  LinkingItemIndicator { get => _LinkingItemIndicator; set => SetProperty(ref _LinkingItemIndicator, value); }

        /// <summary>
        /// </summary>
        public  MaximumScore { get => _MaximumScore; set => SetProperty(ref _MaximumScore, value); }

        /// <summary>
        /// </summary>
        public  MinimumScore { get => _MinimumScore; set => SetProperty(ref _MinimumScore, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemType"/> model
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get => _RefAssessmentItemTypeId; set => SetProperty(ref _RefAssessmentItemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReading"/> model
        /// </summary>
        public  RefNaepAspectsOfReadingId { get => _RefNaepAspectsOfReadingId; set => SetProperty(ref _RefNaepAspectsOfReadingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepMathComplexityLevel"/> model
        /// </summary>
        public  RefNaepMathComplexityLevelId { get => _RefNaepMathComplexityLevelId; set => SetProperty(ref _RefNaepMathComplexityLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystem"/> model
        /// </summary>
        public  RefTextComplexitySystemId { get => _RefTextComplexitySystemId; set => SetProperty(ref _RefTextComplexitySystemId, value); }

        /// <summary>
        /// </summary>
        public  ReleaseStatus { get => _ReleaseStatus; set => SetProperty(ref _ReleaseStatus, value); }

        /// <summary>
        /// </summary>
        public  Stem { get => _Stem; set => SetProperty(ref _Stem, value); }

        /// <summary>
        /// </summary>
        public  Stimulus { get => _Stimulus; set => SetProperty(ref _Stimulus, value); }

        /// <summary>
        /// </summary>
        public  TextComplexityValue { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptiveIndicator = model.AdaptiveIndicator; // 
            AllottedTime = model.AllottedTime; // 
            AssessmentFormSectionItemFieldTestIndicator = model.AssessmentFormSectionItemFieldTestIndicator; // 
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // 
            AssessmentItemBankName = model.AssessmentItemBankName; // 
            BodyText = model.BodyText; // 
            Difficulty = model.Difficulty; // 
            DistractorAnalysis = model.DistractorAnalysis; // 
            Identifier = model.Identifier; // 
            LinkingItemIndicator = model.LinkingItemIndicator; // 
            MaximumScore = model.MaximumScore; // 
            MinimumScore = model.MinimumScore; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentItemTypeId = model.RefAssessmentItemTypeId; // 
            RefNaepAspectsOfReadingId = model.RefNaepAspectsOfReadingId; // 
            RefNaepMathComplexityLevelId = model.RefNaepMathComplexityLevelId; // 
            RefTextComplexitySystemId = model.RefTextComplexitySystemId; // 
            ReleaseStatus = model.ReleaseStatus; // 
            Stem = model.Stem; // 
            Stimulus = model.Stimulus; // 
            TextComplexityValue = model.TextComplexityValue; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
