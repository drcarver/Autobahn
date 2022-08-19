using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AeStudentEmployment")]
    public partial class AeStudentEmployment
    {
        public int AeStudentEmploymentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(6)]
        public string EmploymentNaicsCode { get; set; }

        public int? RefEmployedWhileEnrolledId { get; set; }

        public int? RefEmployedAfterExitId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmployedAfterExit RefEmployedAfterExit { get; set; }

        public virtual RefEmployedWhileEnrolled RefEmployedWhileEnrolled { get; set; }
    }
}
