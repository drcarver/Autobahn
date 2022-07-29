using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencyDefEducationLevel")]
    public partial class CompetencyDefEducationLevel
    {
        public int CompetencyDefEducationLevelId { get; set; }

        public int CompetencyDefinitionId { get; set; }

        public int RefEducationLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CompetencyDefinition CompetencyDefinition { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEducationLevel RefEducationLevel { get; set; }
    }
}
