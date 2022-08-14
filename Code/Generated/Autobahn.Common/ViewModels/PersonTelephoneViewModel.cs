//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephoneViewModel
     /// </summary>
    public partial class PersonTelephoneViewModel : ViewModelBase, Interfaces.IPersonTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonTelephone";

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // member variable for the RefPersonTelephoneNumberTypeId property
        private Guid? _RefPersonTelephoneNumberTypeId;

        // member variable for the RefTelephoneNumberListedStatusId property
        private Guid? _RefTelephoneNumberListedStatusId;

        // member variable for the TelephoneNumber property
        private System.String _TelephoneNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberType"/> model
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get => _RefPersonTelephoneNumberTypeId; set => SetProperty(ref _RefPersonTelephoneNumberTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        public System.String TelephoneNumber { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            PersonId = model.PersonId;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator;
            RefPersonTelephoneNumberTypeId = model.RefPersonTelephoneNumberTypeId;
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId;
            TelephoneNumber = model.TelephoneNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
