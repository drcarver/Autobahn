using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Rubric")]
    public partial class Rubric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rubric()
        {
            AssessmentItems = new HashSet<AssessmentItem>();
            CompetencySet_Rubric = new HashSet<CompetencySet_Rubric>();
            RubricCriterions = new HashSet<RubricCriterion>();
        }

        public int RubricId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(512)]
        public string UrlReference { get; set; }

        public string Description { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItem> AssessmentItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet_Rubric> CompetencySet_Rubric { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RubricCriterion> RubricCriterions { get; set; }
    }
}
