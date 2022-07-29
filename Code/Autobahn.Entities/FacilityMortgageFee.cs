using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("FacilityMortgageFee")]
    public partial class FacilityMortgageFee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityMortgageFee()
        {
            FacilityFinancials = new HashSet<FacilityFinancial>();
        }

        public int FacilityMortgageFeeId { get; set; }

        public int FacilityMortgageId { get; set; }

        public int RefFacilityFinancingFeeTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityFinancial> FacilityFinancials { get; set; }

        public virtual FacilityMortgage FacilityMortgage { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFacilityFinancingFeeType RefFacilityFinancingFeeType { get; set; }
    }
}
