//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDemographicRaceViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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

        // member variable for the FederalRaceAndEthnicityDeclined property
        private System.Boolean? _FederalRaceAndEthnicityDeclined;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefRaceId property
        private Guid _RefRaceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDemographicRaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? FederalRaceAndEthnicityDeclined { get => _FederalRaceAndEthnicityDeclined; set => SetProperty(ref _FederalRaceAndEthnicityDeclined, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRace"/> model
        /// </summary>
        public Guid RefRaceId { get => _RefRaceId; set => SetProperty(ref _RefRaceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDemographicRace model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalRaceAndEthnicityDeclined = model.FederalRaceAndEthnicityDeclined;
            PersonId = model.PersonId;
            RefRaceId = model.RefRaceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
