using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonCareerEducationPlan")]
    public partial class PersonCareerEducationPlan
    {
        public int PersonCareerEducationPlanId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdated { get; set; }

        public int? RefCareerEducationPlanTypeId { get; set; }

        public bool? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

        public bool? TuitionFunded { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCareerEducationPlanType RefCareerEducationPlanType { get; set; }
    }
}
