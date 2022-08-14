//**********************************************************
//* DomainName: Common Models
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

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        // member variable for the RefPersonIdentificationSystemId property
        private Guid _RefPersonIdentificationSystemId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonentificationSystem"/> model
        /// </summary>
        public Guid RefPersonIdentificationSystemId { get => _RefPersonIdentificationSystemId; set => SetProperty(ref _RefPersonIdentificationSystemId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            PersonId = model.PersonId;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
            RefPersonIdentificationSystemId = model.RefPersonIdentificationSystemId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
