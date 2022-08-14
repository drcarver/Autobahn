//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageViewModel.cs
//**********************************************************

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

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the URL property
        private System.String _URL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationImageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing the Organization.
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
            OrganizationId = model.OrganizationId;
            URL = model.URL;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
