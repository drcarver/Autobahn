using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefIndicatorStatusSubgroupType")]
    public partial class RefIndicatorStatusSubgroupType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIndicatorStatusSubgroupType()
        {
            K12SchoolIndicatorStatus = new HashSet<K12SchoolIndicatorStatus>();
        }

        public int RefIndicatorStatusSubgroupTypeId { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12SchoolIndicatorStatus> K12SchoolIndicatorStatus { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
