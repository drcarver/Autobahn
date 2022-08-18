//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The Authorization View Model
     /// </summary>
    public partial class AuthorizationViewModel : ViewModelBase, Interfaces.IAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authorization";

        // member variable for the ApplicationId property
        private Guid? _ApplicationId;

        // ApplicationRoleName -- (backing property for Authorization Application Role Name)
        private System.String _ApplicationRoleName;

        // EndDate -- (backing property for Authorization End Date)
        private System.DateTime? _EndDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // StartDate -- (backing property for Authorization Start Date)
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IApplication"/> model
        /// </summary>
        public Guid? ApplicationId { get => _ApplicationId; set => SetProperty(ref _ApplicationId, value); }

        /// <summary>
        /// Authorization Application Role Name
        /// <para>
        /// The user role for which the person is allowed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20129">Authorization Application Role Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ApplicationRoleName { get => _ApplicationRoleName; set => SetProperty(ref _ApplicationRoleName, value); }

        /// <summary>
        /// Authorization End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20131">Authorization End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Authorization Start Date
        /// <para>
        /// The date on which the  an associated person  is authorized to start using the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20130">Authorization Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationId = model.ApplicationId; // 
            ApplicationRoleName = model.ApplicationRoleName; // Authorization Application Role Name
            EndDate = model.EndDate; // Authorization End Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            StartDate = model.StartDate; // Authorization Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
