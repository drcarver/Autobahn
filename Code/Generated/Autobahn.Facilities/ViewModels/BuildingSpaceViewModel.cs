//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the FacilityId property
        private Guid _FacilityId;

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

        // member variable for the RefSpaceUseTypeId property
        private Guid? _RefSpaceUseTypeId;

        // member variable for the SpaceDescription property
        private System.String _SpaceDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSpaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get => _RefBuildingAdministrativeSpaceTypeId; set => SetProperty(ref _RefBuildingAdministrativeSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get => _RefBuildingArtSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingArtSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get => _RefBuildingAssemblySpaceTypeId; set => SetProperty(ref _RefBuildingAssemblySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get => _RefBuildingBasicClassroomDesignTypeId; set => SetProperty(ref _RefBuildingBasicClassroomDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get => _RefBuildingCareerTechEducationSpaceTypeId; set => SetProperty(ref _RefBuildingCareerTechEducationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get => _RefBuildingCirculationSpaceTypeId; set => SetProperty(ref _RefBuildingCirculationSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get => _RefBuildingFoodServiceSpaceTypeId; set => SetProperty(ref _RefBuildingFoodServiceSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenType"/> model
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get => _RefBuildingFullServiceKitchenTypeId; set => SetProperty(ref _RefBuildingFullServiceKitchenTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingIndoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get => _RefBuildingLibMediaCenterSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingLibMediaCenterSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get => _RefBuildingOperationsOrMaintSpaceTypeId; set => SetProperty(ref _RefBuildingOperationsOrMaintSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get => _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get => _RefBuildingOutdoorOrNonathleticSpaceTypeId; set => SetProperty(ref _RefBuildingOutdoorOrNonathleticSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get => _RefBuildingPerformingArtsSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingPerformingArtsSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get => _RefBuildingScienceSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingScienceSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignType"/> model
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get => _RefBuildingSpaceDesignTypeId; set => SetProperty(ref _RefBuildingSpaceDesignTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get => _RefBuildingSpecEdSpecialtySpaceTypeId; set => SetProperty(ref _RefBuildingSpecEdSpecialtySpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get => _RefBuildingStudentSupportSpaceTypeId; set => SetProperty(ref _RefBuildingStudentSupportSpaceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseType"/> model
        /// </summary>
        public Guid? RefSpaceUseTypeId { get => _RefSpaceUseTypeId; set => SetProperty(ref _RefSpaceUseTypeId, value); }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public System.String SpaceDescription { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpace model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
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
            RefSpaceUseTypeId = model.RefSpaceUseTypeId;
            SpaceDescription = model.SpaceDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
