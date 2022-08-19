using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentPerformanceLevel")]
    public partial class AssessmentPerformanceLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentPerformanceLevel()
        {
            AssessmentResultPerformanceLevel = new HashSet<AssessmentResultPerformanceLevel>();
        }

        public int AssessmentPerformanceLevelId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? AssessmentSubtestId { get; set; }

        [StringLength(30)]
        public string ScoreMetric { get; set; }

        [StringLength(20)]
        public string Label { get; set; }

        [StringLength(30)]
        public string LowerCutScore { get; set; }

        [StringLength(30)]
        public string UpperCutScore { get; set; }

        public string DescriptiveFeedback { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResultPerformanceLevel> AssessmentResultPerformanceLevel { get; set; }

        public virtual AssessmentSubtest AssessmentSubtest { get; set; }
    }
}
