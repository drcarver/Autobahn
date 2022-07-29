using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ApipInteraction")]
    public partial class ApipInteraction
    {
        public int ApipInteractionId { get; set; }

        public int AssessmentItemApipId { get; set; }

        public string Xml { get; set; }

        public int? SequenceNumber { get; set; }

        public decimal? APIPInteractionSequenceNumber { get; set; }

        public int? RefApipInteractionTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItemApip AssessmentItemApip { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefApipInteractionType RefApipInteractionType { get; set; }
    }
}
