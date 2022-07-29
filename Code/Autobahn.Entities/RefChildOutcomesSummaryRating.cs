using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefChildOutcomesSummaryRating")]
    public partial class RefChildOutcomesSummaryRating
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefChildOutcomesSummaryRating()
        {
            ELChildOutcomeSummaries = new HashSet<ELChildOutcomeSummary>();
            ELChildOutcomeSummaries1 = new HashSet<ELChildOutcomeSummary>();
            ELChildOutcomeSummaries2 = new HashSet<ELChildOutcomeSummary>();
        }

        public int RefChildOutcomesSummaryRatingId { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildOutcomeSummary> ELChildOutcomeSummaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildOutcomeSummary> ELChildOutcomeSummaries1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildOutcomeSummary> ELChildOutcomeSummaries2 { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
