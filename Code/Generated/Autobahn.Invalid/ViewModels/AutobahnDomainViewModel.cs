//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The AutobahnDomainViewModel
     /// </summary>
    public partial class AutobahnDomainViewModel : ViewModelBase, Interfaces.IAutobahnDomain
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AutobahnDomain";

        // member variable for the Module property
        private System.String _Module;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AutobahnDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public System.String Module { get => _Module; set => SetProperty(ref _Module, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahnDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            Module = model.Module; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
