//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardEvidenceViewModel
     /// </summary>
    public partial class CredentialAwardEvidenceViewModel : ViewModelBase, Interfaces.ICredentialAwardEvidence
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAwardEvidence";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialAwardEvidenceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAwardEvidence model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
