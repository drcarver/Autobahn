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

        // member variable for the Id property
        private Guid? _Id;

        // member variable for the Module property
        private System.String _Module;

        // member variable for the Name property
        private System.String _Name;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref=""/> model
        /// </summary>
        public Guid? Id { get => _Id; set => SetProperty(ref _Id, value); }

        /// <summary>
        /// </summary>
        public System.String Module { get => _Module; set => SetProperty(ref _Module, value); }

        /// <summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahnDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            Id = model.Id; // 
            Module = model.Module; // 
            Name = model.Name; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
