//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _BuildingArchitectName;

        // member variable for the BuildingArchitecturalFirmName property
        private  _BuildingArchitecturalFirmName;

        // member variable for the BuildingDateOfCertificateOfOccupancy property
        private  _BuildingDateOfCertificateOfOccupancy;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingDesignTypeId property
        private Guid? _RefBuildingDesignTypeId;

        // member variable for the RefBuildingEnvOrEnergyPerformanceRatingCatId property
        private  _RefBuildingEnvOrEnergyPerformanceRatingCatId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BuildingArchitectName { get => _BuildingArchitectName; set => SetProperty(ref _BuildingArchitectName, value); }

        /// <summary>
        /// </summary>
        public  BuildingArchitecturalFirmName { get => _BuildingArchitecturalFirmName; set => SetProperty(ref _BuildingArchitecturalFirmName, value); }

        /// <summary>
        /// </summary>
        public  BuildingDateOfCertificateOfOccupancy { get => _BuildingDateOfCertificateOfOccupancy; set => SetProperty(ref _BuildingDateOfCertificateOfOccupancy, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get => _RefBuildingDesignTypeId; set => SetProperty(ref _RefBuildingDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/> model
        /// </summary>
        public  RefBuildingEnvOrEnergyPerformanceRatingCatId { get => _RefBuildingEnvOrEnergyPerformanceRatingCatId; set => SetProperty(ref _RefBuildingEnvOrEnergyPerformanceRatingCatId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingArchitectName = model.BuildingArchitectName; // 
            BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName; // 
            BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId; // 
            RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
