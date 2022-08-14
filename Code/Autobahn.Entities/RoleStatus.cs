using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RoleStatus")]
    public partial class RoleStatus
    {
        [Key]
        public int RoleStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StatusStartDate { get; set; }

        public DateTime? StatusEndDate { get; set; }

        public int? RefRoleStatusId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefRoleStatus RefRoleStatus { get; set; }
    }
}
