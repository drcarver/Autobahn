using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationCalendarCrisis")]
    public partial class OrganizationCalendarCrisis
    {
        [Key]
        public int OrganizationCalendarCrisisId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(30)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(300)]
        public string CrisisDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CrisisEndDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
