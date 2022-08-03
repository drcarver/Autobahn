//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceViewModel
     /// </summary>
    public partial class BuildingSpaceViewModel : BindableBase, IBuildingSpace
    {
#region "Backing Fields"
        // member variable for the SpaceDescription property
        private System.String _SpaceDescription;

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

        public System.String SpaceDescription  { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseTypeId"/> model
        /// </summary>
        public Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenTypeId"/> model
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

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
        public void Load(IBuildingSpace model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            SpaceDescription = model.SpaceDescription;
            RefSpaceUseTypeId = model.RefSpaceUseTypeId;
            RefBuildingAdministrativeSpaceTypeId = model.RefBuildingAdministrativeSpaceTypeId;
            RefBuildingArtSpecialtySpaceTypeId = model.RefBuildingArtSpecialtySpaceTypeId;
            RefBuildingAssemblySpaceTypeId = model.RefBuildingAssemblySpaceTypeId;
            RefBuildingBasicClassroomDesignTypeId = model.RefBuildingBasicClassroomDesignTypeId;
            RefBuildingCareerTechEducationSpaceTypeId = model.RefBuildingCareerTechEducationSpaceTypeId;
            RefBuildingCirculationSpaceTypeId = model.RefBuildingCirculationSpaceTypeId;
            RefBuildingFoodServiceSpaceTypeId = model.RefBuildingFoodServiceSpaceTypeId;
            RefBuildingFullServiceKitchenTypeId = model.RefBuildingFullServiceKitchenTypeId;
            RefBuildingIndoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingIndoorAthleticOrPhysEdSpaceTypeId;
            RefBuildingLibMediaCenterSpecialtySpaceTypeId = model.RefBuildingLibMediaCenterSpecialtySpaceTypeId;
            RefBuildingOperationsOrMaintSpaceTypeId = model.RefBuildingOperationsOrMaintSpaceTypeId;
            RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId;
            RefBuildingOutdoorOrNonathleticSpaceTypeId = model.RefBuildingOutdoorOrNonathleticSpaceTypeId;
            RefBuildingPerformingArtsSpecialtySpaceTypeId = model.RefBuildingPerformingArtsSpecialtySpaceTypeId;
            RefBuildingScienceSpecialtySpaceTypeId = model.RefBuildingScienceSpecialtySpaceTypeId;
            RefBuildingSpaceDesignTypeId = model.RefBuildingSpaceDesignTypeId;
            RefBuildingSpecEdSpecialtySpaceTypeId = model.RefBuildingSpecEdSpecialtySpaceTypeId;
            RefBuildingStudentSupportSpaceTypeId = model.RefBuildingStudentSupportSpaceTypeId;
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
