//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentItem
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItem";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the RefAssessmentItemTypeId property
        private Guid? _RefAssessmentItemTypeId;

        // member variable for the BodyText property
        private System.String _BodyText;

        // member variable for the Stimulus property
        private System.String _Stimulus;

        // member variable for the Stem property
        private System.String _Stem;

        // member variable for the AdaptiveIndicator property
        private System.Boolean? _AdaptiveIndicator;

        // member variable for the MaximumScore property
        private System.String _MaximumScore;

        // member variable for the MinimumScore property
        private System.String _MinimumScore;

        // member variable for the DistractorAnalysis property
        private System.String _DistractorAnalysis;

        // member variable for the AllottedTime property
        private System.TimeSpan? _AllottedTime;

        // member variable for the RefNaepMathComplexityLevelId property
        private Guid? _RefNaepMathComplexityLevelId;

        // member variable for the RefNaepAspectsOfReadingId property
        private Guid? _RefNaepAspectsOfReadingId;

        // member variable for the Difficulty property
        private System.Decimal? _Difficulty;

        // member variable for the RefTextComplexitySystemId property
        private Guid? _RefTextComplexitySystemId;

        // member variable for the TextComplexityValue property
        private System.String _TextComplexityValue;

        // member variable for the LinkingItemIndicator property
        private System.Boolean? _LinkingItemIndicator;

        // member variable for the ReleaseStatus property
        private System.Boolean? _ReleaseStatus;

        // member variable for the RubricId property
        private Guid? _RubricId;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the AssessmentFormSectionItemFieldTestIndicator property
        private System.Boolean? _AssessmentFormSectionItemFieldTestIndicator;

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
        /// The title of the AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String AssessmentItemBankIdentifier  { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        public System.String AssessmentItemBankName  { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get => _RefAssessmentItemTypeId; set => SetProperty(ref _RefAssessmentItemTypeId, value); }

        public System.String BodyText  { get => _BodyText; set => SetProperty(ref _BodyText, value); }

        public System.String Stimulus  { get => _Stimulus; set => SetProperty(ref _Stimulus, value); }

        public System.String Stem  { get => _Stem; set => SetProperty(ref _Stem, value); }

        public System.Boolean? AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        public System.String MaximumScore  { get => _MaximumScore; set => SetProperty(ref _MaximumScore, value); }

        public System.String MinimumScore  { get => _MinimumScore; set => SetProperty(ref _MinimumScore, value); }

        public System.String DistractorAnalysis  { get => _DistractorAnalysis; set => SetProperty(ref _DistractorAnalysis, value); }

        public System.TimeSpan? AllottedTime { get => _AllottedTime; set => SetProperty(ref _AllottedTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepMathComplexityLevelId"/> model
        /// </summary>
        public Guid? RefNaepMathComplexityLevelId { get => _RefNaepMathComplexityLevelId; set => SetProperty(ref _RefNaepMathComplexityLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReadingId"/> model
        /// </summary>
        public Guid? RefNaepAspectsOfReadingId { get => _RefNaepAspectsOfReadingId; set => SetProperty(ref _RefNaepAspectsOfReadingId, value); }

        public System.Decimal? Difficulty { get => _Difficulty; set => SetProperty(ref _Difficulty, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystemId"/> model
        /// </summary>
        public Guid? RefTextComplexitySystemId { get => _RefTextComplexitySystemId; set => SetProperty(ref _RefTextComplexitySystemId, value); }

        public System.String TextComplexityValue  { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        public System.Boolean? LinkingItemIndicator { get => _LinkingItemIndicator; set => SetProperty(ref _LinkingItemIndicator, value); }

        public System.Boolean? ReleaseStatus { get => _ReleaseStatus; set => SetProperty(ref _ReleaseStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricId"/> model
        /// </summary>
        public Guid? RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        public System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get => _AssessmentFormSectionItemFieldTestIndicator; set => SetProperty(ref _AssessmentFormSectionItemFieldTestIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            RefAssessmentItemTypeId = model.RefAssessmentItemTypeId;
            BodyText = model.BodyText;
            Stimulus = model.Stimulus;
            Stem = model.Stem;
            AdaptiveIndicator = model.AdaptiveIndicator;
            MaximumScore = model.MaximumScore;
            MinimumScore = model.MinimumScore;
            DistractorAnalysis = model.DistractorAnalysis;
            AllottedTime = model.AllottedTime;
            RefNaepMathComplexityLevelId = model.RefNaepMathComplexityLevelId;
            RefNaepAspectsOfReadingId = model.RefNaepAspectsOfReadingId;
            Difficulty = model.Difficulty;
            RefTextComplexitySystemId = model.RefTextComplexitySystemId;
            TextComplexityValue = model.TextComplexityValue;
            LinkingItemIndicator = model.LinkingItemIndicator;
            ReleaseStatus = model.ReleaseStatus;
            RubricId = model.RubricId;
            LearningResourceId = model.LearningResourceId;
            AssessmentFormSectionItemFieldTestIndicator = model.AssessmentFormSectionItemFieldTestIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
