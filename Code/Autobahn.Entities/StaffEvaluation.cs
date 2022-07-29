using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffEvaluation")]
    public partial class StaffEvaluation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffEvaluation()
        {
            StaffEvaluationParts = new HashSet<StaffEvaluationPart>();
        }

        public int StaffEvaluationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(60)]
        public string System { get; set; }

        [StringLength(80)]
        public string Scale { get; set; }

        [StringLength(60)]
        public string ScoreOrRating { get; set; }

        [StringLength(80)]
        public string Outcome { get; set; }

        public int? RefStaffPerformanceLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefStaffPerformanceLevel RefStaffPerformanceLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffEvaluationPart> StaffEvaluationParts { get; set; }
    }
}
