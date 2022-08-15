//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationFundViewModel
     /// </summary>
    public partial class ELOrganizationFundViewModel : ViewModelBase, Interfaces.IELOrganizationFund
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationFund";

        // member variable for the ELOrganizationFundsId property
        private Guid _ELOrganizationFundsId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationFundViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELOrganizationFunds"/> model
        /// </summary>
        public Guid ELOrganizationFundsId { get => _ELOrganizationFundsId; set => SetProperty(ref _ELOrganizationFundsId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationFund model)
        {
            IsBusy = true;
            Id = model.Id;
            ELOrganizationFundsId = model.ELOrganizationFundsId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// Reference to an optional instance of the <see cref="ELOrganizationFunds"/> model
        /// </summary>
        public ICommand ELOrganizationFundsCommand { get; set; }

        #endregion
    }
}
