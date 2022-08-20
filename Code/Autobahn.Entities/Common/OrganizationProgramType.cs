using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationProgramType", Schema = "Common")]
    public partial class OrganizationProgramType
    {
        public int OrganizationProgramTypeId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefProgramTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefProgramType RefProgramType { get; set; }
    }
}
