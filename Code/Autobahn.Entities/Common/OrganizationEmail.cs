using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationEmail", Schema = "Common")]
    public partial class OrganizationEmail
    {
        public int OrganizationEmailId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(128)]
        public string ElectronicMailAddress { get; set; }

        public int? RefEmailTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefEmailType RefEmailType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
