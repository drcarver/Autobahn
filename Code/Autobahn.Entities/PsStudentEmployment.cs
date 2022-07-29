using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentEmployment")]
    public partial class PsStudentEmployment
    {
        public int PsStudentEmploymentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(6)]
        public string EmploymentNaicsCode { get; set; }

        public int? RefEmployedWhileEnrolledId { get; set; }

        public int? RefEmployedAfterExitId { get; set; }

        public int? RefEmploymentStatusWhileEnrolledId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmployedAfterExit RefEmployedAfterExit { get; set; }

        public virtual RefEmployedWhileEnrolled RefEmployedWhileEnrolled { get; set; }

        public virtual RefEmploymentStatusWhileEnrolled RefEmploymentStatusWhileEnrolled { get; set; }
    }
}
