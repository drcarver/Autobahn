//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EligibilityEvaluationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EligibilityEvaluation View Model
     /// </summary>
    public partial class EligibilityEvaluationViewModel : ViewModelBase, Interfaces.IEligibilityEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EligibilityEvaluation";

        // EvaluationDate -- (backing property for Eligibility Evaluation Date)
        private System.DateTime? _EvaluationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Eligibility Evaluation Date
        /// <para>
        /// The date when the evaluation to determine eligibility was conducted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20712">Eligibility Evaluation Date</a>
        /// </para>
        /// </summary>
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
            EvaluationDate = model.EvaluationDate; // Eligibility Evaluation Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
