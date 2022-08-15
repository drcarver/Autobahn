//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibility";

        // member variable for the ConsentToEvaluateIndicator property
        private System.Boolean? _ConsentToEvaluateIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Consent to Evaluation Indicator")]
        public System.Boolean? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator; // Consent to Evaluation Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
