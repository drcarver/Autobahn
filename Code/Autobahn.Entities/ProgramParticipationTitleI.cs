using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationTitleI")]
    public partial class ProgramParticipationTitleI
    {
        public int ProgramParticipationTitleIId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public int? RefTitleIIndicatorId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTitleIIndicator RefTitleIIndicator { get; set; }
    }
}
