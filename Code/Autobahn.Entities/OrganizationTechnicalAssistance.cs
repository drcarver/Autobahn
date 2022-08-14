using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationTechnicalAssistance")]
    public partial class OrganizationTechnicalAssistance
    {
        public int OrganizationTechnicalAssistanceId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefTechnicalAssistanceTypeId { get; set; }

        public int? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        public bool? TechnicalAssistanceApprovedInd { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTechnicalAssistanceDeliveryType RefTechnicalAssistanceDeliveryType { get; set; }

        public virtual RefTechnicalAssistanceType RefTechnicalAssistanceType { get; set; }
    }
}
