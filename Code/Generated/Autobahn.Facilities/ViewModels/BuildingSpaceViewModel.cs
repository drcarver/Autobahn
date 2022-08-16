//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceViewModel
     /// </summary>
    public partial class BuildingSpaceViewModel : ViewModelBase, Interfaces.IBuildingSpace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpace";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingAdministrativeSpaceTypeId property
        private  _RefBuildingAdministrativeSpaceTypeId;

        // member variable for the RefBuildingArtSpecialtySpaceTypeId property
        private  _RefBuildingArtSpecialtySpaceTypeId;

        // member variable for the RefBuildingAssemblySpaceTypeId property
        private  _RefBuildingAssemblySpaceTypeId;

        // member variable for the RefBuildingBasicClassroomDesignTypeId property
        private  _RefBuildingBasicClassroomDesignTypeId;

        // member variable for the RefBuildingCareerTechEducationSpaceTypeId property
        private  _RefBuildingCareerTechEducationSpaceTypeId;

        // member variable for the RefBuildingCirculationSpaceTypeId property
        private  _RefBuildingCirculationSpaceTypeId;

        // member variable for the RefBuildingFoodServiceSpaceTypeId property
        private  _RefBuildingFoodServiceSpaceTypeId;

        // member variable for the RefBuildingFullServiceKitchenTypeId property
        private  _RefBuildingFullServiceKitchenTypeId;

        // member variable for the RefBuildingIndoorAthleticOrPhysEdSpaceTypeId property
        private  _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId;

        // member variable for the RefBuildingLibMediaCenterSpecialtySpaceTypeId property
        private  _RefBuildingLibMediaCenterSpecialtySpaceTypeId;

        // member variable for the RefBuildingOperationsOrMaintSpaceTypeId property
        private  _RefBuildingOperationsOrMaintSpaceTypeId;

        // member variable for the RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId property
        private  _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId;

        // member variable for the RefBuildingOutdoorOrNonathleticSpaceTypeId property
        private  _RefBuildingOutdoorOrNonathleticSpaceTypeId;

        // member variable for the RefBuildingPerformingArtsSpecialtySpaceTypeId property
        private  _RefBuildingPerformingArtsSpecialtySpaceTypeId;

        // member variable for the RefBuildingScienceSpecialtySpaceTypeId property
        private  _RefBuildingScienceSpecialtySpaceTypeId;

        // member variable for the RefBuildingSpaceDesignTypeId property
        private  _RefBuildingSpaceDesignTypeId;

        // member variable for the RefBuildingSpecEdSpecialtySpaceTypeId property
        private  _RefBuildingSpecEdSpecialtySpaceTypeId;

        // member variable for the RefBuildingStudentSupportSpaceTypeId property
        private  _RefBuildingStudentSupportSpaceTypeId;

        // member variable for the RefSpaceUseTypeId property
        private  _RefSpaceUseTypeId;

        // member variable for the SpaceDescription property
        private Guid? _SpaceDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        public  RefBuildingAdministrativeSpaceTypeId { get => _RefBuildingAdministrativeSpaceTypeId; set => SetProperty(ref _RefBuildingAdministrativeSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        public  RefBuildingArtSpecialtySpaceTypeId { get => _RefBuildingArtSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingArtSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceType"/> model
        /// </summary>
        public  RefBuildingAssemblySpaceTypeId { get => _RefBuildingAssemblySpaceTypeId; set => SetProperty(ref _RefBuildingAssemblySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        public  RefBuildingBasicClassroomDesignTypeId { get => _RefBuildingBasicClassroomDesignTypeId; set => SetProperty(ref _RefBuildingBasicClassroomDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        public  RefBuildingCareerTechEducationSpaceTypeId { get => _RefBuildingCareerTechEducationSpaceTypeId; set => SetProperty(ref _RefBuildingCareerTechEducationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceType"/> model
        /// </summary>
        public  RefBuildingCirculationSpaceTypeId { get => _RefBuildingCirculationSpaceTypeId; set => SetProperty(ref _RefBuildingCirculationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        public  RefBuildingFoodServiceSpaceTypeId { get => _RefBuildingFoodServiceSpaceTypeId; set => SetProperty(ref _RefBuildingFoodServiceSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenType"/> model
        /// </summary>
        public  RefBuildingFullServiceKitchenTypeId { get => _RefBuildingFullServiceKitchenTypeId; set => SetProperty(ref _RefBuildingFullServiceKitchenTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public  RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        public  RefBuildingLibMediaCenterSpecialtySpaceTypeId { get => _RefBuildingLibMediaCenterSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingLibMediaCenterSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        public  RefBuildingOperationsOrMaintSpaceTypeId { get => _RefBuildingOperationsOrMaintSpaceTypeId; set => SetProperty(ref _RefBuildingOperationsOrMaintSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public  RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        public  RefBuildingOutdoorOrNonathleticSpaceTypeId { get => _RefBuildingOutdoorOrNonathleticSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorOrNonathleticSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        public  RefBuildingPerformingArtsSpecialtySpaceTypeId { get => _RefBuildingPerformingArtsSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingPerformingArtsSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        public  RefBuildingScienceSpecialtySpaceTypeId { get => _RefBuildingScienceSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingScienceSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignType"/> model
        /// </summary>
        public  RefBuildingSpaceDesignTypeId { get => _RefBuildingSpaceDesignTypeId; set => SetProperty(ref _RefBuildingSpaceDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        public  RefBuildingSpecEdSpecialtySpaceTypeId { get => _RefBuildingSpecEdSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingSpecEdSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        public  RefBuildingStudentSupportSpaceTypeId { get => _RefBuildingStudentSupportSpaceTypeId; set => SetProperty(ref _RefBuildingStudentSupportSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseType"/> model
        /// </summary>
        public  RefSpaceUseTypeId { get => _RefSpaceUseTypeId; set => SetProperty(ref _RefSpaceUseTypeId, value); }

        /// <summary>
        /// </summary>
        public Guid? SpaceDescription { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpace model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingAdministrativeSpaceTypeId = model.RefBuildingAdministrativeSpaceTypeId; // 
            RefBuildingArtSpecialtySpaceTypeId = model.RefBuildingArtSpecialtySpaceTypeId; // 
            RefBuildingAssemblySpaceTypeId = model.RefBuildingAssemblySpaceTypeId; // 
            RefBuildingBasicClassroomDesignTypeId = model.RefBuildingBasicClassroomDesignTypeId; // 
            RefBuildingCareerTechEducationSpaceTypeId = model.RefBuildingCareerTechEducationSpaceTypeId; // 
            RefBuildingCirculationSpaceTypeId = model.RefBuildingCirculationSpaceTypeId; // 
            RefBuildingFoodServiceSpaceTypeId = model.RefBuildingFoodServiceSpaceTypeId; // 
            RefBuildingFullServiceKitchenTypeId = model.RefBuildingFullServiceKitchenTypeId; // 
            RefBuildingIndoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; // 
            RefBuildingLibMediaCenterSpecialtySpaceTypeId = model.RefBuildingLibMediaCenterSpecialtySpaceTypeId; // 
            RefBuildingOperationsOrMaintSpaceTypeId = model.RefBuildingOperationsOrMaintSpaceTypeId; // 
            RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId = model.RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; // 
            RefBuildingOutdoorOrNonathleticSpaceTypeId = model.RefBuildingOutdoorOrNonathleticSpaceTypeId; // 
            RefBuildingPerformingArtsSpecialtySpaceTypeId = model.RefBuildingPerformingArtsSpecialtySpaceTypeId; // 
            RefBuildingScienceSpecialtySpaceTypeId = model.RefBuildingScienceSpecialtySpaceTypeId; // 
            RefBuildingSpaceDesignTypeId = model.RefBuildingSpaceDesignTypeId; // 
            RefBuildingSpecEdSpecialtySpaceTypeId = model.RefBuildingSpecEdSpecialtySpaceTypeId; // 
            RefBuildingStudentSupportSpaceTypeId = model.RefBuildingStudentSupportSpaceTypeId; // 
            RefSpaceUseTypeId = model.RefSpaceUseTypeId; // 
            SpaceDescription = model.SpaceDescription; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
