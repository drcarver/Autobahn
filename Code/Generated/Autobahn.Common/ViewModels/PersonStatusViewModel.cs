//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonStatusViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatusViewModel
     /// </summary>
    public partial class PersonStatusViewModel : ViewModelBase, Interfaces.IPersonStatusViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonStatus";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefPersonStatusTypeId property
        private Guid _RefPersonStatusTypeId;

        // member variable for the StatusValue property
        private System.Boolean _StatusValue;

        // member variable for the StatusStartDate property
        private System.DateTime? _StatusStartDate;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

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
        /// The title of the PersonStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonStatusTypeId"/> model
        /// </summary>
        public Guid RefPersonStatusTypeId { get => _RefPersonStatusTypeId; set => SetProperty(ref _RefPersonStatusTypeId, value); }

        public System.Boolean StatusValue  { get => _StatusValue; set => SetProperty(ref _StatusValue, value); }

        public System.DateTime? StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefPersonStatusTypeId = model.RefPersonStatusTypeId;
            StatusValue = model.StatusValue;
            StatusStartDate = model.StatusStartDate;
            StatusEndDate = model.StatusEndDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
