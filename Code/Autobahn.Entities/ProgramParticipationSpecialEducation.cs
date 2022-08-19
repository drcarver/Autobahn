using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationSpecialEducation")]
    public partial class ProgramParticipationSpecialEducation
    {
        public int ProgramParticipationSpecialEducationId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public bool? AwaitingInitialIDEAEvaluationStatus { get; set; }

        public decimal? SpecialEducationFTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SpecialEducationServicesExitDate { get; set; }

        public string IDEAPlacementRationale { get; set; }

        public int? RefIDEAEducationalEnvironmentECId { get; set; }

        public int? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        public int? RefSpecialEducationExitReasonId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RefIDEAEducationalEnvironmentEC RefIDEAEducationalEnvironmentEC { get; set; }

        public virtual RefIDEAEducationalEnvironmentSchoolAge RefIDEAEducationalEnvironmentSchoolAge { get; set; }

        public virtual RefSpecialEducationExitReason RefSpecialEducationExitReason { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
