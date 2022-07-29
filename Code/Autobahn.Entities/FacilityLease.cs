using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityLease")]
    public partial class FacilityLease
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityLease()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
        }

        public int FacilityLeaseId { get; set; }

        public int FacilityId { get; set; }

        public decimal? FacilityLeaseAmount { get; set; }

        public int? RefFacilityLeaseAmountCategoryId { get; set; }

        public int? RefFacilityLeaseTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityLeaseAmountCategory RefFacilityLeaseAmountCategory { get; set; }

        public virtual RefFacilityLeaseType RefFacilityLeaseType { get; set; }
    }
}
