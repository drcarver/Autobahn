//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceUtilizationViewModel
     /// </summary>
    public partial class BuildingSpaceUtilizationViewModel : ViewModelBase, Interfaces.IBuildingSpaceUtilizationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpaceUtilization";

        // member variable for the BuildingSpaceId property
        private Guid _BuildingSpaceId;

        // member variable for the AvailableUtilizedInstructionalSpace property
        private System.Boolean? _AvailableUtilizedInstructionalSpace;

        // member variable for the BuildingCapacityFactorIndicator property
        private System.Boolean? _BuildingCapacityFactorIndicator;

        // member variable for the BuildingSpaceUtilizationArea property
        private System.Decimal? _BuildingSpaceUtilizationArea;

        // member variable for the BuildingUnassignedSpaceIndicator property
        private System.Boolean? _BuildingUnassignedSpaceIndicator;

        // member variable for the RefBuildingCommunityUseSpaceTypeId property
        private Guid? _RefBuildingCommunityUseSpaceTypeId;

        // member variable for the RefBuildingInstructionalSpaceFactorTypeId property
        private Guid? _RefBuildingInstructionalSpaceFactorTypeId;

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
        /// The title of the BuildingSpaceUtilizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSpaceId"/> model
        /// </summary>
        public Guid BuildingSpaceId { get => _BuildingSpaceId; set => SetProperty(ref _BuildingSpaceId, value); }

        public System.Boolean? AvailableUtilizedInstructionalSpace { get => _AvailableUtilizedInstructionalSpace; set => SetProperty(ref _AvailableUtilizedInstructionalSpace, value); }

        public System.Boolean? BuildingCapacityFactorIndicator { get => _BuildingCapacityFactorIndicator; set => SetProperty(ref _BuildingCapacityFactorIndicator, value); }

        public System.Decimal? BuildingSpaceUtilizationArea { get => _BuildingSpaceUtilizationArea; set => SetProperty(ref _BuildingSpaceUtilizationArea, value); }

        public System.Boolean? BuildingUnassignedSpaceIndicator { get => _BuildingUnassignedSpaceIndicator; set => SetProperty(ref _BuildingUnassignedSpaceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCommunityUseSpaceTypeId { get => _RefBuildingCommunityUseSpaceTypeId; set => SetProperty(ref _RefBuildingCommunityUseSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorTypeId"/> model
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
            BuildingSpaceId = model.BuildingSpaceId;
            AvailableUtilizedInstructionalSpace = model.AvailableUtilizedInstructionalSpace;
            BuildingCapacityFactorIndicator = model.BuildingCapacityFactorIndicator;
            BuildingSpaceUtilizationArea = model.BuildingSpaceUtilizationArea;
            BuildingUnassignedSpaceIndicator = model.BuildingUnassignedSpaceIndicator;
            RefBuildingCommunityUseSpaceTypeId = model.RefBuildingCommunityUseSpaceTypeId;
            RefBuildingInstructionalSpaceFactorTypeId = model.RefBuildingInstructionalSpaceFactorTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
