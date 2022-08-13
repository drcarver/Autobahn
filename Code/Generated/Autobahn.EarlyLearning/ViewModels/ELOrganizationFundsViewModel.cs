//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationFundsViewModel
     /// </summary>
    public partial class ELOrganizationFundsViewModel : ViewModelBase, Interfaces.IELOrganizationFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationFunds";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationFundsViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
