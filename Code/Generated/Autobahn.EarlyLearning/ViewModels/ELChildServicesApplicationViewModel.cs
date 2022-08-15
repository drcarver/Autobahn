//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServicesApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildServicesApplicationViewModel
     /// </summary>
    public partial class ELChildServicesApplicationViewModel : ViewModelBase, Interfaces.IELChildServicesApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildServicesApplication";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildServicesApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildServicesApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
