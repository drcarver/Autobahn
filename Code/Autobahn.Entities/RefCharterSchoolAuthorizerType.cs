using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefCharterSchoolAuthorizerType")]
    public partial class RefCharterSchoolAuthorizerType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefCharterSchoolAuthorizerType()
        {
            K12CharterSchoolAuthorizerAgency = new HashSet<K12CharterSchoolAuthorizerAgency>();
        }

        public int RefCharterSchoolAuthorizerTypeId { get; set; }

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
        public virtual ICollection<K12CharterSchoolAuthorizerAgency> K12CharterSchoolAuthorizerAgency { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
