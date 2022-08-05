//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDemographicRaceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDemographicRaceViewModel
     /// </summary>
    public partial class PersonDemographicRaceViewModel : ViewModelBase, Interfaces.IPersonDemographicRace
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDemographicRace";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefRaceId property
        private Guid _RefRaceId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the FederalRaceAndEthnicityDeclined property
        private System.Boolean? _FederalRaceAndEthnicityDeclined;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDemographicRaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRaceId"/> model
        /// </summary>
        public Guid RefRaceId { get => _RefRaceId; set => SetProperty(ref _RefRaceId, value); }

        public System.Boolean? FederalRaceAndEthnicityDeclined { get => _FederalRaceAndEthnicityDeclined; set => SetProperty(ref _FederalRaceAndEthnicityDeclined, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDemographicRace model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefRaceId = model.RefRaceId;
            FederalRaceAndEthnicityDeclined = model.FederalRaceAndEthnicityDeclined;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
