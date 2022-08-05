//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonViewModel
     /// </summary>
    public partial class PersonViewModel : ViewModelBase, Interfaces.IPerson
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Person";

        // member variable for the PersonMasterId property
        private Guid? _PersonMasterId;

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
        /// The title of the PersonViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonMasterId"/> model
        /// </summary>
        public Guid? PersonMasterId { get => _PersonMasterId; set => SetProperty(ref _PersonMasterId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPerson model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonMasterId = model.PersonMasterId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
