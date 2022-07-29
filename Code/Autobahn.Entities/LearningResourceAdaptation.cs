using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResourceAdaptation")]
    public partial class LearningResourceAdaptation
    {
        public int LearningResourceAdaptationId { get; set; }

        public int LearningResourceId { get; set; }

        [Required]
        [StringLength(512)]
        public string AdaptationURL { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
