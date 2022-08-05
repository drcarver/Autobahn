//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityUtilizationViewModel
     /// </summary>
    public partial class FacilityUtilizationViewModel : ViewModelBase, Interfaces.IFacilityUtilization
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityUtilization";

        // member variable for the FacilityId property
        private Guid _FacilityId;

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

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityUtilizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.Int32? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get => _BuildingNetAreaOfInstructionalSpace; set => SetProperty(ref _BuildingNetAreaOfInstructionalSpace, value); }

        public System.Int32? BuildingNumberOfTeachingStations { get => _BuildingNumberOfTeachingStations; set => SetProperty(ref _BuildingNumberOfTeachingStations, value); }

        public System.String BuildingPublicUsePolicyDescription  { get => _BuildingPublicUsePolicyDescription; set => SetProperty(ref _BuildingPublicUsePolicyDescription, value); }

        public System.Int32? FacilityEnrollmentCapacity { get => _FacilityEnrollmentCapacity; set => SetProperty(ref _FacilityEnrollmentCapacity, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek;
            BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace;
            BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations;
            BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription;
            FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
