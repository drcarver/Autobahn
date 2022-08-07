//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPopulationServedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServedViewModel
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : ViewModelBase, Interfaces.IOrganizationPopulationServedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPopulationServed";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the AgeUnit property
        private System.String _AgeUnit;

        // member variable for the OldestAgeServed property
        private System.Int32? _OldestAgeServed;

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        // member variable for the RefPopulationServedId property
        private Guid? _RefPopulationServedId;

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
        /// The title of the OrganizationPopulationServedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String AgeUnit  { get => _AgeUnit; set => SetProperty(ref _AgeUnit, value); }

        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServedId"/> model
        /// </summary>
        public Guid? RefPopulationServedId { get => _RefPopulationServedId; set => SetProperty(ref _RefPopulationServedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AgeUnit = model.AgeUnit;
            OldestAgeServed = model.OldestAgeServed;
            YoungestAgeServed = model.YoungestAgeServed;
            RefPopulationServedId = model.RefPopulationServedId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
