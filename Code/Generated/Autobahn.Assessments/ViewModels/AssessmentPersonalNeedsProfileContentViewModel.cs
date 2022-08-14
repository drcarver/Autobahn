//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContentViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfileContent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfileContent";

        // member variable for the AssessmentPersonalNeedsProfileId property
        private Guid _AssessmentPersonalNeedsProfileId;

        // member variable for the ChunkingActivateByDefaultIndicator property
        private System.Boolean? _ChunkingActivateByDefaultIndicator;

        // member variable for the ChunkingAssignedSupportIndicator property
        private System.Boolean? _ChunkingAssignedSupportIndicator;

        // member variable for the CognitiveGuidanceActivateByDefaultIndicator property
        private System.Boolean? _CognitiveGuidanceActivateByDefaultIndicator;

        // member variable for the CognitiveGuidanceAssignedSupportIndicator property
        private System.Boolean? _CognitiveGuidanceAssignedSupportIndicator;

        // member variable for the KeywordEmphasisActivateByDefaultIndicator property
        private System.Boolean? _KeywordEmphasisActivateByDefaultIndicator;

        // member variable for the KeywordEmphasisAssignedSupportIndicator property
        private System.Boolean? _KeywordEmphasisAssignedSupportIndicator;

        // member variable for the KeywordTranslationsActivateByDefaultIndicator property
        private System.Boolean? _KeywordTranslationsActivateByDefaultIndicator;

        // member variable for the KeywordTranslationsAssignedSupportIndicator property
        private System.Boolean? _KeywordTranslationsAssignedSupportIndicator;

        // member variable for the NegativesRemovedActivateByDefaultIndicator property
        private System.Boolean? _NegativesRemovedActivateByDefaultIndicator;

        // member variable for the NegativesRemovedAssignedSupportIndicator property
        private System.Boolean? _NegativesRemovedAssignedSupportIndicator;

        // member variable for the ReducedAnswersActivateByDefaultIndicator property
        private System.Boolean? _ReducedAnswersActivateByDefaultIndicator;

        // member variable for the ReducedAnswersAssignedSupportIndicator property
        private System.Boolean? _ReducedAnswersAssignedSupportIndicator;

        // member variable for the RefAssessmentNeedHazardTypeId property
        private Guid? _RefAssessmentNeedHazardTypeId;

        // member variable for the RefAssessmentNeedSupportToolId property
        private Guid? _RefAssessmentNeedSupportToolId;

        // member variable for the RefKeywordTranslationsLanguageId property
        private Guid? _RefKeywordTranslationsLanguageId;

        // member variable for the ScaffoldingActivateByDefaultIndicator property
        private System.Boolean? _ScaffoldingActivateByDefaultIndicator;

        // member variable for the ScaffoldingAssignedSupportIndicator property
        private System.Boolean? _ScaffoldingAssignedSupportIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileContentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get => _AssessmentPersonalNeedsProfileId; set => SetProperty(ref _AssessmentPersonalNeedsProfileId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ChunkingActivateByDefaultIndicator { get => _ChunkingActivateByDefaultIndicator; set => SetProperty(ref _ChunkingActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ChunkingAssignedSupportIndicator { get => _ChunkingAssignedSupportIndicator; set => SetProperty(ref _ChunkingAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get => _CognitiveGuidanceActivateByDefaultIndicator; set => SetProperty(ref _CognitiveGuidanceActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get => _CognitiveGuidanceAssignedSupportIndicator; set => SetProperty(ref _CognitiveGuidanceAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get => _KeywordEmphasisActivateByDefaultIndicator; set => SetProperty(ref _KeywordEmphasisActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? KeywordEmphasisAssignedSupportIndicator { get => _KeywordEmphasisAssignedSupportIndicator; set => SetProperty(ref _KeywordEmphasisAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get => _KeywordTranslationsActivateByDefaultIndicator; set => SetProperty(ref _KeywordTranslationsActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? KeywordTranslationsAssignedSupportIndicator { get => _KeywordTranslationsAssignedSupportIndicator; set => SetProperty(ref _KeywordTranslationsAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? NegativesRemovedActivateByDefaultIndicator { get => _NegativesRemovedActivateByDefaultIndicator; set => SetProperty(ref _NegativesRemovedActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? NegativesRemovedAssignedSupportIndicator { get => _NegativesRemovedAssignedSupportIndicator; set => SetProperty(ref _NegativesRemovedAssignedSupportIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ReducedAnswersActivateByDefaultIndicator { get => _ReducedAnswersActivateByDefaultIndicator; set => SetProperty(ref _ReducedAnswersActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ReducedAnswersAssignedSupportIndicator { get => _ReducedAnswersAssignedSupportIndicator; set => SetProperty(ref _ReducedAnswersAssignedSupportIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedHazardTypeId { get => _RefAssessmentNeedHazardTypeId; set => SetProperty(ref _RefAssessmentNeedHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSupportTool"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSupportToolId { get => _RefAssessmentNeedSupportToolId; set => SetProperty(ref _RefAssessmentNeedSupportToolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationsLanguage"/> model
        /// </summary>
        public Guid? RefKeywordTranslationsLanguageId { get => _RefKeywordTranslationsLanguageId; set => SetProperty(ref _RefKeywordTranslationsLanguageId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ScaffoldingActivateByDefaultIndicator { get => _ScaffoldingActivateByDefaultIndicator; set => SetProperty(ref _ScaffoldingActivateByDefaultIndicator, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public System.Boolean? ScaffoldingAssignedSupportIndicator { get => _ScaffoldingAssignedSupportIndicator; set => SetProperty(ref _ScaffoldingAssignedSupportIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfileContent model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId;
            ChunkingActivateByDefaultIndicator = model.ChunkingActivateByDefaultIndicator;
            ChunkingAssignedSupportIndicator = model.ChunkingAssignedSupportIndicator;
            CognitiveGuidanceActivateByDefaultIndicator = model.CognitiveGuidanceActivateByDefaultIndicator;
            CognitiveGuidanceAssignedSupportIndicator = model.CognitiveGuidanceAssignedSupportIndicator;
            KeywordEmphasisActivateByDefaultIndicator = model.KeywordEmphasisActivateByDefaultIndicator;
            KeywordEmphasisAssignedSupportIndicator = model.KeywordEmphasisAssignedSupportIndicator;
            KeywordTranslationsActivateByDefaultIndicator = model.KeywordTranslationsActivateByDefaultIndicator;
            KeywordTranslationsAssignedSupportIndicator = model.KeywordTranslationsAssignedSupportIndicator;
            NegativesRemovedActivateByDefaultIndicator = model.NegativesRemovedActivateByDefaultIndicator;
            NegativesRemovedAssignedSupportIndicator = model.NegativesRemovedAssignedSupportIndicator;
            ReducedAnswersActivateByDefaultIndicator = model.ReducedAnswersActivateByDefaultIndicator;
            ReducedAnswersAssignedSupportIndicator = model.ReducedAnswersAssignedSupportIndicator;
            RefAssessmentNeedHazardTypeId = model.RefAssessmentNeedHazardTypeId;
            RefAssessmentNeedSupportToolId = model.RefAssessmentNeedSupportToolId;
            RefKeywordTranslationsLanguageId = model.RefKeywordTranslationsLanguageId;
            ScaffoldingActivateByDefaultIndicator = model.ScaffoldingActivateByDefaultIndicator;
            ScaffoldingAssignedSupportIndicator = model.ScaffoldingAssignedSupportIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
