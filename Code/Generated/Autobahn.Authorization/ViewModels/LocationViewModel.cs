//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The LocationViewModel
     /// </summary>
    public partial class LocationViewModel : ViewModelBase, Interfaces.ILocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Location";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILocation model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
