using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefTitleIIILanguageInstructionProgramType")]
    public partial class RefTitleIIILanguageInstructionProgramType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefTitleIIILanguageInstructionProgramType()
        {
            K12TitleIIILanguageInstruction = new HashSet<K12TitleIIILanguageInstruction>();
            ProgramParticipationTitleIIILeps = new HashSet<ProgramParticipationTitleIIILep>();
        }

        public int RefTitleIIILanguageInstructionProgramTypeId { get; set; }

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
        public virtual ICollection<K12TitleIIILanguageInstruction> K12TitleIIILanguageInstruction { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramParticipationTitleIIILep> ProgramParticipationTitleIIILeps { get; set; }
    }
}
