//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedApipContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipContentViewModel
     /// </summary>
    public partial class AssessmentNeedApipContentViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipContent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipContent";

        // member variable for the AssessmentNeedDirectionsOnlyIndicator property
        private System.Boolean? _AssessmentNeedDirectionsOnlyIndicator;

        // member variable for the AssessmentPersonalNeedsProfileContentId property
        private Guid _AssessmentPersonalNeedsProfileContentId;

        // member variable for the ItemTranslationDisplayLanguageTypeId property
        private Guid? _ItemTranslationDisplayLanguageTypeId;

        // member variable for the KeywordTranslationLanguageTypeId property
        private Guid? _KeywordTranslationLanguageTypeId;

        // member variable for the ReadAtStartPreferenceIndicator property
        private System.Boolean? _ReadAtStartPreferenceIndicator;

        // member variable for the RefAssessmentNeedAlternativeRepresentationTypeId property
        private Guid? _RefAssessmentNeedAlternativeRepresentationTypeId;

        // member variable for the RefAssessmentNeedSigningTypeId property
        private Guid? _RefAssessmentNeedSigningTypeId;

        // member variable for the RefAssessmentNeedSpokenSourcePreferenceTypeId property
        private Guid? _RefAssessmentNeedSpokenSourcePreferenceTypeId;

        // member variable for the RefAssessmentNeedUserSpokenPreferenceTypeId property
        private Guid? _RefAssessmentNeedUserSpokenPreferenceTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipContentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get => _AssessmentNeedDirectionsOnlyIndicator; set => SetProperty(ref _AssessmentNeedDirectionsOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileContent"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileContentId { get => _AssessmentPersonalNeedsProfileContentId; set => SetProperty(ref _AssessmentPersonalNeedsProfileContentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageType"/> model
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get => _ItemTranslationDisplayLanguageTypeId; set => SetProperty(ref _ItemTranslationDisplayLanguageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageType"/> model
        /// </summary>
        public Guid? KeywordTranslationLanguageTypeId { get => _KeywordTranslationLanguageTypeId; set => SetProperty(ref _KeywordTranslationLanguageTypeId, value); }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// </summary>
        public System.Boolean? ReadAtStartPreferenceIndicator { get => _ReadAtStartPreferenceIndicator; set => SetProperty(ref _ReadAtStartPreferenceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get => _RefAssessmentNeedAlternativeRepresentationTypeId; set => SetProperty(ref _RefAssessmentNeedAlternativeRepresentationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSigningTypeId { get => _RefAssessmentNeedSigningTypeId; set => SetProperty(ref _RefAssessmentNeedSigningTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get => _RefAssessmentNeedSpokenSourcePreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedSpokenSourcePreferenceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get => _RefAssessmentNeedUserSpokenPreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedUserSpokenPreferenceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipContent model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedDirectionsOnlyIndicator = model.AssessmentNeedDirectionsOnlyIndicator;
            AssessmentPersonalNeedsProfileContentId = model.AssessmentPersonalNeedsProfileContentId;
            ItemTranslationDisplayLanguageTypeId = model.ItemTranslationDisplayLanguageTypeId;
            KeywordTranslationLanguageTypeId = model.KeywordTranslationLanguageTypeId;
            ReadAtStartPreferenceIndicator = model.ReadAtStartPreferenceIndicator;
            RefAssessmentNeedAlternativeRepresentationTypeId = model.RefAssessmentNeedAlternativeRepresentationTypeId;
            RefAssessmentNeedSigningTypeId = model.RefAssessmentNeedSigningTypeId;
            RefAssessmentNeedSpokenSourcePreferenceTypeId = model.RefAssessmentNeedSpokenSourcePreferenceTypeId;
            RefAssessmentNeedUserSpokenPreferenceTypeId = model.RefAssessmentNeedUserSpokenPreferenceTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
