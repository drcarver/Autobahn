//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationImageViewModel
     /// </summary>
    public partial class OrganizationImageViewModel : ViewModelBase, Interfaces.IOrganizationImage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationImage";

        // member variable for the URL property
        private System.String _URL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationImageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public System.String URL { get => _URL; set => SetProperty(ref _URL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationImage model)
        {
            IsBusy = true;
            Id = model.Id;
            URL = model.URL; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
