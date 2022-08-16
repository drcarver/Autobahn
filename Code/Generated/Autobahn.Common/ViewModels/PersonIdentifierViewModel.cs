//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonIdentifierViewModel
     /// </summary>
    public partial class PersonIdentifierViewModel : ViewModelBase, Interfaces.IPersonIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonIdentifier";

        // member variable for the Identifier property
        private Guid? _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPersonalInformationVerificationId property
        private  _RefPersonalInformationVerificationId;

        // member variable for the RefPersonIdentificationSystemId property
        private  _RefPersonIdentificationSystemId;

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
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public  RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        public  RefPersonIdentificationSystemId { get => _RefPersonIdentificationSystemId; set => SetProperty(ref _RefPersonIdentificationSystemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // 
            RefPersonIdentificationSystemId = model.RefPersonIdentificationSystemId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
