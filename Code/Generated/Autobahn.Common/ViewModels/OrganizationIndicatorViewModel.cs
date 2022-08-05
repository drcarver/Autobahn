//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIndicatorViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIndicatorViewModel
     /// </summary>
    public partial class OrganizationIndicatorViewModel : ViewModelBase, Interfaces.IOrganizationIndicator
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIndicator";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the IndicatorValue property
        private System.String _IndicatorValue;

        // member variable for the RefOrganizationIndicatorId property
        private Guid _RefOrganizationIndicatorId;

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
        /// The title of the OrganizationIndicatorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String IndicatorValue  { get => _IndicatorValue; set => SetProperty(ref _IndicatorValue, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationIndicatorId"/> model
        /// </summary>
        public Guid RefOrganizationIndicatorId { get => _RefOrganizationIndicatorId; set => SetProperty(ref _RefOrganizationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIndicator model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            IndicatorValue = model.IndicatorValue;
            RefOrganizationIndicatorId = model.RefOrganizationIndicatorId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
