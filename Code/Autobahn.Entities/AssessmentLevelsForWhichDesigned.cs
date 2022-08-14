using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentLevelsForWhichDesigned")]
    public partial class AssessmentLevelsForWhichDesigned
    {
        public int AssessmentLevelsForWhichDesignedId { get; set; }

        public int AssessmentId { get; set; }

        public int RefGradeLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Assessment Assessment { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
