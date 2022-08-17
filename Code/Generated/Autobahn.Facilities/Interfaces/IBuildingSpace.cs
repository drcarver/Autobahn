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
        /// Reference to an optional instance of the <see cref="IRefBuildingAdministrativeSpaceType"/> model
        /// </summary>
        Guid? RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingArtSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingAssemblySpaceType"/> model
        /// </summary>
        Guid? RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingBasicClassroomDesignType"/> model
        /// </summary>
        Guid? RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCareerTechEducationSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingCirculationSpaceType"/> model
        /// </summary>
        Guid? RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFoodServiceSpaceType"/> model
        /// </summary>
        Guid? RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingFullServiceKitchenType"/> model
        /// </summary>
        Guid? RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingIndoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        Guid? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingLibMediaCenterSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOperationsOrMaintSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOutdoorAthleticOrPhysEdSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingOutdoorOrNonathleticSpaceType"/> model
        /// </summary>
        Guid? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingPerformingArtsSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingScienceSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSpaceDesignType"/> model
        /// </summary>
        Guid? RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSpecEdSpecialtySpaceType"/> model
        /// </summary>
        Guid? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingStudentSupportSpaceType"/> model
        /// </summary>
        Guid? RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSpaceUseType"/> model
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
