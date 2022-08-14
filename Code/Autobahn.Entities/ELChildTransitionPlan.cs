using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildTransitionPlan")]
    public partial class ELChildTransitionPlan
    {
        public int ELChildTransitionPlanId { get; set; }

        public int PersonId { get; set; }

        public bool? PartB619PotentialEligibilityInd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IDEAPartCToPartBNotificationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransitionConferenceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransitionConferenceDeclineDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfTransitionPlan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IDEAPartCToPartBNotificationOptOutDate { get; set; }

        public bool? IDEAPartCToPartBNotificationOptOutIndicator { get; set; }

        public int? IndividualizedProgramId { get; set; }

        public int? RefReasonDelayTransitionConfId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefReasonDelayTransitionConf RefReasonDelayTransitionConf { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
