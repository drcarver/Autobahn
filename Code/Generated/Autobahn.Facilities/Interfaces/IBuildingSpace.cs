//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSpace.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSpace Interface
     /// </summary>
    public partial interface IBuildingSpace : IAutobahnBase
    {
        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        System.String SpaceDescription { get; set; }

    }
}
