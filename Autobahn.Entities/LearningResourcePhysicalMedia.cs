using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResourcePhysicalMedia")]
    public partial class LearningResourcePhysicalMedia
    {
        public int LearningResourcePhysicalMediaId { get; set; }

        public int LearningResourceId { get; set; }

        public int RefLearningResourcePhysicalMediaTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLearningResourcePhysicalMediaType RefLearningResourcePhysicalMediaType { get; set; }
    }
}