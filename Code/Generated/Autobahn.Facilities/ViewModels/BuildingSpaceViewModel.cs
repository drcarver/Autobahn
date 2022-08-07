//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpaceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceViewModel
     /// </summary>
    public partial class BuildingSpaceViewModel : ViewModelBase, Interfaces.IBuildingSpaceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpace";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the SpaceDescription property
        private System.String _SpaceDescription;

        // member variable for the RefSpaceUseTypeId property
        private Guid? _RefSpaceUseTypeId;

        // member variable for the RefBuildingAdministrativeSpaceTypeId property
        private Guid? _RefBuildingAdministrativeSpaceTypeId;

        // member variable for the RefBuildingArtSpecialtySpaceTypeId property
        private Guid? _RefBuildingArtSpecialtySpaceTypeId;

        // member variable for the RefBuildingAssemblySpaceTypeId property
        private Guid? _RefBuildingAssemblySpaceTypeId;

        // member variable for the RefBuildingBasicClassroomDesignTypeId property
        private Guid? _RefBuildingBasicClassroomDesignTypeId;

        // member variable for the RefBuildingCareerTechEducationSpaceTypeId property
        private Guid? _RefBuildingCareerTechEducationSpaceTypeId;

        // member variable for the RefBuildingCirculationSpaceTypeId property
        private Guid? _RefBuildingCirculationSpaceTypeId;

        // member variable for the RefBuildingFoodServiceSpaceTypeId property
        private Guid? _RefBuildingFoodServiceSpaceTypeId;

        // member variable for the RefBuildingFullServiceKitchenTypeId property
        private Guid? _RefBuildingFullServiceKitchenTypeId;

        // member variable for the RefBuildingIndoorAthleticOrPhysEdSpaceTypeId property
        private Guid? _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId;

        // member variable for the RefBuildingLibMediaCenterSpecialtySpaceTypeId property
        private Guid? _RefBuildingLibMediaCenterSpecialtySpaceTypeId;

        // member variable for the RefBuildingOperationsOrMaintSpaceTypeId property
        private Guid? _RefBuildingOperationsOrMaintSpaceTypeId;

        // member variable for the RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId property
        private Guid? _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId;

        // member variable for the RefBuildingOutdoorOrNonathleticSpaceTypeId property
        private Guid? _RefBuildingOutdoorOrNonathleticSpaceTypeId;

        // member variable for the RefBuildingPerformingArtsSpecialtySpaceTypeId property
        private Guid? _RefBuildingPerformingArtsSpecialtySpaceTypeId;

        // member variable for the RefBuildingScienceSpecialtySpaceTypeId property
        private Guid? _RefBuildingScienceSpecialtySpaceTypeId;

        // member variable for the RefBuildingSpaceDesignTypeId property
        private Guid? _RefBuildingSpaceDesignTypeId;

        // member variable for the RefBuildingSpecEdSpecialtySpaceTypeId property
        private Guid? _RefBuildingSpecEdSpecialtySpaceTypeId;

        // member variable for the RefBuildingStudentSupportSpaceTypeId property
        private Guid? _RefBuildingStudentSupportSpaceTypeId;

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
        /// The title of the BuildingSpaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.String SpaceDescription  { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseTypeId"/> model
        /// </summary>
        public Guid? RefSpaceUseTypeId { get => _RefSpaceUseTypeId; set => SetProperty(ref _RefSpaceUseTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get => _RefBuildingAdministrativeSpaceTypeId; set => SetProperty(ref _RefBuildingAdministrativeSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get => _RefBuildingArtSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingArtSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get => _RefBuildingAssemblySpaceTypeId; set => SetProperty(ref _RefBuildingAssemblySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get => _RefBuildingBasicClassroomDesignTypeId; set => SetProperty(ref _RefBuildingBasicClassroomDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get => _RefBuildingCareerTechEducationSpaceTypeId; set => SetProperty(ref _RefBuildingCareerTechEducationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get => _RefBuildingCirculationSpaceTypeId; set => SetProperty(ref _RefBuildingCirculationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get => _RefBuildingFoodServiceSpaceTypeId; set => SetProperty(ref _RefBuildingFoodServiceSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenTypeId"/> model
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get => _RefBuildingFullServiceKitchenTypeId; set => SetProperty(ref _RefBuildingFullServiceKitchenTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get => _RefBuildingLibMediaCenterSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingLibMediaCenterSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get => _RefBuildingOperationsOrMaintSpaceTypeId; set => SetProperty(ref _RefBuildingOperationsOrMaintSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get => _RefBuildingOutdoorOrNonathleticSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorOrNonathleticSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get => _RefBuildingPerformingArtsSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingPerformingArtsSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get => _RefBuildingScienceSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingScienceSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get => _RefBuildingSpaceDesignTypeId; set => SetProperty(ref _RefBuildingSpaceDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get => _RefBuildingSpecEdSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingSpecEdSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get => _RefBuildingStudentSupportSpaceTypeId; set => SetProperty(ref _RefBuildingStudentSupportSpaceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpace model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
