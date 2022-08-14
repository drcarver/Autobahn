//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialAwardCreditViewModel
     /// </summary>
    public partial class CredentialAwardCreditViewModel : ViewModelBase, Interfaces.ICredentialAwardCredit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialAwardCredit";

        // member variable for the CredentialAwardId property
        private Guid _CredentialAwardId;

        // member variable for the CredentialCriteriaCourseId property
        private Guid? _CredentialCriteriaCourseId;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialAwardCreditViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get => _CredentialAwardId; set => SetProperty(ref _CredentialAwardId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialCriteriaCourse"/> model
        /// </summary>
        public Guid? CredentialCriteriaCourseId { get => _CredentialCriteriaCourseId; set => SetProperty(ref _CredentialCriteriaCourseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAwardCredit model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialAwardId = model.CredentialAwardId;
            CredentialCriteriaCourseId = model.CredentialCriteriaCourseId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
