using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffTechnicalAssistance")]
    public partial class StaffTechnicalAssistance
    {
        public int StaffTechnicalAssistanceId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefTechnicalAssistanceTypeId { get; set; }

        public int? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        public bool? TechnicalAssistanceApprovedInd { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTechnicalAssistanceDeliveryType RefTechnicalAssistanceDeliveryType { get; set; }

        public virtual RefTechnicalAssistanceType RefTechnicalAssistanceType { get; set; }
    }
}
