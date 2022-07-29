using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentItemCharacteristic")]
    public partial class AssessmentItemCharacteristic
    {
        public int AssessmentItemCharacteristicId { get; set; }

        public int AssessmentItemId { get; set; }

        public int? RefAssessmentItemCharacteristicTypeId { get; set; }

        [StringLength(30)]
        public string Value { get; set; }

        [StringLength(100)]
        public string ResponseChoicePattern { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentItem AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentItemCharacteristicType RefAssessmentItemCharacteristicType { get; set; }
    }
}
