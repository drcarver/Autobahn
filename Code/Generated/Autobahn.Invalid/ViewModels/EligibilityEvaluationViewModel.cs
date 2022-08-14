//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   EligibilityEvaluationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The EligibilityEvaluationViewModel
     /// </summary>
    public partial class EligibilityEvaluationViewModel : ViewModelBase, Interfaces.IEligibilityEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EligibilityEvaluation";

        // member variable for the EvaluationDate property
        private System.DateTime? _EvaluationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the EligibilityEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Description of evaluation procedure and result used for determining eligibility.
        /// </summary>
        public System.DateTime? EvaluationDate { get => _EvaluationDate; set => SetProperty(ref _EvaluationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            EvaluationDate = model.EvaluationDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
