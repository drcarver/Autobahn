using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencyDefinitionCompetencySet")]
    public partial class CompetencyDefinitionCompetencySet
    {
        public int CompetencyDefinitionCompetencySetId { get; set; }

        public int CompetencySetId { get; set; }

        public int CompetencyDefinitionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CompetencyDefinition CompetencyDefinition { get; set; }

        public virtual CompetencySet CompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
