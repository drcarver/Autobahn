using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELStaffAssignment")]
    public partial class ELStaffAssignment
    {
        public int ELStaffAssignmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool ItinerantProvider { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}