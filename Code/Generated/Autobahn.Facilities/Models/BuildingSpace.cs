//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSpace.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpace
     /// </summary>
    public partial class BuildingSpace : IBuildingSpace
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.SpaceDescription non nullable property
        /// </summary>
        public System.String SpaceDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpaceUseType"/> model
        /// </summary>
        public Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAssemblySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCirculationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingFullServiceKitchenType"/> model
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpaceDesignType"/> model
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSpace.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
