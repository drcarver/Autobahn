//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleApplicationViewModel
     /// </summary>
    public partial class OrganizationPersonRoleApplicationViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleApplication";

        // member variable for the ApplicationDate property
        private System.DateTime? _ApplicationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Application Date")]
        public System.DateTime? ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationDate = model.ApplicationDate; // Application Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
