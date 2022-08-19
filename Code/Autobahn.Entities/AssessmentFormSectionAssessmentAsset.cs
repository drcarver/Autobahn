using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentFormSectionAssessmentAsset")]
    public partial class AssessmentFormSectionAssessmentAsset
    {
        public int AssessmentFormSectionAssessmentAssetId { get; set; }

        public int AssessmentFormSectionId { get; set; }

        public int AssessmentAssetId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentAsset AssessmentAsset { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
