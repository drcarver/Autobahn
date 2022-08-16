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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? SpaceDescription { get; set; }

    }
}
