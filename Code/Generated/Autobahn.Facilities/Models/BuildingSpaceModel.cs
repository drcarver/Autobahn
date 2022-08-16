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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingAdministrativeSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingArtSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingAssemblySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingBasicClassroomDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingCirculationSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingFoodServiceSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingFullServiceKitchenTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingSpaceDesignTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingStudentSupportSpaceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSpaceUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? SpaceDescription { get; set; }

    }
}
