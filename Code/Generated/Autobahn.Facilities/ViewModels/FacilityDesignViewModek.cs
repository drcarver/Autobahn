//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityDesignViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignViewModel
     /// </summary>
    public partial class FacilityDesignViewModel : BindableBase, IFacilityDesign
    {
#region "Backing Fields"
        // member variable for the BuildingArchitectName property
        private System.String _BuildingArchitectName;

        // member variable for the BuildingArchitecturalFirmName property
        private System.String _BuildingArchitecturalFirmName;

        // member variable for the BuildingDateOfCertificateOfOccupancy property
        private System.DateTime? _BuildingDateOfCertificateOfOccupancy;

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

        public System.String BuildingArchitectName  { get => _BuildingArchitectName; set => SetProperty(ref _BuildingArchitectName, value); }

        public System.String BuildingArchitecturalFirmName  { get => _BuildingArchitecturalFirmName; set => SetProperty(ref _BuildingArchitecturalFirmName, value); }

        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get => _BuildingDateOfCertificateOfOccupancy; set => SetProperty(ref _BuildingDateOfCertificateOfOccupancy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCatId"/> model
        /// </summary>
        public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

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
        public void Load(IFacilityDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            BuildingArchitectName = model.BuildingArchitectName;
            BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName;
            BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy;
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId;
            RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId;
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
