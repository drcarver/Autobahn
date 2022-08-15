//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentAsset
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAsset";

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20073">Assessment Language</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Language")]
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentLanguageId = model.RefAssessmentLanguageId; // Assessment Language
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
