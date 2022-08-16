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

        // member variable for the CredentialOfferedEndDate property
        private  _CredentialOfferedEndDate;

        // member variable for the CredentialOfferedStartDate property
        private Guid? _CredentialOfferedStartDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CredentialOfferedEndDate { get => _CredentialOfferedEndDate; set => SetProperty(ref _CredentialOfferedEndDate, value); }

        /// <summary>
        /// </summary>
        public Guid? CredentialOfferedStartDate { get => _CredentialOfferedStartDate; set => SetProperty(ref _CredentialOfferedStartDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialOfferedEndDate = model.CredentialOfferedEndDate; // 
            CredentialOfferedStartDate = model.CredentialOfferedStartDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
