using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentPersonalNeedsProfileScreenEnhancement")]
    public partial class AssessmentPersonalNeedsProfileScreenEnhancement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentPersonalNeedsProfileScreenEnhancement()
        {
            AssessmentNeedScreenEnhancements = new HashSet<AssessmentNeedScreenEnhancement>();
        }

        public int AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        public int AssessmentPersonalNeedsProfileId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentNeedScreenEnhancement> AssessmentNeedScreenEnhancements { get; set; }

        public virtual AssessmentPersonalNeedsProfile AssessmentPersonalNeedsProfile { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
