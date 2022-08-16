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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Statement property
        private Guid? _Statement;

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
        /// </summary>
        public Guid? Statement { get => _Statement; set => SetProperty(ref _Statement, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialAwardEvidence model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Statement = model.Statement; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
