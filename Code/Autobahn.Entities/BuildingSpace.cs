using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("BuildingSpace")]
    public partial class BuildingSpace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildingSpace()
        {
            BuildingSpaceUtilizations = new HashSet<BuildingSpaceUtilization>();
        }

        public int BuildingSpaceId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(300)]
        public string SpaceDescription { get; set; }

        public int? RefSpaceUseTypeId { get; set; }

        public int? RefBuildingAdministrativeSpaceTypeId { get; set; }

        public int? RefBuildingArtSpecialtySpaceTypeId { get; set; }

        public int? RefBuildingAssemblySpaceTypeId { get; set; }

        public int? RefBuildingBasicClassroomDesignTypeId { get; set; }

        public int? RefBuildingCareerTechEducationSpaceTypeId { get; set; }

        public int? RefBuildingCirculationSpaceTypeId { get; set; }

        public int? RefBuildingFoodServiceSpaceTypeId { get; set; }

        public int? RefBuildingFullServiceKitchenTypeId { get; set; }

        public int? RefBuildingIndoorAthleticOrPhysEdSpaceTypeId { get; set; }

        public int? RefBuildingLibMediaCenterSpecialtySpaceTypeId { get; set; }

        public int? RefBuildingOperationsOrMaintSpaceTypeId { get; set; }

        public int? RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId { get; set; }

        public int? RefBuildingOutdoorOrNonathleticSpaceTypeId { get; set; }

        public int? RefBuildingPerformingArtsSpecialtySpaceTypeId { get; set; }

        public int? RefBuildingScienceSpecialtySpaceTypeId { get; set; }

        public int? RefBuildingSpaceDesignTypeId { get; set; }

        public int? RefBuildingSpecEdSpecialtySpaceTypeId { get; set; }

        public int? RefBuildingStudentSupportSpaceTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingAdministrativeSpaceType RefBuildingAdministrativeSpaceType { get; set; }

        public virtual RefBuildingArtSpecialtySpaceType RefBuildingArtSpecialtySpaceType { get; set; }

        public virtual RefBuildingAssemblySpaceType RefBuildingAssemblySpaceType { get; set; }

        public virtual RefBuildingBasicClassroomDesignType RefBuildingBasicClassroomDesignType { get; set; }

        public virtual RefBuildingCareerTechEducationSpaceType RefBuildingCareerTechEducationSpaceType { get; set; }

        public virtual RefBuildingCirculationSpaceType RefBuildingCirculationSpaceType { get; set; }

        public virtual RefBuildingFoodServiceSpaceType RefBuildingFoodServiceSpaceType { get; set; }

        public virtual RefBuildingFullServiceKitchenType RefBuildingFullServiceKitchenType { get; set; }

        public virtual RefBuildingIndoorAthleticOrPhysEdSpaceType RefBuildingIndoorAthleticOrPhysEdSpaceType { get; set; }

        public virtual RefBuildingLibMediaCenterSpecialtySpaceType RefBuildingLibMediaCenterSpecialtySpaceType { get; set; }

        public virtual RefBuildingOperationsOrMaintSpaceType RefBuildingOperationsOrMaintSpaceType { get; set; }

        public virtual RefBuildingOutdoorAthleticOrPhysEdSpaceType RefBuildingOutdoorAthleticOrPhysEdSpaceType { get; set; }

        public virtual RefBuildingOutdoorOrNonathleticSpaceType RefBuildingOutdoorOrNonathleticSpaceType { get; set; }

        public virtual RefBuildingPerformingArtsSpecialtySpaceType RefBuildingPerformingArtsSpecialtySpaceType { get; set; }

        public virtual RefBuildingScienceSpecialtySpaceType RefBuildingScienceSpecialtySpaceType { get; set; }

        public virtual RefBuildingSpaceDesignType RefBuildingSpaceDesignType { get; set; }

        public virtual RefBuildingSpecEdSpecialtySpaceType RefBuildingSpecEdSpecialtySpaceType { get; set; }

        public virtual RefBuildingStudentSupportSpaceType RefBuildingStudentSupportSpaceType { get; set; }

        public virtual RefSpaceUseType RefSpaceUseType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingSpaceUtilization> BuildingSpaceUtilizations { get; set; }
    }
}
