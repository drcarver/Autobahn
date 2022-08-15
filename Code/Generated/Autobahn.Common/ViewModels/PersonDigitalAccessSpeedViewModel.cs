//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDigitalAccessSpeedViewModel
     /// </summary>
    public partial class PersonDigitalAccessSpeedViewModel : ViewModelBase, Interfaces.IPersonDigitalAccessSpeed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDigitalAccessSpeed";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDigitalAccessSpeedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDigitalAccessSpeed model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
