using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityCompliance")]
    public partial class FacilityCompliance
    {
        public int FacilityComplianceId { get; set; }

        public int? FacilityMandateId { get; set; }

        public int? BuildingSystemComponentId { get; set; }

        [StringLength(80)]
        public string FacilityComplianceName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FacilityComplianceDeterminationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureCheckDate { get; set; }

        [StringLength(80)]
        public string FacilityComponentDeficiencyDescription { get; set; }

        public decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        [StringLength(35)]
        public string FacilityInspectionScoreResultDescription { get; set; }

        [StringLength(80)]
        public string FacilityInspectionViolationDescription { get; set; }

        public int? RefFacilityComplianceStatusId { get; set; }

        public int? RefFacilityMaintStandardTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual BuildingSystemComponent BuildingSystemComponent { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual FacilityMandate FacilityMandate { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityComplianceStatus RefFacilityComplianceStatus { get; set; }

        public virtual RefFacilityMaintStandardType RefFacilityMaintStandardType { get; set; }
    }
}
