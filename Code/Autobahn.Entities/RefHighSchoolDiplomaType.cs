using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefHighSchoolDiplomaType")]
    public partial class RefHighSchoolDiplomaType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefHighSchoolDiplomaType()
        {
            AeStudentAcademicRecords = new HashSet<AeStudentAcademicRecord>();
            K12StudentAcademicRecord = new HashSet<K12StudentAcademicRecord>();
        }

        public int RefHighSchoolDiplomaTypeId { get; set; }

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
        public virtual ICollection<AeStudentAcademicRecord> AeStudentAcademicRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StudentAcademicRecord> K12StudentAcademicRecord { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
