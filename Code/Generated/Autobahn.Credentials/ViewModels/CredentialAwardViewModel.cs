//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardViewModel
     /// </summary>
    public partial class CredentialAwardViewModel : ViewModelBase, Interfaces.ICredentialAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAward";

        // member variable for the CredentialAwardStartDate property
        private System.DateTime? _CredentialAwardStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Credential Award Start Date")]
        public System.DateTime? CredentialAwardStartDate { get => _CredentialAwardStartDate; set => SetProperty(ref _CredentialAwardStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAward model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialAwardStartDate = model.CredentialAwardStartDate; // Credential Award Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
