//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonIdentifierViewModel.cs
//**********************************************************


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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RefPersonIdentificationSystemId property
        private Guid _RefPersonIdentificationSystemId;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonIdentificationSystemId"/> model
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get => _RefPersonIdentificationSystemId; set => SetProperty(ref _RefPersonIdentificationSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerificationId"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            Identifier = model.Identifier;
            RefPersonIdentificationSystemId = model.RefPersonIdentificationSystemId;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
