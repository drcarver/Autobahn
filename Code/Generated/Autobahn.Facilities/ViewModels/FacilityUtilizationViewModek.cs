//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityUtilizationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityUtilizationViewModel
     /// </summary>
    public partial class FacilityUtilizationViewModel : BindableBase, IFacilityUtilization
    {
#region "Backing Fields"
        // member variable for the BuildingHoursOfPublicUsePerWeek property
        private System.Int32? _BuildingHoursOfPublicUsePerWeek;

        // member variable for the BuildingNetAreaOfInstructionalSpace property
        private System.Decimal? _BuildingNetAreaOfInstructionalSpace;

        // member variable for the BuildingNumberOfTeachingStations property
        private System.Int32? _BuildingNumberOfTeachingStations;

        // member variable for the BuildingPublicUsePolicyDescription property
        private System.String _BuildingPublicUsePolicyDescription;

        // member variable for the FacilityEnrollmentCapacity property
        private System.Int32? _FacilityEnrollmentCapacity;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        public System.Int32? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get => _BuildingNetAreaOfInstructionalSpace; set => SetProperty(ref _BuildingNetAreaOfInstructionalSpace, value); }

        public System.Int32? BuildingNumberOfTeachingStations { get => _BuildingNumberOfTeachingStations; set => SetProperty(ref _BuildingNumberOfTeachingStations, value); }

        public System.String BuildingPublicUsePolicyDescription  { get => _BuildingPublicUsePolicyDescription; set => SetProperty(ref _BuildingPublicUsePolicyDescription, value); }

        public System.Int32? FacilityEnrollmentCapacity { get => _FacilityEnrollmentCapacity; set => SetProperty(ref _FacilityEnrollmentCapacity, value); }

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
        public void Load(IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek;
            BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace;
            BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations;
            BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription;
            FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity;
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
