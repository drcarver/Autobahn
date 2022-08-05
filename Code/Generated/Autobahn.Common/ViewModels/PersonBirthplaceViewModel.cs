//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonBirthplaceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonBirthplaceViewModel
     /// </summary>
    public partial class PersonBirthplaceViewModel : ViewModelBase, Interfaces.IPersonBirthplace
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonBirthplace";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the City property
        private System.String _City;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

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
        /// The title of the PersonBirthplaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String City  { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateId"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountryId"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            City = model.City;
            RefStateId = model.RefStateId;
            RefCountryId = model.RefCountryId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
