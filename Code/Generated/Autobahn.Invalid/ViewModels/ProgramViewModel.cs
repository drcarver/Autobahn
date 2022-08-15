//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramViewModel
     /// </summary>
    public partial class ProgramViewModel : ViewModelBase, Interfaces.IProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Program";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
