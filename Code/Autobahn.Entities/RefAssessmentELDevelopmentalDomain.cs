using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefAssessmentELDevelopmentalDomain")]
    public partial class RefAssessmentELDevelopmentalDomain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefAssessmentELDevelopmentalDomain()
        {
            AssessmentELDevelopmentalDomains = new HashSet<AssessmentELDevelopmentalDomain>();
            AssessmentSubtestELDevelopmentalDomains = new HashSet<AssessmentSubtestELDevelopmentalDomain>();
        }

        public int RefAssessmentELDevelopmentalDomainId { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(60)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentELDevelopmentalDomain> AssessmentELDevelopmentalDomains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestELDevelopmentalDomain> AssessmentSubtestELDevelopmentalDomains { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
