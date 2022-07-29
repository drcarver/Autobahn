using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefEarlyChildhoodService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefEarlyChildhoodService()
        {
            ELChildServices = new HashSet<ELChildService>();
            ELChildServices1 = new HashSet<ELChildService>();
        }

        [Key]
        public int RefEarlyChildhoodServicesId { get; set; }

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
        public virtual ICollection<ELChildService> ELChildServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildService> ELChildServices1 { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
