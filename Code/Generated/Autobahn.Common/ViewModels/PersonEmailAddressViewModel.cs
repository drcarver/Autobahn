//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonEmailAddressViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonEmailAddressViewModel
     /// </summary>
    public partial class PersonEmailAddressViewModel : ViewModelBase, Interfaces.IPersonEmailAddressViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonEmailAddress";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the EmailAddress property
        private System.String _EmailAddress;

        // member variable for the RefEmailTypeId property
        private Guid? _RefEmailTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonEmailAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String EmailAddress  { get => _EmailAddress; set => SetProperty(ref _EmailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailTypeId"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonEmailAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            EmailAddress = model.EmailAddress;
            RefEmailTypeId = model.RefEmailTypeId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
