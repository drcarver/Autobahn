using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityDesignConstruction")]
    public partial class FacilityDesignConstruction
    {
        public int FacilityDesignConstructionId { get; set; }

        public int FacilityDesignId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FacilityConstructionDate { get; set; }

        [StringLength(4)]
        public string FacilityConstructionYear { get; set; }

        [StringLength(30)]
        public string BuildingAdditionCode { get; set; }

        [StringLength(80)]
        public string BuildingAdditionDescription { get; set; }

        [StringLength(4)]
        public string FacilityAdditionYear { get; set; }

        [StringLength(80)]
        public string BuildingSiteImprovementDescription { get; set; }

        public int? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        public int? RefFacilityConstructionDateTypeId { get; set; }

        public int? RefFacilityConstructionMaterialTypeId { get; set; }

        public int? RefFacilityJointDevelopmentTypeId { get; set; }

        public int? RefFacilitySiteImprovementLocationTypeId { get; set; }

        public int? RefFacilityStandardTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual FacilityDesign FacilityDesign { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBuildingEnergyConservationMeasureType RefBuildingEnergyConservationMeasureType { get; set; }

        public virtual RefFacilityConstructionDateType RefFacilityConstructionDateType { get; set; }

        public virtual RefFacilityConstructionMaterialType RefFacilityConstructionMaterialType { get; set; }

        public virtual RefFacilityJointDevelopmentType RefFacilityJointDevelopmentType { get; set; }

        public virtual RefFacilitySiteImprovementLocationType RefFacilitySiteImprovementLocationType { get; set; }

        public virtual RefFacilityStandardType RefFacilityStandardType { get; set; }
    }
}
