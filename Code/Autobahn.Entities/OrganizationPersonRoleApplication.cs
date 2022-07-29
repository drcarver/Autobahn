using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationPersonRoleApplication")]
    public partial class OrganizationPersonRoleApplication
    {
        public int OrganizationPersonRoleApplicationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public DateTime ApplicationDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
