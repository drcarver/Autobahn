//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentFormSectionAssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentFormSectionAssessmentAsset
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSectionAssessmentAsset";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSectionAssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSectionAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
