//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonTelephoneViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephoneViewModel
     /// </summary>
    public partial class PersonTelephoneViewModel : ViewModelBase, Interfaces.IPersonTelephoneViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonTelephone";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the TelephoneNumber property
        private System.String _TelephoneNumber;

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        // member variable for the RefPersonTelephoneNumberTypeId property
        private Guid? _RefPersonTelephoneNumberTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the RefTelephoneNumberListedStatusId property
        private Guid? _RefTelephoneNumberListedStatusId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String TelephoneNumber  { get => _TelephoneNumber; set => SetProperty(ref _TelephoneNumber, value); }

        public System.Boolean PrimaryTelephoneNumberIndicator  { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonTelephoneNumberTypeId"/> model
        /// </summary>
        public Guid? RefPersonTelephoneNumberTypeId { get => _RefPersonTelephoneNumberTypeId; set => SetProperty(ref _RefPersonTelephoneNumberTypeId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTelephoneNumberListedStatusId"/> model
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get => _RefTelephoneNumberListedStatusId; set => SetProperty(ref _RefTelephoneNumberListedStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            TelephoneNumber = model.TelephoneNumber;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator;
            RefPersonTelephoneNumberTypeId = model.RefPersonTelephoneNumberTypeId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
