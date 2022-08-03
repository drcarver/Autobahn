//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentServiceViewModel
     /// </summary>
    public partial class BuildingSystemComponentServiceViewModel : BindableBase, IBuildingSystemComponentService
    {
#region "Backing Fields"
        // member variable for the ComponentOrFixtureScheduledServicedDate property
        private System.DateTime? _ComponentOrFixtureScheduledServicedDate;

        // member variable for the ComponentOrFixtureServicedDate property
        private System.DateTime? _ComponentOrFixtureServicedDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponentId"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get => _ComponentOrFixtureScheduledServicedDate; set => SetProperty(ref _ComponentOrFixtureScheduledServicedDate, value); }

        public System.DateTime? ComponentOrFixtureServicedDate { get => _ComponentOrFixtureServicedDate; set => SetProperty(ref _ComponentOrFixtureServicedDate, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(IBuildingSystemComponentService model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingSystemComponentId = model.BuildingSystemComponentId;
            ComponentOrFixtureScheduledServicedDate = model.ComponentOrFixtureScheduledServicedDate;
            ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
