//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignViewModel
     /// </summary>
    public partial class FacilityDesignViewModel : ViewModelBase, Interfaces.IFacilityDesign
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesign";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the BuildingArchitectName property
        private System.String _BuildingArchitectName;

        // member variable for the BuildingArchitecturalFirmName property
        private System.String _BuildingArchitecturalFirmName;

        // member variable for the BuildingDateOfCertificateOfOccupancy property
        private System.DateTime? _BuildingDateOfCertificateOfOccupancy;

        // member variable for the RefBuildingDesignTypeId property
        private Guid? _RefBuildingDesignTypeId;

        // member variable for the RefBuildingEnvOrEnergyPerformanceRatingCatId property
        private Guid? _RefBuildingEnvOrEnergyPerformanceRatingCatId;

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
        /// The title of the FacilityDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.String BuildingArchitectName  { get => _BuildingArchitectName; set => SetProperty(ref _BuildingArchitectName, value); }

        public System.String BuildingArchitecturalFirmName  { get => _BuildingArchitecturalFirmName; set => SetProperty(ref _BuildingArchitecturalFirmName, value); }

        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get => _BuildingDateOfCertificateOfOccupancy; set => SetProperty(ref _BuildingDateOfCertificateOfOccupancy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get => _RefBuildingDesignTypeId; set => SetProperty(ref _RefBuildingDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCatId"/> model
        /// </summary>
        public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get => _RefBuildingEnvOrEnergyPerformanceRatingCatId; set => SetProperty(ref _RefBuildingEnvOrEnergyPerformanceRatingCatId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            BuildingArchitectName = model.BuildingArchitectName;
            BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName;
            BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy;
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId;
            RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
