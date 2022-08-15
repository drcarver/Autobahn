//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriteriaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCriteriaViewModel
     /// </summary>
    public partial class CredentialDefCriteriaViewModel : ViewModelBase, Interfaces.ICredentialDefCriteria
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefCriteria";

        // member variable for the Criteria property
        private System.String _Criteria;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefCriteriaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19896">Credential Definition Criteria</a>
        /// </para>
        /// </summary>
        [DisplayName("Credential Definition Criteria")]
        public System.String Criteria { get => _Criteria; set => SetProperty(ref _Criteria, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCriteria model)
        {
            IsBusy = true;
            Id = model.Id;
            Criteria = model.Criteria; // Credential Definition Criteria
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
