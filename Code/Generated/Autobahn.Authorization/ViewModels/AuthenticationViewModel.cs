//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The Authentication View Model
     /// </summary>
    public partial class AuthenticationViewModel : ViewModelBase, Interfaces.IAuthentication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authentication";

        // EndDate -- (backing property for Authentication Identity Provider End Date)
        private System.DateTime? _EndDate;

        // IdentityProviderName -- (backing property for Authentication Identity Provider Name)
        private System.String _IdentityProviderName;

        // IdentityProviderUri -- (backing property for Authentication Identity Provider URI)
        private System.String _IdentityProviderUri;

        // LoginIdentifier -- (backing property for Authentication Identity Provider Login Identifier)
        private System.String _LoginIdentifier;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // StartDate -- (backing property for Authentication Identity Provider Start Date)
        private System.DateTime? _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Authentication Identity Provider End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20126">Authentication Identity Provider End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Authentication Identity Provider Name
        /// <para>
        /// The name of a provider that can authenticate the identity of an person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20122">Authentication Identity Provider Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IdentityProviderName { get => _IdentityProviderName; set => SetProperty(ref _IdentityProviderName, value); }

        /// <summary>
        /// Authentication Identity Provider URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of the  Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20123">Authentication Identity Provider URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IdentityProviderUri { get => _IdentityProviderUri; set => SetProperty(ref _IdentityProviderUri, value); }

        /// <summary>
        /// Authentication Identity Provider Login Identifier
        /// <para>
        /// The login identifier for the person for the specified Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20124">Authentication Identity Provider Login Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LoginIdentifier { get => _LoginIdentifier; set => SetProperty(ref _LoginIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Authentication Identity Provider Start Date
        /// <para>
        /// The date on which the  an associated person may begin to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20125">Authentication Identity Provider Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            EndDate = model.EndDate; // Authentication Identity Provider End Date
            IdentityProviderName = model.IdentityProviderName; // Authentication Identity Provider Name
            IdentityProviderUri = model.IdentityProviderUri; // Authentication Identity Provider URI
            LoginIdentifier = model.LoginIdentifier; // Authentication Identity Provider Login Identifier
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            StartDate = model.StartDate; // Authentication Identity Provider Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
