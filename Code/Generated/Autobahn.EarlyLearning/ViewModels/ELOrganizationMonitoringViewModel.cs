//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationMonitoringViewModel
     /// </summary>
    public partial class ELOrganizationMonitoringViewModel : ViewModelBase, Interfaces.IELOrganizationMonitoring
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationMonitoring";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationMonitoringViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationMonitoring model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
