//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessViewModel
     /// </summary>
    public partial class PersonDigitalAccessViewModel : ViewModelBase, Interfaces.IPersonDigitalAccess
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccess";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDigitalAccessViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccess model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
