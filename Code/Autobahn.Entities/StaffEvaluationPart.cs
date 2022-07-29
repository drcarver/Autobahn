using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffEvaluationPart")]
    public partial class StaffEvaluationPart
    {
        public int StaffEvaluationPartId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(60)]
        public string PartName { get; set; }

        [StringLength(80)]
        public string Scale { get; set; }

        [StringLength(60)]
        public string ScoreOrRating { get; set; }

        public int? StaffEvaluationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual StaffEvaluation StaffEvaluation { get; set; }
    }
}
