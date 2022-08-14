using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationAttainment")]
    public partial class ProgramParticipationAttainment
    {
        public int ProgramParticipationAttainmentId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public bool? AECredentialAttainmentEmployedIndicator { get; set; }

        public bool? AECredentialAttainmentPSCredentialIndicator { get; set; }

        public bool? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        public int? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        public int? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType { get; set; }

        public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeType RefEdFactsAcademicOrCareerAndTechnicalOutcomeType { get; set; }
    }
}
