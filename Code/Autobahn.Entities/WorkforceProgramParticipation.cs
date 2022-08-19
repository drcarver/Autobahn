using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("WorkforceProgramParticipation")]
    public partial class WorkforceProgramParticipation
    {
        public int WorkforceProgramParticipationId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        [StringLength(7)]
        public string DiplomaOrCredentialAwardDate { get; set; }

        public int? RefWfProgramParticipationId { get; set; }

        public int? RefProfessionalTechnicalCredentialTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefProfessionalTechnicalCredentialType RefProfessionalTechnicalCredentialType { get; set; }

        public virtual RefWfProgramParticipation RefWfProgramParticipation { get; set; }
    }
}
