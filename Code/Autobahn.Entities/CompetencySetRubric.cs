using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencySetRubric")]
    public partial class CompetencySetRubric
    {
        public int CompetencySetRubricId { get; set; }

        public int CompetencySetId { get; set; }

        public int RubricId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CompetencySet CompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual Rubric Rubric { get; set; }
    }
}
