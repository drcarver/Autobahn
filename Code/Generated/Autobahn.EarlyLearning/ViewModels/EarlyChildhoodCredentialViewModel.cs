//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodCredentialViewModel
     /// </summary>
    public partial class EarlyChildhoodCredentialViewModel : ViewModelBase, Interfaces.IEarlyChildhoodCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodCredential";

        // member variable for the RefEarlyChildhoodCredentialId property
        private Guid _RefEarlyChildhoodCredentialId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the EarlyChildhoodCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodCredential"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Childhood Credential")]
        public Guid RefEarlyChildhoodCredentialId { get => _RefEarlyChildhoodCredentialId; set => SetProperty(ref _RefEarlyChildhoodCredentialId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            RefEarlyChildhoodCredentialId = model.RefEarlyChildhoodCredentialId; // Early Childhood Credential
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
