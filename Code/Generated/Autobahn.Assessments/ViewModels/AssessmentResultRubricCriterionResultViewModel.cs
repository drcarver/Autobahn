//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultRubricCriterionResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResultViewModel
     /// </summary>
    public partial class AssessmentResultRubricCriterionResultViewModel : ViewModelBase, Interfaces.IAssessmentResultRubricCriterionResult
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResultRubricCriterionResult";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResultRubricCriterionResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResultRubricCriterionResult model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
