using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefCampusStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefCampusStatu()
        {
            Facilities = new HashSet<Facility>();
        }

        [Key]
        public int RefCampusStatusId { get; set; }

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
        public virtual ICollection<Facility> Facilities { get; set; }

        public virtual Organization Organization { get; set; }
    }
}