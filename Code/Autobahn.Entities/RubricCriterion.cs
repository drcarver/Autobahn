using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RubricCriterion")]
    public partial class RubricCriterion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RubricCriterion()
        {
            CompetencySet_RubricCriterion = new HashSet<CompetencySet_RubricCriterion>();
            RubricCriterionLevels = new HashSet<RubricCriterionLevel>();
        }

        public int RubricCriterionId { get; set; }

        [StringLength(30)]
        public string Category { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal? Weight { get; set; }

        public int? Position { get; set; }

        public int RubricId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet_RubricCriterion> CompetencySet_RubricCriterion { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual Rubric Rubric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RubricCriterionLevel> RubricCriterionLevels { get; set; }
    }
}