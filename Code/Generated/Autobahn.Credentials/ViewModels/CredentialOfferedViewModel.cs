//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialOfferedViewModel
     /// </summary>
    public partial class CredentialOfferedViewModel : ViewModelBase, Interfaces.ICredentialOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialOffered";

        // member variable for the CredentialOfferedStartDate property
        private System.DateTime? _CredentialOfferedStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The first date a credential was offered.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Credential Offered Start Date")]
        public System.DateTime? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialOfferedStartDate = model.CredentialOfferedStartDate; // Credential Offered Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
