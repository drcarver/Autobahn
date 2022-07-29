using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramService")]
    public partial class IndividualizedProgramService
    {
        public int IndividualizedProgramServiceId { get; set; }

        public int PersonId { get; set; }

        public int? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        public int? RefMethodOfServiceDeliveryId { get; set; }

        public int? RefServiceFrequencyId { get; set; }

        public decimal? PlannedServiceDuration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlannedServiceStartDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIndividualizedProgramPlannedServiceType RefIndividualizedProgramPlannedServiceType { get; set; }

        public virtual RefMethodOfServiceDelivery RefMethodOfServiceDelivery { get; set; }

        public virtual RefServiceFrequency RefServiceFrequency { get; set; }
    }
}
