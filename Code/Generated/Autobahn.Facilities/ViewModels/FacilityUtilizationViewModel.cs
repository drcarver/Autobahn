//**********************************************************
//* DomainName: Facilities
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

        // member variable for the FacilityId property
        private Guid _FacilityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityUtilizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get => _BuildingNetAreaOfInstructionalSpace; set => SetProperty(ref _BuildingNetAreaOfInstructionalSpace, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.Int32? BuildingNumberOfTeachingStations { get => _BuildingNumberOfTeachingStations; set => SetProperty(ref _BuildingNumberOfTeachingStations, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.String BuildingPublicUsePolicyDescription { get => _BuildingPublicUsePolicyDescription; set => SetProperty(ref _BuildingPublicUsePolicyDescription, value); }

        /// <summary>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </summary>
        public System.Int32? FacilityEnrollmentCapacity { get => _FacilityEnrollmentCapacity; set => SetProperty(ref _FacilityEnrollmentCapacity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek;
            BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace;
            BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations;
            BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription;
            FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity;
            FacilityId = model.FacilityId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
