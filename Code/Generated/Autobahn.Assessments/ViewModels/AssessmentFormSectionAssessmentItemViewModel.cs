//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormSectionAssessmentItemViewModel
     /// </summary>
    public partial class AssessmentFormSectionAssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentFormSectionAssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSectionAssessmentItem";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSectionAssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSectionAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
