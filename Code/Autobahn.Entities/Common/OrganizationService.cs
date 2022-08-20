using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationService", Schema = "Common")]
    public partial class OrganizationService
    {
        public int OrganizationServiceId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefStudentSupportServiceTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefStudentSupportServiceType RefStudentSupportServiceType { get; set; }
    }
}
