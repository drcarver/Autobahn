//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentItemViewModel : BindableBase, IAssessmentItem
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

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

        // member variable for the Difficulty property
        private System.Decimal? _Difficulty;

        // member variable for the TextComplexityValue property
        private System.String _TextComplexityValue;

        // member variable for the LinkingItemIndicator property
        private System.Boolean? _LinkingItemIndicator;

        // member variable for the ReleaseStatus property
        private System.Boolean? _ReleaseStatus;

        // member variable for the AssessmentFormSectionItemFieldTestIndicator property
        private System.Boolean? _AssessmentFormSectionItemFieldTestIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String AssessmentItemBankIdentifier  { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        public System.String AssessmentItemBankName  { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get; set; }

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
        public Guid? RefNaepMathComplexityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNaepAspectsOfReadingId"/> model
        /// </summary>
        public Guid? RefNaepAspectsOfReadingId { get; set; }

        public System.Decimal? Difficulty { get => _Difficulty; set => SetProperty(ref _Difficulty, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTextComplexitySystemId"/> model
        /// </summary>
        public Guid? RefTextComplexitySystemId { get; set; }

        public System.String TextComplexityValue  { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        public System.Boolean? LinkingItemIndicator { get => _LinkingItemIndicator; set => SetProperty(ref _LinkingItemIndicator, value); }

        public System.Boolean? ReleaseStatus { get => _ReleaseStatus; set => SetProperty(ref _ReleaseStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricId"/> model
        /// </summary>
        public Guid? RubricId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        public System.Boolean? AssessmentFormSectionItemFieldTestIndicator { get => _AssessmentFormSectionItemFieldTestIndicator; set => SetProperty(ref _AssessmentFormSectionItemFieldTestIndicator, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentItem model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
