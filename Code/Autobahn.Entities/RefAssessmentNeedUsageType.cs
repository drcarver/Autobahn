using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefAssessmentNeedUsageType")]
    public partial class RefAssessmentNeedUsageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefAssessmentNeedUsageType()
        {
            AssessmentNeedBrailles = new HashSet<AssessmentNeedBraille>();
            AssessmentPersonalNeedScreenReaders = new HashSet<AssessmentPersonalNeedScreenReader>();
        }

        public int RefAssessmentNeedUsageTypeId { get; set; }

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
        public virtual ICollection<AssessmentNeedBraille> AssessmentNeedBrailles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentPersonalNeedScreenReader> AssessmentPersonalNeedScreenReaders { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
