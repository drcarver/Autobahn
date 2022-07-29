using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemPossibleResponse")]
    public partial class AssessmentItemPossibleResponse
    {
        public int AssessmentItemPossibleResponseId { get; set; }

        public int AssessmentItemId { get; set; }

        public string PossibleResponseOption { get; set; }

        [StringLength(300)]
        public string Value { get; set; }

        public bool? CorrectIndicator { get; set; }

        [StringLength(300)]
        public string FeedbackMessage { get; set; }

        public int? SequenceNumber { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
