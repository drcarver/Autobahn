//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmailViewModel
     /// </summary>
    public partial class OrganizationEmailViewModel : ViewModelBase, Interfaces.IOrganizationEmail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmail";

        // member variable for the ElectronicMailAddress property
        private System.String _ElectronicMailAddress;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationEmailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
        /// </para>
        /// </summary>
        [DisplayName("Electronic Mail Address")]
        public System.String ElectronicMailAddress { get => _ElectronicMailAddress; set => SetProperty(ref _ElectronicMailAddress, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmail model)
        {
            IsBusy = true;
            Id = model.Id;
            ElectronicMailAddress = model.ElectronicMailAddress; // Electronic Mail Address
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
