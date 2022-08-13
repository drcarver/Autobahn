//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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
        private System.Boolean? _AdaptiveIndicator;

        // member variable for the AllottedTime property
        private System.TimeSpan? _AllottedTime;

        // member variable for the AssessmentFormSectionItemFieldTestIndicator property
        private System.Boolean? _AssessmentFormSectionItemFieldTestIndicator;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the BodyText property
        private System.String _BodyText;

        // member variable for the Difficulty property
        private System.Decimal? _Difficulty;

        // member variable for the DistractorAnalysis property
        private System.String _DistractorAnalysis;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the LinkingItemIndicator property
        private System.Boolean? _LinkingItemIndicator;

        // member variable for the MaximumScore property
        private System.String _MaximumScore;

        // member variable for the MinimumScore property
        private System.String _MinimumScore;

        // member variable for the RefAssessmentItemTypeId property
        private Guid? _RefAssessmentItemTypeId;

        // member variable for the RefNaepAspectsOfReadingId property
        private Guid? _RefNaepAspectsOfReadingId;

        // member variable for the RefNaepMathComplexityLevelId property
        private Guid? _RefNaepMathComplexityLevelId;

        // member variable for the RefTextComplexitySystemId property
        private Guid? _RefTextComplexitySystemId;

        // member variable for the ReleaseStatus property
        private System.Boolean? _ReleaseStatus;

        // member variable for the RubricId property
        private Guid? _RubricId;

        // member variable for the Stem property
        private System.String _Stem;

        // member variable for the Stimulus property
        private System.String _Stimulus;

        // member variable for the TextComplexityValue property
        private System.String _TextComplexityValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.TimeSpan? AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get => _AssessmentFormSectionItemFieldTestIndicator; set => SetProperty(ref _AssessmentFormSectionItemFieldTestIndicator, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String BodyText { get => _BodyText; set => SetProperty(ref _BodyText, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Decimal? Difficulty { get => _Difficulty; set => SetProperty(ref _Difficulty, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String DistractorAnalysis { get => _DistractorAnalysis; set => SetProperty(ref _DistractorAnalysis, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? LinkingItemIndicator { get => _LinkingItemIndicator; set => SetProperty(ref _LinkingItemIndicator, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String MaximumScore { get => _MaximumScore; set => SetProperty(ref _MaximumScore, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String MinimumScore { get => _MinimumScore; set => SetProperty(ref _MinimumScore, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemType"/> model
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get => _RefAssessmentItemTypeId; set => SetProperty(ref _RefAssessmentItemTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReading"/> model
        /// </summary>
        public Guid? RefNaepAspectsOfReadingId { get => _RefNaepAspectsOfReadingId; set => SetProperty(ref _RefNaepAspectsOfReadingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepMathComplexityLevel"/> model
        /// </summary>
        public Guid? RefNaepMathComplexityLevelId { get => _RefNaepMathComplexityLevelId; set => SetProperty(ref _RefNaepMathComplexityLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystem"/> model
        /// </summary>
        public Guid? RefTextComplexitySystemId { get => _RefTextComplexitySystemId; set => SetProperty(ref _RefTextComplexitySystemId, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.Boolean? ReleaseStatus { get => _ReleaseStatus; set => SetProperty(ref _ReleaseStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid? RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Stem { get => _Stem; set => SetProperty(ref _Stem, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String Stimulus { get => _Stimulus; set => SetProperty(ref _Stimulus, value); }

        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public System.String TextComplexityValue { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptiveIndicator = model.AdaptiveIndicator;
            AllottedTime = model.AllottedTime;
            AssessmentFormSectionItemFieldTestIndicator = model.AssessmentFormSectionItemFieldTestIndicator;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            BodyText = model.BodyText;
            Difficulty = model.Difficulty;
            DistractorAnalysis = model.DistractorAnalysis;
            Identifier = model.Identifier;
            LearningResourceId = model.LearningResourceId;
            LinkingItemIndicator = model.LinkingItemIndicator;
            MaximumScore = model.MaximumScore;
            MinimumScore = model.MinimumScore;
            RefAssessmentItemTypeId = model.RefAssessmentItemTypeId;
            RefNaepAspectsOfReadingId = model.RefNaepAspectsOfReadingId;
            RefNaepMathComplexityLevelId = model.RefNaepMathComplexityLevelId;
            RefTextComplexitySystemId = model.RefTextComplexitySystemId;
            ReleaseStatus = model.ReleaseStatus;
            RubricId = model.RubricId;
            Stem = model.Stem;
            Stimulus = model.Stimulus;
            TextComplexityValue = model.TextComplexityValue;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
