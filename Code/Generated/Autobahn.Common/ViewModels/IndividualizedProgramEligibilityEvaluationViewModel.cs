//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityEvaluationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluation View Model
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibilityEvaluation";

        // member variable for the EligibilityEvaluationId property
        private Guid _EligibilityEvaluationId;

        // member variable for the IndividualizedProgramEligibilityId property
        private Guid _IndividualizedProgramEligibilityId;

        // RefIEPEligibilityEvaluationTypeId -- (backing property for IEP Eligibility Evaluation Type)
        private Guid? _RefIEPEligibilityEvaluationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get => _EligibilityEvaluationId; set => SetProperty(ref _EligibilityEvaluationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramEligibility"/> model
        /// </summary>
        public Guid IndividualizedProgramEligibilityId { get => _IndividualizedProgramEligibilityId; set => SetProperty(ref _IndividualizedProgramEligibilityId, value); }

        /// <summary>
        /// IEP Eligibility Evaluation Type
        /// <para>
        /// Purpose within the IEP lifecycle for which the eligibility evaluation is conducted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20709">IEP Eligibility Evaluation Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get => _RefIEPEligibilityEvaluationTypeId; set => SetProperty(ref _RefIEPEligibilityEvaluationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            EligibilityEvaluationId = model.EligibilityEvaluationId; // 
            IndividualizedProgramEligibilityId = model.IndividualizedProgramEligibilityId; // 
            RefIEPEligibilityEvaluationTypeId = model.RefIEPEligibilityEvaluationTypeId; // IEP Eligibility Evaluation Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
