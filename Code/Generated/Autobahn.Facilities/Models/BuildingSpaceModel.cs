//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpace Model
     /// </summary>
    public partial class BuildingSpaceModel : AutobahnBase, Interfaces.IBuildingSpace
    {
        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public System.String SpaceDescription { get; set; }

    }
}
