//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthenticationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthenticationViewModel
     /// </summary>
    public partial class AuthenticationViewModel : ViewModelBase, Interfaces.IAuthentication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authentication";

        // member variable for the EndDate property
        private  _EndDate;

        // member variable for the IdentityProviderName property
        private Guid? _IdentityProviderName;

        // member variable for the IdentityProviderUri property
        private  _IdentityProviderUri;

        // member variable for the LoginIdentifier property
        private  _LoginIdentifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StartDate property
        private  _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// </summary>
        public Guid? IdentityProviderName { get => _IdentityProviderName; set => SetProperty(ref _IdentityProviderName, value); }

        /// <summary>
        /// </summary>
        public  IdentityProviderUri { get => _IdentityProviderUri; set => SetProperty(ref _IdentityProviderUri, value); }

        /// <summary>
        /// </summary>
        public  LoginIdentifier { get => _LoginIdentifier; set => SetProperty(ref _LoginIdentifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthentication model)
        {
            IsBusy = true;
            Id = model.Id;
            EndDate = model.EndDate; // 
            IdentityProviderName = model.IdentityProviderName; // 
            IdentityProviderUri = model.IdentityProviderUri; // 
            LoginIdentifier = model.LoginIdentifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StartDate = model.StartDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
