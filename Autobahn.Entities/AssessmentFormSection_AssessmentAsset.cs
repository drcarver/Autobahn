using System;

namespace Autobahn.Entities
{
    public partial class AssessmentFormSection_AssessmentAsset
    {
        public int AssessmentFormSection_AssessmentAssetId { get; set; }

        public int AssessmentFormSectionId { get; set; }

        public int AssessmentAssetId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentAsset AssessmentAsset { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
