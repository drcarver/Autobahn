using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu()
        {
            K12SchoolStatus = new HashSet<K12SchoolStatus>();
        }

        [Key]
        public int RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

        [Required]
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
        public virtual ICollection<K12SchoolStatus> K12SchoolStatus { get; set; }
    }
}
