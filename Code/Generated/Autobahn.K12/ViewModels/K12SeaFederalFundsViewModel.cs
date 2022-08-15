//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFundsViewModel
     /// </summary>
    public partial class K12SeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12SeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFunds";

        // member variable for the StateTransferabilityOfFunds property
        private System.Boolean? _StateTransferabilityOfFunds;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SeaFederalFundsViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19435">State Transferability of Funds</a>
        /// </para>
        /// </summary>
        [DisplayName("State Transferability of Funds")]
        public System.Boolean? StateTransferabilityOfFunds { get => _StateTransferabilityOfFunds; set => SetProperty(ref _StateTransferabilityOfFunds, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            StateTransferabilityOfFunds = model.StateTransferabilityOfFunds; // State Transferability of Funds
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
