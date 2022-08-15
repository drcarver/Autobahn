//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildTransitionPlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildTransitionPlanViewModel
     /// </summary>
    public partial class ELChildTransitionPlanViewModel : ViewModelBase, Interfaces.IELChildTransitionPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildTransitionPlan";

        // member variable for the PartB619PotentialEligibilityInd property
        private System.Boolean? _PartB619PotentialEligibilityInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildTransitionPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The determination of whether a child is potentially eligible for Part B 619 services
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20327">IDEA Part B 619 Potential Eligibility Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("IDEA Part B 619 Potential Eligibility Indicator")]
        public System.Boolean? PartB619PotentialEligibilityInd { get => _PartB619PotentialEligibilityInd; set => SetProperty(ref _PartB619PotentialEligibilityInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildTransitionPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            PartB619PotentialEligibilityInd = model.PartB619PotentialEligibilityInd; // IDEA Part B 619 Potential Eligibility Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
