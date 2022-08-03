//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceUtilizationViewModel
     /// </summary>
    public partial class BuildingSpaceUtilizationViewModel : BindableBase, IBuildingSpaceUtilization
    {
#region "Backing Fields"
        // member variable for the AvailableUtilizedInstructionalSpace property
        private System.Boolean? _AvailableUtilizedInstructionalSpace;

        // member variable for the BuildingCapacityFactorIndicator property
        private System.Boolean? _BuildingCapacityFactorIndicator;

        // member variable for the BuildingSpaceUtilizationArea property
        private System.Decimal? _BuildingSpaceUtilizationArea;

        // member variable for the BuildingUnassignedSpaceIndicator property
        private System.Boolean? _BuildingUnassignedSpaceIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSpaceId"/> model
        /// </summary>
        public Guid BuildingSpaceId { get; set; }

        public System.Boolean? AvailableUtilizedInstructionalSpace { get => _AvailableUtilizedInstructionalSpace; set => SetProperty(ref _AvailableUtilizedInstructionalSpace, value); }

        public System.Boolean? BuildingCapacityFactorIndicator { get => _BuildingCapacityFactorIndicator; set => SetProperty(ref _BuildingCapacityFactorIndicator, value); }

        public System.Decimal? BuildingSpaceUtilizationArea { get => _BuildingSpaceUtilizationArea; set => SetProperty(ref _BuildingSpaceUtilizationArea, value); }

        public System.Boolean? BuildingUnassignedSpaceIndicator { get => _BuildingUnassignedSpaceIndicator; set => SetProperty(ref _BuildingUnassignedSpaceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCommunityUseSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorTypeId"/> model
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

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
        public void Load(IBuildingSpaceUtilization model)
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
