//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSpace.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpace
     /// </summary>
    public partial interface IBuildingSpace
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.SpaceDescription non nullable property
        /// </summary>
        System.String SpaceDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseType"/> model
        /// </summary>
        Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceType"/> model
        /// </summary>
        Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenType"/> model
        /// </summary>
        Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignType"/> model
        /// </summary>
        Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
