//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleApplicationViewModel.cs
//* Name:       Application Date
//* Definition: The year, month and day on which an individual  application is received by the organization.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The year, month and day on which an individual  application is received by the organization.
     /// </summary>
    public partial class OrganizationPersonRoleApplicationViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleApplication";

        // ApplicationDate -- (backing property for Application Date)
        private System.DateTime _ApplicationDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Application Date
        /// <para>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19323">Application Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime ApplicationDate { get => _ApplicationDate; set => SetProperty(ref _ApplicationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationDate = model.ApplicationDate; // Application Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
