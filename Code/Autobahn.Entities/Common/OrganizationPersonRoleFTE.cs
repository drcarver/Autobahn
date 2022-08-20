using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationPersonRoleFTE", Schema = "Common")]
    public partial class OrganizationPersonRoleFTE
    {
        public int OrganizationPersonRoleFTEId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal FullTimeEquivalency { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
