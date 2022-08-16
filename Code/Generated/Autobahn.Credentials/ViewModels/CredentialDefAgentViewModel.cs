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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCredentialDefAgentRoleTypeId property
        private  _RefCredentialDefAgentRoleTypeId;

        // member variable for the RefCTDLOrganizationTypeId property
        private Guid? _RefCTDLOrganizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefAgentRoleType"/> model
        /// </summary>
        public  RefCredentialDefAgentRoleTypeId { get => _RefCredentialDefAgentRoleTypeId; set => SetProperty(ref _RefCredentialDefAgentRoleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get => _RefCTDLOrganizationTypeId; set => SetProperty(ref _RefCTDLOrganizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefAgent model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCredentialDefAgentRoleTypeId = model.RefCredentialDefAgentRoleTypeId; // 
            RefCTDLOrganizationTypeId = model.RefCTDLOrganizationTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
