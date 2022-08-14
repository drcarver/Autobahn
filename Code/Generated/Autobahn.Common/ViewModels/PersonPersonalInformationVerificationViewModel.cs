//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonPersonalInformationVerificationViewModel
     /// </summary>
    public partial class PersonPersonalInformationVerificationViewModel : ViewModelBase, Interfaces.IPersonPersonalInformationVerification
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonPersonalInformationVerification";

        // member variable for the PersonAddressId property
        private Guid? _PersonAddressId;

        // member variable for the PersonDetailId property
        private Guid? _PersonDetailId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PersonTelephoneId property
        private Guid? _PersonTelephoneId;

        // member variable for the RefPersonalInformationTypeId property
        private Guid? _RefPersonalInformationTypeId;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonPersonalInformationVerificationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddress"/> model
        /// </summary>
        public Guid? PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonDetail"/> model
        /// </summary>
        public Guid? PersonDetailId { get => _PersonDetailId; set => SetProperty(ref _PersonDetailId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonTelephone"/> model
        /// </summary>
        public Guid? PersonTelephoneId { get => _PersonTelephoneId; set => SetProperty(ref _PersonTelephoneId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationType"/> model
        /// </summary>
        public Guid? RefPersonalInformationTypeId { get => _RefPersonalInformationTypeId; set => SetProperty(ref _RefPersonalInformationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonPersonalInformationVerification model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonAddressId = model.PersonAddressId;
            PersonDetailId = model.PersonDetailId;
            PersonId = model.PersonId;
            PersonTelephoneId = model.PersonTelephoneId;
            RefPersonalInformationTypeId = model.RefPersonalInformationTypeId;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
