using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationProgramType")]
    public partial class OrganizationProgramType
    {
        public int OrganizationProgramTypeId { get; set; }

        public int OrganizationId { get; set; }

        public int RefProgramTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefProgramType RefProgramType { get; set; }
    }
}
