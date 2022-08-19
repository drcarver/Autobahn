using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramServicesReceived")]
    public partial class IndividualizedProgramServicesReceived
    {
        public int IndividualizedProgramServicesReceivedId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public int ServicesReceivedId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual ServicesReceived ServicesReceived { get; set; }
    }
}
