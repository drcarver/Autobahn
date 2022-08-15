//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnElementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The AutobahnElementViewModel
     /// </summary>
    public partial class AutobahnElementViewModel : ViewModelBase, Interfaces.IAutobahnElement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AutobahnElement";

        // member variable for the Id property
        private Guid? _Id;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AutobahnElementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref=""/> model
        /// </summary>
        public Guid? Id { get => _Id; set => SetProperty(ref _Id, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahnElement model)
        {
            IsBusy = true;
            Id = model.Id;
            Id = model.Id; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// Reference to an optional instance of the <see cref=""/> model
        /// </summary>
        public ICommand Command { get; set; }

        #endregion
    }
}
