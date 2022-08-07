//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipContentViewModel
     /// </summary>
    public partial class AssessmentNeedApipContentViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipContentViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipContent";

        // member variable for the AssessmentPersonalNeedsProfileContentId property
        private Guid _AssessmentPersonalNeedsProfileContentId;

        // member variable for the ItemTranslationDisplayLanguageTypeId property
        private Guid? _ItemTranslationDisplayLanguageTypeId;

        // member variable for the KeywordTranslationLanguageTypeId property
        private Guid? _KeywordTranslationLanguageTypeId;

        // member variable for the RefAssessmentNeedSigningTypeId property
        private Guid? _RefAssessmentNeedSigningTypeId;

        // member variable for the RefAssessmentNeedAlternativeRepresentationTypeId property
        private Guid? _RefAssessmentNeedAlternativeRepresentationTypeId;

        // member variable for the RefAssessmentNeedSpokenSourcePreferenceTypeId property
        private Guid? _RefAssessmentNeedSpokenSourcePreferenceTypeId;

        // member variable for the ReadAtStartPreferenceIndicator property
        private System.Boolean? _ReadAtStartPreferenceIndicator;

        // member variable for the RefAssessmentNeedUserSpokenPreferenceTypeId property
        private Guid? _RefAssessmentNeedUserSpokenPreferenceTypeId;

        // member variable for the AssessmentNeedDirectionsOnlyIndicator property
        private System.Boolean? _AssessmentNeedDirectionsOnlyIndicator;

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
        /// The title of the AssessmentNeedApipContentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileContentId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileContentId { get => _AssessmentPersonalNeedsProfileContentId; set => SetProperty(ref _AssessmentPersonalNeedsProfileContentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageTypeId"/> model
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get => _ItemTranslationDisplayLanguageTypeId; set => SetProperty(ref _ItemTranslationDisplayLanguageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageTypeId"/> model
        /// </summary>
        public Guid? KeywordTranslationLanguageTypeId { get => _KeywordTranslationLanguageTypeId; set => SetProperty(ref _KeywordTranslationLanguageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSigningTypeId { get => _RefAssessmentNeedSigningTypeId; set => SetProperty(ref _RefAssessmentNeedSigningTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get => _RefAssessmentNeedAlternativeRepresentationTypeId; set => SetProperty(ref _RefAssessmentNeedAlternativeRepresentationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get => _RefAssessmentNeedSpokenSourcePreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedSpokenSourcePreferenceTypeId, value); }

        public System.Boolean? ReadAtStartPreferenceIndicator { get => _ReadAtStartPreferenceIndicator; set => SetProperty(ref _ReadAtStartPreferenceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get => _RefAssessmentNeedUserSpokenPreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedUserSpokenPreferenceTypeId, value); }

        public System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get => _AssessmentNeedDirectionsOnlyIndicator; set => SetProperty(ref _AssessmentNeedDirectionsOnlyIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipContent model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileContentId = model.AssessmentPersonalNeedsProfileContentId;
            ItemTranslationDisplayLanguageTypeId = model.ItemTranslationDisplayLanguageTypeId;
            KeywordTranslationLanguageTypeId = model.KeywordTranslationLanguageTypeId;
            RefAssessmentNeedSigningTypeId = model.RefAssessmentNeedSigningTypeId;
            RefAssessmentNeedAlternativeRepresentationTypeId = model.RefAssessmentNeedAlternativeRepresentationTypeId;
            RefAssessmentNeedSpokenSourcePreferenceTypeId = model.RefAssessmentNeedSpokenSourcePreferenceTypeId;
            ReadAtStartPreferenceIndicator = model.ReadAtStartPreferenceIndicator;
            RefAssessmentNeedUserSpokenPreferenceTypeId = model.RefAssessmentNeedUserSpokenPreferenceTypeId;
            AssessmentNeedDirectionsOnlyIndicator = model.AssessmentNeedDirectionsOnlyIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
