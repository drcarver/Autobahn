//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _BuildingHoursOfPublicUsePerWeek;

        // member variable for the BuildingNetAreaOfInstructionalSpace property
        private  _BuildingNetAreaOfInstructionalSpace;

        // member variable for the BuildingNumberOfTeachingStations property
        private  _BuildingNumberOfTeachingStations;

        // member variable for the BuildingPublicUsePolicyDescription property
        private  _BuildingPublicUsePolicyDescription;

        // member variable for the FacilityEnrollmentCapacity property
        private  _FacilityEnrollmentCapacity;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        /// <summary>
        /// </summary>
        public  BuildingNetAreaOfInstructionalSpace { get => _BuildingNetAreaOfInstructionalSpace; set => SetProperty(ref _BuildingNetAreaOfInstructionalSpace, value); }

        /// <summary>
        /// </summary>
        public  BuildingNumberOfTeachingStations { get => _BuildingNumberOfTeachingStations; set => SetProperty(ref _BuildingNumberOfTeachingStations, value); }

        /// <summary>
        /// </summary>
        public  BuildingPublicUsePolicyDescription { get => _BuildingPublicUsePolicyDescription; set => SetProperty(ref _BuildingPublicUsePolicyDescription, value); }

        /// <summary>
        /// </summary>
        public  FacilityEnrollmentCapacity { get => _FacilityEnrollmentCapacity; set => SetProperty(ref _FacilityEnrollmentCapacity, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek; // 
            BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace; // 
            BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations; // 
            BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription; // 
            FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
