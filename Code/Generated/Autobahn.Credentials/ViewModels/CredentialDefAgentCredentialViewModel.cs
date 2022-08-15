//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefAgentCredentialViewModel
     /// </summary>
    public partial class CredentialDefAgentCredentialViewModel : ViewModelBase, Interfaces.ICredentialDefAgentCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefAgentCredential";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefAgentCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgentCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
