//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ApplicationViewModel
     /// </summary>
    public partial class ApplicationViewModel : ViewModelBase, Interfaces.IApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Application";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the Uri property
        private System.String _Uri;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        public System.String Uri { get => _Uri; set => SetProperty(ref _Uri, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            Uri = model.Uri;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
