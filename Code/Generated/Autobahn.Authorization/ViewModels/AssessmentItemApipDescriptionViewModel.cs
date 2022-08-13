//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemApipDescriptionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentItemApipDescriptionViewModel
     /// </summary>
    public partial class AssessmentItemApipDescriptionViewModel : ViewModelBase, Interfaces.IAssessmentItemApipDescription
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemApipDescription";

        // member variable for the AslIndicator property
        private System.Boolean? _AslIndicator;

        // member variable for the AslOnDemandIndicator property
        private System.Boolean? _AslOnDemandIndicator;

        // member variable for the AssessmentItemApipId property
        private Guid _AssessmentItemApipId;

        // member variable for the BrailleIndicator property
        private System.Boolean? _BrailleIndicator;

        // member variable for the ChunkingActivateByDefaultIndicator property
        private System.Boolean? _ChunkingActivateByDefaultIndicator;

        // member variable for the ChunkingAssignedSupportIndicator property
        private System.Boolean? _ChunkingAssignedSupportIndicator;

        // member variable for the CognitiveGuidanceActivateByDefaultIndicator property
        private System.Boolean? _CognitiveGuidanceActivateByDefaultIndicator;

        // member variable for the CognitiveGuidanceAssignedSupportIndicator property
        private System.Boolean? _CognitiveGuidanceAssignedSupportIndicator;

        // member variable for the GraphicsOnlyIndicator property
        private System.Boolean? _GraphicsOnlyIndicator;

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

        // member variable for the NonVisualIndicator property
        private System.Boolean? _NonVisualIndicator;

        // member variable for the ReducedAnswersActivateByDefaultIndicator property
        private System.Boolean? _ReducedAnswersActivateByDefaultIndicator;

        // member variable for the ReducedAnswersAssignedSupportIndicator property
        private System.Boolean? _ReducedAnswersAssignedSupportIndicator;

        // member variable for the RefHazardTypeId property
        private Guid? _RefHazardTypeId;

        // member variable for the RefKeywordTranslationLanguageId property
        private Guid? _RefKeywordTranslationLanguageId;

        // member variable for the RefSupportToolTypeId property
        private Guid? _RefSupportToolTypeId;

        // member variable for the ScaffoldingActivateByDefaultIndicator property
        private System.Boolean? _ScaffoldingActivateByDefaultIndicator;

        // member variable for the ScaffoldingAssignedSupportIndicator property
        private System.Boolean? _ScaffoldingAssignedSupportIndicator;

        // member variable for the SignedEnglishIndicator property
        private System.Boolean? _SignedEnglishIndicator;

        // member variable for the SignedEnglishOnDemandIndicator property
        private System.Boolean? _SignedEnglishOnDemandIndicator;

        // member variable for the TextGraphicsIndicator property
        private System.Boolean? _TextGraphicsIndicator;

        // member variable for the TextOnlyIndicator property
        private System.Boolean? _TextOnlyIndicator;

        // member variable for the TextOnlyOnDemandIndicator property
        private System.Boolean? _TextOnlyOnDemandIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemApipDescriptionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? AslIndicator { get => _AslIndicator; set => SetProperty(ref _AslIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? AslOnDemandIndicator { get => _AslOnDemandIndicator; set => SetProperty(ref _AslOnDemandIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get => _AssessmentItemApipId; set => SetProperty(ref _AssessmentItemApipId, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? BrailleIndicator { get => _BrailleIndicator; set => SetProperty(ref _BrailleIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ChunkingActivateByDefaultIndicator { get => _ChunkingActivateByDefaultIndicator; set => SetProperty(ref _ChunkingActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ChunkingAssignedSupportIndicator { get => _ChunkingAssignedSupportIndicator; set => SetProperty(ref _ChunkingAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get => _CognitiveGuidanceActivateByDefaultIndicator; set => SetProperty(ref _CognitiveGuidanceActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get => _CognitiveGuidanceAssignedSupportIndicator; set => SetProperty(ref _CognitiveGuidanceAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? GraphicsOnlyIndicator { get => _GraphicsOnlyIndicator; set => SetProperty(ref _GraphicsOnlyIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get => _KeywordEmphasisActivateByDefaultIndicator; set => SetProperty(ref _KeywordEmphasisActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? KeywordEmphasisAssignedSupportIndicator { get => _KeywordEmphasisAssignedSupportIndicator; set => SetProperty(ref _KeywordEmphasisAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get => _KeywordTranslationsActivateByDefaultIndicator; set => SetProperty(ref _KeywordTranslationsActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? KeywordTranslationsAssignedSupportIndicator { get => _KeywordTranslationsAssignedSupportIndicator; set => SetProperty(ref _KeywordTranslationsAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? NegativesRemovedActivateByDefaultIndicator { get => _NegativesRemovedActivateByDefaultIndicator; set => SetProperty(ref _NegativesRemovedActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? NegativesRemovedAssignedSupportIndicator { get => _NegativesRemovedAssignedSupportIndicator; set => SetProperty(ref _NegativesRemovedAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? NonVisualIndicator { get => _NonVisualIndicator; set => SetProperty(ref _NonVisualIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ReducedAnswersActivateByDefaultIndicator { get => _ReducedAnswersActivateByDefaultIndicator; set => SetProperty(ref _ReducedAnswersActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ReducedAnswersAssignedSupportIndicator { get => _ReducedAnswersAssignedSupportIndicator; set => SetProperty(ref _ReducedAnswersAssignedSupportIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHazardType"/> model
        /// </summary>
        public Guid? RefHazardTypeId { get => _RefHazardTypeId; set => SetProperty(ref _RefHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
        /// </summary>
        public Guid? RefKeywordTranslationLanguageId { get => _RefKeywordTranslationLanguageId; set => SetProperty(ref _RefKeywordTranslationLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
        /// </summary>
        public Guid? RefSupportToolTypeId { get => _RefSupportToolTypeId; set => SetProperty(ref _RefSupportToolTypeId, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ScaffoldingActivateByDefaultIndicator { get => _ScaffoldingActivateByDefaultIndicator; set => SetProperty(ref _ScaffoldingActivateByDefaultIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? ScaffoldingAssignedSupportIndicator { get => _ScaffoldingAssignedSupportIndicator; set => SetProperty(ref _ScaffoldingAssignedSupportIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? SignedEnglishIndicator { get => _SignedEnglishIndicator; set => SetProperty(ref _SignedEnglishIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? SignedEnglishOnDemandIndicator { get => _SignedEnglishOnDemandIndicator; set => SetProperty(ref _SignedEnglishOnDemandIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? TextGraphicsIndicator { get => _TextGraphicsIndicator; set => SetProperty(ref _TextGraphicsIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? TextOnlyIndicator { get => _TextOnlyIndicator; set => SetProperty(ref _TextOnlyIndicator, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? TextOnlyOnDemandIndicator { get => _TextOnlyOnDemandIndicator; set => SetProperty(ref _TextOnlyOnDemandIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemApipDescription model)
        {
            IsBusy = true;
            Id = model.Id;
            AslIndicator = model.AslIndicator;
            AslOnDemandIndicator = model.AslOnDemandIndicator;
            AssessmentItemApipId = model.AssessmentItemApipId;
            BrailleIndicator = model.BrailleIndicator;
            ChunkingActivateByDefaultIndicator = model.ChunkingActivateByDefaultIndicator;
            ChunkingAssignedSupportIndicator = model.ChunkingAssignedSupportIndicator;
            CognitiveGuidanceActivateByDefaultIndicator = model.CognitiveGuidanceActivateByDefaultIndicator;
            CognitiveGuidanceAssignedSupportIndicator = model.CognitiveGuidanceAssignedSupportIndicator;
            GraphicsOnlyIndicator = model.GraphicsOnlyIndicator;
            KeywordEmphasisActivateByDefaultIndicator = model.KeywordEmphasisActivateByDefaultIndicator;
            KeywordEmphasisAssignedSupportIndicator = model.KeywordEmphasisAssignedSupportIndicator;
            KeywordTranslationsActivateByDefaultIndicator = model.KeywordTranslationsActivateByDefaultIndicator;
            KeywordTranslationsAssignedSupportIndicator = model.KeywordTranslationsAssignedSupportIndicator;
            NegativesRemovedActivateByDefaultIndicator = model.NegativesRemovedActivateByDefaultIndicator;
            NegativesRemovedAssignedSupportIndicator = model.NegativesRemovedAssignedSupportIndicator;
            NonVisualIndicator = model.NonVisualIndicator;
            ReducedAnswersActivateByDefaultIndicator = model.ReducedAnswersActivateByDefaultIndicator;
            ReducedAnswersAssignedSupportIndicator = model.ReducedAnswersAssignedSupportIndicator;
            RefHazardTypeId = model.RefHazardTypeId;
            RefKeywordTranslationLanguageId = model.RefKeywordTranslationLanguageId;
            RefSupportToolTypeId = model.RefSupportToolTypeId;
            ScaffoldingActivateByDefaultIndicator = model.ScaffoldingActivateByDefaultIndicator;
            ScaffoldingAssignedSupportIndicator = model.ScaffoldingAssignedSupportIndicator;
            SignedEnglishIndicator = model.SignedEnglishIndicator;
            SignedEnglishOnDemandIndicator = model.SignedEnglishOnDemandIndicator;
            TextGraphicsIndicator = model.TextGraphicsIndicator;
            TextOnlyIndicator = model.TextOnlyIndicator;
            TextOnlyOnDemandIndicator = model.TextOnlyOnDemandIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
