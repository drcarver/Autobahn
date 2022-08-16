//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceUtilizationViewModel
     /// </summary>
    public partial class BuildingSpaceUtilizationViewModel : ViewModelBase, Interfaces.IBuildingSpaceUtilization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpaceUtilization";

        // member variable for the AvailableUtilizedInstructionalSpace property
        private  _AvailableUtilizedInstructionalSpace;

        // member variable for the BuildingCapacityFactorIndicator property
        private  _BuildingCapacityFactorIndicator;

        // member variable for the BuildingSpaceUtilizationArea property
        private  _BuildingSpaceUtilizationArea;

        // member variable for the BuildingUnassignedSpaceIndicator property
        private  _BuildingUnassignedSpaceIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingCommunityUseSpaceTypeId property
        private  _RefBuildingCommunityUseSpaceTypeId;

        // member variable for the RefBuildingInstructionalSpaceFactorTypeId property
        private Guid? _RefBuildingInstructionalSpaceFactorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AvailableUtilizedInstructionalSpace { get => _AvailableUtilizedInstructionalSpace; set => SetProperty(ref _AvailableUtilizedInstructionalSpace, value); }

        /// <summary>
        /// </summary>
        public  BuildingCapacityFactorIndicator { get => _BuildingCapacityFactorIndicator; set => SetProperty(ref _BuildingCapacityFactorIndicator, value); }

        /// <summary>
        /// </summary>
        public  BuildingSpaceUtilizationArea { get => _BuildingSpaceUtilizationArea; set => SetProperty(ref _BuildingSpaceUtilizationArea, value); }

        /// <summary>
        /// </summary>
        public  BuildingUnassignedSpaceIndicator { get => _BuildingUnassignedSpaceIndicator; set => SetProperty(ref _BuildingUnassignedSpaceIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceType"/> model
        /// </summary>
        public  RefBuildingCommunityUseSpaceTypeId { get => _RefBuildingCommunityUseSpaceTypeId; set => SetProperty(ref _RefBuildingCommunityUseSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorType"/> model
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get => _RefBuildingInstructionalSpaceFactorTypeId; set => SetProperty(ref _RefBuildingInstructionalSpaceFactorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpaceUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableUtilizedInstructionalSpace = model.AvailableUtilizedInstructionalSpace; // 
            BuildingCapacityFactorIndicator = model.BuildingCapacityFactorIndicator; // 
            BuildingSpaceUtilizationArea = model.BuildingSpaceUtilizationArea; // 
            BuildingUnassignedSpaceIndicator = model.BuildingUnassignedSpaceIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingCommunityUseSpaceTypeId = model.RefBuildingCommunityUseSpaceTypeId; // 
            RefBuildingInstructionalSpaceFactorTypeId = model.RefBuildingInstructionalSpaceFactorTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
