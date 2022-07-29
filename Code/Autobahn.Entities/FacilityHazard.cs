using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityHazard")]
    public partial class FacilityHazard
    {
        public int FacilityHazardId { get; set; }

        public int FacilityId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

        [StringLength(60)]
        public string FacilityLocationOfHazardousMaterials { get; set; }

        public string FacilityNearbyEnvHazardDescription { get; set; }

        [StringLength(80)]
        public string HazardousMaterialOrConditionDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

        public int? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        public int? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityHazardousMaterialsOrCondType RefFacilityHazardousMaterialsOrCondType { get; set; }

        public virtual RefFacilityNaturallyOccurringHazardType RefFacilityNaturallyOccurringHazardType { get; set; }
    }
}
