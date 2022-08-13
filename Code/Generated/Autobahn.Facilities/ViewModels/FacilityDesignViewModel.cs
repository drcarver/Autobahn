//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the BuildingArchitectName property
        private System.String _BuildingArchitectName;

        // member variable for the BuildingArchitecturalFirmName property
        private System.String _BuildingArchitecturalFirmName;

        // member variable for the BuildingDateOfCertificateOfOccupancy property
        private System.DateTime? _BuildingDateOfCertificateOfOccupancy;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the RefBuildingDesignTypeId property
        private Guid? _RefBuildingDesignTypeId;

        // member variable for the RefBuildingEnvOrEnergyPerformanceRatingCatId property
        private Guid? _RefBuildingEnvOrEnergyPerformanceRatingCatId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </summary>
        public System.String BuildingArchitectName { get => _BuildingArchitectName; set => SetProperty(ref _BuildingArchitectName, value); }

        /// <summary>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </summary>
        public System.String BuildingArchitecturalFirmName { get => _BuildingArchitecturalFirmName; set => SetProperty(ref _BuildingArchitecturalFirmName, value); }

        /// <summary>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </summary>
        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get => _BuildingDateOfCertificateOfOccupancy; set => SetProperty(ref _BuildingDateOfCertificateOfOccupancy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get => _RefBuildingDesignTypeId; set => SetProperty(ref _RefBuildingDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/> model
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
            BuildingArchitectName = model.BuildingArchitectName;
            BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName;
            BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy;
            FacilityId = model.FacilityId;
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId;
            RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
