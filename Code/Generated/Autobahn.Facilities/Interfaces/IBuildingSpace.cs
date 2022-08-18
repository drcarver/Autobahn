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
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        Guid FacilityId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefSpaceUseType"/> model
        /// </summary>
        Guid? RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// Facility Space Description
        /// <para>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20174">Facility Space Description</a>
        /// </para>
        /// </summary>
        System.String SpaceDescription { get; set; }

    }
}
