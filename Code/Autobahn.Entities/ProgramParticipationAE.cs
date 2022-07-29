using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationAE")]
    public partial class ProgramParticipationAE
    {
        public int PersonProgramParticipationId { get; set; }

        public int? RefAeInstructionalProgramTypeId { get; set; }

        public int? RefAePostsecondaryTransitionActionId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PostsecondaryTransitionDate { get; set; }

        public int? RefAeSpecialProgramTypeId { get; set; }

        public int? RefAeFunctioningLevelAtIntakeId { get; set; }

        public int? RefAeFunctioningLevelAtPosttestId { get; set; }

        public int? RefGoalsForAttendingAdultEducationId { get; set; }

        public bool? DisplacedHomemakerIndicator { get; set; }

        public decimal? ProxyContactHours { get; set; }

        public decimal? InstructionalActivityHoursCompleted { get; set; }

        public int? RefCorrectionalEducationFacilityTypeId { get; set; }

        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }

        public int ProgramParticipationAEId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? OutOfWorkforceIndicator { get; set; }

        public int? RefAdultEducationProgramExitReasonId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RefAeSpecialProgramType RefAeSpecialProgramType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdultEducationProgramExitReason RefAdultEducationProgramExitReason { get; set; }

        public virtual RefAeFunctioningLevelAtIntake RefAeFunctioningLevelAtIntake { get; set; }

        public virtual RefAeFunctioningLevelAtPosttest RefAeFunctioningLevelAtPosttest { get; set; }

        public virtual RefAeInstructionalProgramType RefAeInstructionalProgramType { get; set; }

        public virtual RefAePostsecondaryTransitionAction RefAePostsecondaryTransitionAction { get; set; }

        public virtual RefCorrectionalEducationFacilityType RefCorrectionalEducationFacilityType { get; set; }

        public virtual RefGoalsForAttendingAdultEducation RefGoalsForAttendingAdultEducation { get; set; }

        public virtual RefWorkbasedLearningOpportunityType RefWorkbasedLearningOpportunityType { get; set; }
    }
}
