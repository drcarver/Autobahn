using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("BuildingSpace", Schema = "Facilities")]
    public partial class BuildingSpace
    {
        public BuildingSpace()
        {
            BuildingSpaceUtilizations = new HashSet<BuildingSpaceUtilization>();
        }

        [Key]
        public int BuildingSpaceId { get; set; }
        public int FacilityId { get; set; }
        [StringLength(300)]
        public string? SpaceDescription { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("BuildingSpaces")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("FacilityId")]
        [InverseProperty("BuildingSpaces")]
        public virtual Facility Facility { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBuildingAdministrativeSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingAdministrativeSpaceType? RefBuildingAdministrativeSpaceType { get; set; }
        [ForeignKey("RefBuildingArtSpecialtySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingArtSpecialtySpaceType? RefBuildingArtSpecialtySpaceType { get; set; }
        [ForeignKey("RefBuildingAssemblySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingAssemblySpaceType? RefBuildingAssemblySpaceType { get; set; }
        [ForeignKey("RefBuildingBasicClassroomDesignTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingBasicClassroomDesignType? RefBuildingBasicClassroomDesignType { get; set; }
        [ForeignKey("RefBuildingCareerTechEducationSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingCareerTechEducationSpaceType? RefBuildingCareerTechEducationSpaceType { get; set; }
        [ForeignKey("RefBuildingCirculationSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingCirculationSpaceType? RefBuildingCirculationSpaceType { get; set; }
        [ForeignKey("RefBuildingFoodServiceSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingFoodServiceSpaceType? RefBuildingFoodServiceSpaceType { get; set; }
        [ForeignKey("RefBuildingFullServiceKitchenTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingFullServiceKitchenType? RefBuildingFullServiceKitchenType { get; set; }
        [ForeignKey("RefBuildingIndoorAthleticOrPhysEdSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingIndoorAthleticOrPhysEdSpaceType? RefBuildingIndoorAthleticOrPhysEdSpaceType { get; set; }
        [ForeignKey("RefBuildingLibMediaCenterSpecialtySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingLibMediaCenterSpecialtySpaceType? RefBuildingLibMediaCenterSpecialtySpaceType { get; set; }
        [ForeignKey("RefBuildingOperationsOrMaintSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingOperationsOrMaintSpaceType? RefBuildingOperationsOrMaintSpaceType { get; set; }
        [ForeignKey("RefBuildingOutdoorAthleticOrPhysEdSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingOutdoorAthleticOrPhysEdSpaceType? RefBuildingOutdoorAthleticOrPhysEdSpaceType { get; set; }
        [ForeignKey("RefBuildingOutdoorOrNonathleticSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingOutdoorOrNonathleticSpaceType? RefBuildingOutdoorOrNonathleticSpaceType { get; set; }
        [ForeignKey("RefBuildingPerformingArtsSpecialtySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingPerformingArtsSpecialtySpaceType? RefBuildingPerformingArtsSpecialtySpaceType { get; set; }
        [ForeignKey("RefBuildingScienceSpecialtySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingScienceSpecialtySpaceType? RefBuildingScienceSpecialtySpaceType { get; set; }
        [ForeignKey("RefBuildingSpaceDesignTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingSpaceDesignType? RefBuildingSpaceDesignType { get; set; }
        [ForeignKey("RefBuildingSpecEdSpecialtySpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingSpecEdSpecialtySpaceType? RefBuildingSpecEdSpecialtySpaceType { get; set; }
        [ForeignKey("RefBuildingStudentSupportSpaceTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefBuildingStudentSupportSpaceType? RefBuildingStudentSupportSpaceType { get; set; }
        [ForeignKey("RefSpaceUseTypeId")]
        [InverseProperty("BuildingSpaces")]
        public virtual RefSpaceUseType? RefSpaceUseType { get; set; }
        [InverseProperty("BuildingSpace")]
        public virtual ICollection<BuildingSpaceUtilization> BuildingSpaceUtilizations { get; set; }
    }
}
