using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResourceEducationLevel")]
    public partial class LearningResourceEducationLevel
    {
        public int LearningResourceEducationLevelId { get; set; }

        public int LearningResourceId { get; set; }

        public int RefEducationLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEducationLevel RefEducationLevel { get; set; }
    }
}
