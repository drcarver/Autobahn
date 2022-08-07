//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ActivityViewModel
     /// </summary>
    public partial class ActivityViewModel : ViewModelBase, Interfaces.IActivityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Activity";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ActivityDescription property
        private System.String _ActivityDescription;

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
        /// The title of the ActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String ActivityDescription  { get => _ActivityDescription; set => SetProperty(ref _ActivityDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ActivityDescription = model.ActivityDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
