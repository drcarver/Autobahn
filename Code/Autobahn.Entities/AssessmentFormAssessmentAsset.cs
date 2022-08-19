using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentFormAssessmentAsset")]
    public partial class AssessmentFormAssessmentAsset
    {
        public int AssessmentFormAssessmentAssetId { get; set; }

        public int AssessmentFormId { get; set; }

        public int AssessmentAssetId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentAsset AssessmentAsset { get; set; }

        public virtual AssessmentForm AssessmentForm { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
