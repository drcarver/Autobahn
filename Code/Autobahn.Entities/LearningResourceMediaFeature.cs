using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResourceMediaFeature")]
    public partial class LearningResourceMediaFeature
    {
        public int LearningResourceMediaFeatureId { get; set; }

        public int LearningResourceId { get; set; }

        public int RefLearningResourceMediaFeatureTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLearningResourceMediaFeatureType RefLearningResourceMediaFeatureType { get; set; }
    }
}
