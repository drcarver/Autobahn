using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationTitleIIILep")]
    public partial class ProgramParticipationTitleIIILep
    {
        public int? RefTitleIIIAccountabilityId { get; set; }

        public int? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int ProgramParticipationTitleIiiLepId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTitleIIIAccountability RefTitleIIIAccountability { get; set; }

        public virtual RefTitleIIILanguageInstructionProgramType RefTitleIIILanguageInstructionProgramType { get; set; }
    }
}
