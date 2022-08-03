//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedApipContentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipContentViewModel
     /// </summary>
    public partial class AssessmentNeedApipContentViewModel : BindableBase, IAssessmentNeedApipContent
    {
#region "Backing Fields"
        // member variable for the ReadAtStartPreferenceIndicator property
        private System.Boolean? _ReadAtStartPreferenceIndicator;

        // member variable for the AssessmentNeedDirectionsOnlyIndicator property
        private System.Boolean? _AssessmentNeedDirectionsOnlyIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileContentId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileContentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageTypeId"/> model
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageTypeId"/> model
        /// </summary>
        public Guid? KeywordTranslationLanguageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSigningTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

        public System.Boolean? ReadAtStartPreferenceIndicator { get => _ReadAtStartPreferenceIndicator; set => SetProperty(ref _ReadAtStartPreferenceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

        public System.Boolean? AssessmentNeedDirectionsOnlyIndicator { get => _AssessmentNeedDirectionsOnlyIndicator; set => SetProperty(ref _AssessmentNeedDirectionsOnlyIndicator, value); }

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
        public void Load(IAssessmentNeedApipContent model)
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
