using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefIndicatorStateDefinedStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefIndicatorStateDefinedStatu()
        {
            K12SchoolIndicatorStatus = new HashSet<K12SchoolIndicatorStatus>();
        }

        [Key]
        public int RefIndicatorStateDefinedStatusId { get; set; }

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