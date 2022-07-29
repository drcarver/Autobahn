using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELOrganization")]
    public partial class ELOrganization
    {
        public int ELOrganizationId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefProfitStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefProfitStatu RefProfitStatu { get; set; }
    }
}
