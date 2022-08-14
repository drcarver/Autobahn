using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationWIOA")]
    public partial class ProgramParticipationWIOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramParticipationWIOA()
        {
            ProgramParticipationWIOABarriers = new HashSet<ProgramParticipationWIOABarrier>();
        }

        public int ProgramParticipationWIOAId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public bool? WIOACareerServices { get; set; }

        public bool? WIOATrainingServices { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramParticipationWIOABarrier> ProgramParticipationWIOABarriers { get; set; }
    }
}
