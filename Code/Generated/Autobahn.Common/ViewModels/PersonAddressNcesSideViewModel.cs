//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressNcesSideViewModel
     /// </summary>
    public partial class PersonAddressNcesSideViewModel : ViewModelBase, Interfaces.IPersonAddressNcesSide
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddressNcesSide";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAddressNcesSideViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
