using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityMandate")]
    public partial class FacilityMandate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityMandate()
        {
            FacilityCompliances = new HashSet<FacilityCompliance>();
        }

        public int FacilityMandateId { get; set; }

        public int FacilityId { get; set; }

        [StringLength(60)]
        public string FacilityStateOrLocalMandateName { get; set; }

        public int? RefFacilitiesMandateAuthorityTypeId { get; set; }

        public int? RefFacilityApplicableFederalMandateTypeId { get; set; }

        public int? RefFacilityFederalMandateInterestTypeId { get; set; }

        public int? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityCompliance> FacilityCompliances { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilitiesMandateAuthorityType RefFacilitiesMandateAuthorityType { get; set; }

        public virtual RefFacilityApplicableFederalMandateType RefFacilityApplicableFederalMandateType { get; set; }

        public virtual RefFacilityFederalMandateInterestType RefFacilityFederalMandateInterestType { get; set; }

        public virtual RefFacilityStateOrLocalMandateInterestType RefFacilityStateOrLocalMandateInterestType { get; set; }
    }
}
