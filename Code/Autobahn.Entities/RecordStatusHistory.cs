using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RecordStatusHistory")]
    public partial class RecordStatusHistory : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string RecordPKColumn { get; set; }

        [Required]
        [StringLength(100)]
        public string RecordTable { get; set; }

        public int? RecordStatusCreatorOrganizationId { get; set; }

        public int? RecordStatusCreatorPersonId { get; set; }

        public DateTime? RecordStatusDate { get; set; }

        public int RefRecordStatusTypeId { get; set; }

        public int? RefRecordStatusCreatorEntityId { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefRecordStatusCreatorEntity RefRecordStatusCreatorEntity { get; set; }

        public virtual RefRecordStatusType RefRecordStatusType { get; set; }
    }
}
