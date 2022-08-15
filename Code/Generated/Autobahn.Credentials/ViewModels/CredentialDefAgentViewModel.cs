//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefAgentViewModel
     /// </summary>
    public partial class CredentialDefAgentViewModel : ViewModelBase, Interfaces.ICredentialDefAgent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefAgent";

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefAgentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20736">CTDL Organization Type</a>
        /// </para>
        /// </summary>
        [DisplayName("CTDL Organization Type")]
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgent model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId; // CTDL Organization Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
