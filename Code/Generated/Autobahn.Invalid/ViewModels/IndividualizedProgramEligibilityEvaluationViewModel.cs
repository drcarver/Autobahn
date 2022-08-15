//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityEvaluationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluationViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibilityEvaluation";

        // member variable for the RefIEPEligibilityEvaluationTypeId property
        private Guid? _RefIEPEligibilityEvaluationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramEligibilityEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20709">IEP Eligibility Evaluation Type</a>
        /// </para>
        /// </summary>
        [DisplayName("IEP Eligibility Evaluation Type")]
        public Guid? RefIEPEligibilityEvaluationTypeId { get => _RefIEPEligibilityEvaluationTypeId; set => SetProperty(ref _RefIEPEligibilityEvaluationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIEPEligibilityEvaluationTypeId = model.RefIEPEligibilityEvaluationTypeId; // IEP Eligibility Evaluation Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
