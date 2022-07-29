using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentNeedScreenEnhancement")]
    public partial class AssessmentNeedScreenEnhancement
    {
        public int AssessmentNeedScreenEnhancementId { get; set; }

        public int AssessmentPersonalNeedsProfileDisplayId { get; set; }

        public bool? InvertColorChoice { get; set; }

        public decimal? Magnification { get; set; }

        public int? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        [StringLength(6)]
        public string ForegroundColor { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual AssessmentPersonalNeedsProfileScreenEnhancement AssessmentPersonalNeedsProfileScreenEnhancement { get; set; }

        public virtual AssessmentPersonalNeedsProfileDisplay AssessmentPersonalNeedsProfileDisplay { get; set; }
    }
}
