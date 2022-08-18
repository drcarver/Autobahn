//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationWebsite View Model
     /// </summary>
    public partial class OrganizationWebsiteViewModel : ViewModelBase, Interfaces.IOrganizationWebsite
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationWebsite";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // Website -- (backing property for Web Site Address)
        private System.String _Website;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Web Site Address
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Website { get => _Website; set => SetProperty(ref _Website, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationWebsite model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            Website = model.Website; // Web Site Address
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
