//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _AssessmentNeedDirectionsOnlyIndicator;

        // member variable for the ItemTranslationDisplayLanguageTypeId property
        private Guid? _ItemTranslationDisplayLanguageTypeId;

        // member variable for the KeywordTranslationLanguageTypeId property
        private  _KeywordTranslationLanguageTypeId;

        // member variable for the ReadAtStartPreferenceIndicator property
        private  _ReadAtStartPreferenceIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedAlternativeRepresentationTypeId property
        private  _RefAssessmentNeedAlternativeRepresentationTypeId;

        // member variable for the RefAssessmentNeedSigningTypeId property
        private  _RefAssessmentNeedSigningTypeId;

        // member variable for the RefAssessmentNeedSpokenSourcePreferenceTypeId property
        private  _RefAssessmentNeedSpokenSourcePreferenceTypeId;

        // member variable for the RefAssessmentNeedUserSpokenPreferenceTypeId property
        private  _RefAssessmentNeedUserSpokenPreferenceTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentNeedDirectionsOnlyIndicator { get => _AssessmentNeedDirectionsOnlyIndicator; set => SetProperty(ref _AssessmentNeedDirectionsOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageType"/> model
        /// </summary>
        public Guid? ItemTranslationDisplayLanguageTypeId { get => _ItemTranslationDisplayLanguageTypeId; set => SetProperty(ref _ItemTranslationDisplayLanguageTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="KeywordTranslationLanguageType"/> model
        /// </summary>
        public  KeywordTranslationLanguageTypeId { get => _KeywordTranslationLanguageTypeId; set => SetProperty(ref _KeywordTranslationLanguageTypeId, value); }

        /// <summary>
        /// </summary>
        public  ReadAtStartPreferenceIndicator { get => _ReadAtStartPreferenceIndicator; set => SetProperty(ref _ReadAtStartPreferenceIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedAlternativeRepresentationType"/> model
        /// </summary>
        public  RefAssessmentNeedAlternativeRepresentationTypeId { get => _RefAssessmentNeedAlternativeRepresentationTypeId; set => SetProperty(ref _RefAssessmentNeedAlternativeRepresentationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSigningType"/> model
        /// </summary>
        public  RefAssessmentNeedSigningTypeId { get => _RefAssessmentNeedSigningTypeId; set => SetProperty(ref _RefAssessmentNeedSigningTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSpokenSourcePreferenceType"/> model
        /// </summary>
        public  RefAssessmentNeedSpokenSourcePreferenceTypeId { get => _RefAssessmentNeedSpokenSourcePreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedSpokenSourcePreferenceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUserSpokenPreferenceType"/> model
        /// </summary>
        public  RefAssessmentNeedUserSpokenPreferenceTypeId { get => _RefAssessmentNeedUserSpokenPreferenceTypeId; set => SetProperty(ref _RefAssessmentNeedUserSpokenPreferenceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipContent model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedDirectionsOnlyIndicator = model.AssessmentNeedDirectionsOnlyIndicator; // 
            ItemTranslationDisplayLanguageTypeId = model.ItemTranslationDisplayLanguageTypeId; // 
            KeywordTranslationLanguageTypeId = model.KeywordTranslationLanguageTypeId; // 
            ReadAtStartPreferenceIndicator = model.ReadAtStartPreferenceIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedAlternativeRepresentationTypeId = model.RefAssessmentNeedAlternativeRepresentationTypeId; // 
            RefAssessmentNeedSigningTypeId = model.RefAssessmentNeedSigningTypeId; // 
            RefAssessmentNeedSpokenSourcePreferenceTypeId = model.RefAssessmentNeedSpokenSourcePreferenceTypeId; // 
            RefAssessmentNeedUserSpokenPreferenceTypeId = model.RefAssessmentNeedUserSpokenPreferenceTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
