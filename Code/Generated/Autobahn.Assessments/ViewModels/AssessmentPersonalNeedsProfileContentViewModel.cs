//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentNeedHazardTypeId property
        private Guid? _RefAssessmentNeedHazardTypeId;

        // member variable for the RefAssessmentNeedSupportToolId property
        private  _RefAssessmentNeedSupportToolId;

        // member variable for the RefKeywordTranslationsLanguageId property
        private  _RefKeywordTranslationsLanguageId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedHazardTypeId { get => _RefAssessmentNeedHazardTypeId; set => SetProperty(ref _RefAssessmentNeedHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSupportTool"/> model
        /// </summary>
        public  RefAssessmentNeedSupportToolId { get => _RefAssessmentNeedSupportToolId; set => SetProperty(ref _RefAssessmentNeedSupportToolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationsLanguage"/> model
        /// </summary>
        public  RefKeywordTranslationsLanguageId { get => _RefKeywordTranslationsLanguageId; set => SetProperty(ref _RefKeywordTranslationsLanguageId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfileContent model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentNeedHazardTypeId = model.RefAssessmentNeedHazardTypeId; // 
            RefAssessmentNeedSupportToolId = model.RefAssessmentNeedSupportToolId; // 
            RefKeywordTranslationsLanguageId = model.RefKeywordTranslationsLanguageId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
