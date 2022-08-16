//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefIdentifierViewModel
     /// </summary>
    public partial class CredentialDefIdentifierViewModel : ViewModelBase, Interfaces.ICredentialDefIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefIdentifier";

        // member variable for the Identifier property
        private Guid? _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCredentialIdentifierSystemId property
        private  _RefCredentialIdentifierSystemId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        public  RefCredentialIdentifierSystemId { get => _RefCredentialIdentifierSystemId; set => SetProperty(ref _RefCredentialIdentifierSystemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCredentialIdentifierSystemId = model.RefCredentialIdentifierSystemId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
