//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileContentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContentViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentViewModel : BindableBase, IAssessmentPersonalNeedsProfileContent
    {
#region "Backing Fields"
        // member variable for the CognitiveGuidanceActivateByDefaultIndicator property
        private System.Boolean? _CognitiveGuidanceActivateByDefaultIndicator;

        // member variable for the CognitiveGuidanceAssignedSupportIndicator property
        private System.Boolean? _CognitiveGuidanceAssignedSupportIndicator;

        // member variable for the ScaffoldingAssignedSupportIndicator property
        private System.Boolean? _ScaffoldingAssignedSupportIndicator;

        // member variable for the ScaffoldingActivateByDefaultIndicator property
        private System.Boolean? _ScaffoldingActivateByDefaultIndicator;

        // member variable for the ChunkingAssignedSupportIndicator property
        private System.Boolean? _ChunkingAssignedSupportIndicator;

        // member variable for the ChunkingActivateByDefaultIndicator property
        private System.Boolean? _ChunkingActivateByDefaultIndicator;

        // member variable for the KeywordEmphasisAssignedSupportIndicator property
        private System.Boolean? _KeywordEmphasisAssignedSupportIndicator;

        // member variable for the KeywordEmphasisActivateByDefaultIndicator property
        private System.Boolean? _KeywordEmphasisActivateByDefaultIndicator;

        // member variable for the ReducedAnswersAssignedSupportIndicator property
        private System.Boolean? _ReducedAnswersAssignedSupportIndicator;

        // member variable for the ReducedAnswersActivateByDefaultIndicator property
        private System.Boolean? _ReducedAnswersActivateByDefaultIndicator;

        // member variable for the NegativesRemovedAssignedSupportIndicator property
        private System.Boolean? _NegativesRemovedAssignedSupportIndicator;

        // member variable for the NegativesRemovedActivateByDefaultIndicator property
        private System.Boolean? _NegativesRemovedActivateByDefaultIndicator;

        // member variable for the KeywordTranslationsAssignedSupportIndicator property
        private System.Boolean? _KeywordTranslationsAssignedSupportIndicator;

        // member variable for the KeywordTranslationsActivateByDefaultIndicator property
        private System.Boolean? _KeywordTranslationsActivateByDefaultIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSupportToolId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSupportToolId { get; set; }

        public System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get => _CognitiveGuidanceActivateByDefaultIndicator; set => SetProperty(ref _CognitiveGuidanceActivateByDefaultIndicator, value); }

        public System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get => _CognitiveGuidanceAssignedSupportIndicator; set => SetProperty(ref _CognitiveGuidanceAssignedSupportIndicator, value); }

        public System.Boolean? ScaffoldingAssignedSupportIndicator { get => _ScaffoldingAssignedSupportIndicator; set => SetProperty(ref _ScaffoldingAssignedSupportIndicator, value); }

        public System.Boolean? ScaffoldingActivateByDefaultIndicator { get => _ScaffoldingActivateByDefaultIndicator; set => SetProperty(ref _ScaffoldingActivateByDefaultIndicator, value); }

        public System.Boolean? ChunkingAssignedSupportIndicator { get => _ChunkingAssignedSupportIndicator; set => SetProperty(ref _ChunkingAssignedSupportIndicator, value); }

        public System.Boolean? ChunkingActivateByDefaultIndicator { get => _ChunkingActivateByDefaultIndicator; set => SetProperty(ref _ChunkingActivateByDefaultIndicator, value); }

        public System.Boolean? KeywordEmphasisAssignedSupportIndicator { get => _KeywordEmphasisAssignedSupportIndicator; set => SetProperty(ref _KeywordEmphasisAssignedSupportIndicator, value); }

        public System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get => _KeywordEmphasisActivateByDefaultIndicator; set => SetProperty(ref _KeywordEmphasisActivateByDefaultIndicator, value); }

        public System.Boolean? ReducedAnswersAssignedSupportIndicator { get => _ReducedAnswersAssignedSupportIndicator; set => SetProperty(ref _ReducedAnswersAssignedSupportIndicator, value); }

        public System.Boolean? ReducedAnswersActivateByDefaultIndicator { get => _ReducedAnswersActivateByDefaultIndicator; set => SetProperty(ref _ReducedAnswersActivateByDefaultIndicator, value); }

        public System.Boolean? NegativesRemovedAssignedSupportIndicator { get => _NegativesRemovedAssignedSupportIndicator; set => SetProperty(ref _NegativesRemovedAssignedSupportIndicator, value); }

        public System.Boolean? NegativesRemovedActivateByDefaultIndicator { get => _NegativesRemovedActivateByDefaultIndicator; set => SetProperty(ref _NegativesRemovedActivateByDefaultIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationsLanguageId"/> model
        /// </summary>
        public Guid? RefKeywordTranslationsLanguageId { get; set; }

        public System.Boolean? KeywordTranslationsAssignedSupportIndicator { get => _KeywordTranslationsAssignedSupportIndicator; set => SetProperty(ref _KeywordTranslationsAssignedSupportIndicator, value); }

        public System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get => _KeywordTranslationsActivateByDefaultIndicator; set => SetProperty(ref _KeywordTranslationsActivateByDefaultIndicator, value); }

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
        public void Load(IAssessmentPersonalNeedsProfileContent model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId;
            RefAssessmentNeedHazardTypeId = model.RefAssessmentNeedHazardTypeId;
            RefAssessmentNeedSupportToolId = model.RefAssessmentNeedSupportToolId;
            CognitiveGuidanceActivateByDefaultIndicator = model.CognitiveGuidanceActivateByDefaultIndicator;
            CognitiveGuidanceAssignedSupportIndicator = model.CognitiveGuidanceAssignedSupportIndicator;
            ScaffoldingAssignedSupportIndicator = model.ScaffoldingAssignedSupportIndicator;
            ScaffoldingActivateByDefaultIndicator = model.ScaffoldingActivateByDefaultIndicator;
            ChunkingAssignedSupportIndicator = model.ChunkingAssignedSupportIndicator;
            ChunkingActivateByDefaultIndicator = model.ChunkingActivateByDefaultIndicator;
            KeywordEmphasisAssignedSupportIndicator = model.KeywordEmphasisAssignedSupportIndicator;
            KeywordEmphasisActivateByDefaultIndicator = model.KeywordEmphasisActivateByDefaultIndicator;
            ReducedAnswersAssignedSupportIndicator = model.ReducedAnswersAssignedSupportIndicator;
            ReducedAnswersActivateByDefaultIndicator = model.ReducedAnswersActivateByDefaultIndicator;
            NegativesRemovedAssignedSupportIndicator = model.NegativesRemovedAssignedSupportIndicator;
            NegativesRemovedActivateByDefaultIndicator = model.NegativesRemovedActivateByDefaultIndicator;
            RefKeywordTranslationsLanguageId = model.RefKeywordTranslationsLanguageId;
            KeywordTranslationsAssignedSupportIndicator = model.KeywordTranslationsAssignedSupportIndicator;
            KeywordTranslationsActivateByDefaultIndicator = model.KeywordTranslationsActivateByDefaultIndicator;
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
