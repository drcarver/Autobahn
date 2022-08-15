//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetailViewModel
     /// </summary>
    public partial class OrganizationDetailViewModel : ViewModelBase, Interfaces.IOrganizationDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationDetail";

        // member variable for the Name property
        private System.String _Name;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationDetailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20127">Authorization Application Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Authorization Application Name")]
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // Authorization Application Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
