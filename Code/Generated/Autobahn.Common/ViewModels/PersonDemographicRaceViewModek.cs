//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDemographicRaceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDemographicRaceViewModel
     /// </summary>
    public partial class PersonDemographicRaceViewModel : BindableBase, IPersonDemographicRace
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the FederalRaceAndEthnicityDeclined property
        private System.Boolean? _FederalRaceAndEthnicityDeclined;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRaceId"/> model
        /// </summary>
        public Guid RefRaceId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Boolean? FederalRaceAndEthnicityDeclined { get => _FederalRaceAndEthnicityDeclined; set => SetProperty(ref _FederalRaceAndEthnicityDeclined, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPersonDemographicRace model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefRaceId = model.RefRaceId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            FederalRaceAndEthnicityDeclined = model.FederalRaceAndEthnicityDeclined;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
