//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The BuildingSpace Model
     /// </summary>
    public partial class BuildingSpaceModel : AutobahnBase, Interfaces.IBuildingSpace
    {
        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingAssemblySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        public Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCirculationSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFullServiceKitchenType"/> model
        /// </summary>
        public Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSpaceDesignType"/> model
        /// </summary>
        public Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        public Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        public Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSpaceUseType"/> model
        /// </summary>
        public Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// Facility Space Description
        /// <para>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20174">Facility Space Description</a>
        /// </para>
        /// </summary>
        public System.String SpaceDescription { get; set; }

    }
}
