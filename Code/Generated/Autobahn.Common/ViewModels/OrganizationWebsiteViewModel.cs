//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationWebsiteViewModel
     /// </summary>
    public partial class OrganizationWebsiteViewModel : ViewModelBase, Interfaces.IOrganizationWebsite
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationWebsite";

        // member variable for the Website property
        private System.String _Website;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationWebsiteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
        /// </para>
        /// </summary>
        [DisplayName("Web Site Address")]
        public System.String Website { get => _Website; set => SetProperty(ref _Website, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationWebsite model)
        {
            IsBusy = true;
            Id = model.Id;
            Website = model.Website; // Web Site Address
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
