using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefTitleIInstructionalService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefTitleIInstructionalService()
        {
            K12ProgramOrService = new HashSet<K12ProgramOrService>();
        }

        [Key]
        public int RefTitleIInstructionalServicesId { get; set; }

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
        public virtual ICollection<K12ProgramOrService> K12ProgramOrService { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
