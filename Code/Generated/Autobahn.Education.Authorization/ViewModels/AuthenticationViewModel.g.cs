//**********************************************************
//* DomainName: Information used by an application or service that authenticates the identity of a person or authorizes a person’s access to information or services.
//* FileName:   AuthenticationViewModel.g.cs
//*
//* This code was generated by a tool.  Do not
//* modify this file!  Instead modify the
//* AuthenticationViewModel.cs file
//***************************************************************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Autobahn.Education.Interfaces.Common;
using Autobahn.Education.Interfaces.Authorization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Autobahn.Education.Authorization.ViewModels
{
     /// <summary>
     /// The Authentication View Model
     /// </summary>
    public partial class AuthenticationViewModel : ObservableValidator, IAuthentication
    {
        #region "AuthenticationViewModel Constructor"
        /// </summary>
        /// The service provider instance.
        /// <summary>
        private System.IServiceProvider serviceProvider;

        /// <summary>
        /// AuthenticationViewModel Constructor
        /// </summary>
        public AuthenticationViewModel(System.IServiceProvider provider)
        {
            serviceProvider = provider;
            OnAuthenticationViewModelConstruction();
        }

        /// <summary>
        /// AuthenticationViewModel Constructor partial method
        /// <para>
        /// This method is called by the view model constructor
        /// to allow the inclusion of custom processing in
        /// the view models construction
        /// </para>
        /// </summary>
        public partial void OnAuthenticationViewModelConstruction();
        #endregion"

        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string viewTitle = "Hello from Authentication";

        // The isNew property is set if the view model has been created but not saved to the database
        private bool isNew = false;

        /// The isDeleted property is set if the view model is to be deleted from the database
        private bool isDeleted = false;

        /// The view model is changed and needs to be save to the database.
        public bool isChanged = false;

        /// The view model is performing a long running task
        public bool isBusy = false;

        // EndDate -- (backing property for Authentication Identity Provider End Date)
        private DateTime? endDate;

        // IdentityProviderName -- (backing property for Authentication Identity Provider Name)
        private System.String identityProviderName;

        // IdentityProviderUri -- (backing property for Authentication Identity Provider URI)
        private System.String identityProviderUri;

        // LoginIdentifier -- (backing property for Authentication Identity Provider Login Identifier)
        private System.String loginIdentifier;

        // StartDate -- (backing property for Authentication Identity Provider Start Date)
        private DateTime? startDate;

        #endregion

        #region "IAutobahnBase Properties"
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

        /// <summary>
        /// The IsNew property is set if the view model has been created but not saved to the database
        /// </summary>
        public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

        /// <summary>
        /// The IsDeleted property is set if the view model is to be delted from the database
        /// </summary>
        public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

        /// <summary>
        /// The primary key of the view model
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// The view model is changed and needs to be save to the database.
        /// </summary>
        public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

        /// <summary>
        /// The view model is performing a long running task
        /// </summary>
        public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

        /// <summary>
        /// The view model's changes have been save so update its tracking properties
        /// </summary>
        public void AcceptChanges()
        {
            IsNew = false;
            IsChanged = false;
        }
        #endregion

        #region "IAuthentication Properties"
        /// <summary>
        /// Authentication Identity Provider End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20126">Authentication Identity Provider End Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider End Date")]
        public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

        /// <summary>
        /// Authentication Identity Provider Name
        /// <para>
        /// The name of a provider that can authenticate the identity of an person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20122">Authentication Identity Provider Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider Name")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
        public System.String IdentityProviderName { get => identityProviderName; set => SetProperty(ref identityProviderName, value, true); }

        /// <summary>
        /// Authentication Identity Provider URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of the  Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20123">Authentication Identity Provider URI</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider URI")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
        public System.String IdentityProviderUri { get => identityProviderUri; set => SetProperty(ref identityProviderUri, value, true); }

        /// <summary>
        /// Authentication Identity Provider Login Identifier
        /// <para>
        /// The login identifier for the person for the specified Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20124">Authentication Identity Provider Login Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider Login Identifier")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
        public System.String LoginIdentifier { get => loginIdentifier; set => SetProperty(ref loginIdentifier, value, true); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authentication Identity Provider Start Date
        /// <para>
        /// The date on which the  an associated person may begin to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20125">Authentication Identity Provider Start Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Authentication Identity Provider Start Date")]
        public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            EndDate = model.EndDate; // Authentication Identity Provider End Date
            IdentityProviderName = model.IdentityProviderName; // Authentication Identity Provider Name
            IdentityProviderUri = model.IdentityProviderUri; // Authentication Identity Provider URI
            LoginIdentifier = model.LoginIdentifier; // Authentication Identity Provider Login Identifier
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            StartDate = model.StartDate; // Authentication Identity Provider Start Date
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
