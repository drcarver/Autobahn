using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProgramParticipationFoodService")]
    public partial class ProgramParticipationFoodService
    {
        public int ProgramParticipationFoodServiceId { get; set; }

        public int PersonProgramParticipationId { get; set; }

        public int RefSchoolFoodServiceProgramId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual PersonProgramParticipation PersonProgramParticipation { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefSchoolFoodServiceProgram RefSchoolFoodServiceProgram { get; set; }
    }
}
