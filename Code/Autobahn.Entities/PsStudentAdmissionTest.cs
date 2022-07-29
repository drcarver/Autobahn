using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentAdmissionTest")]
    public partial class PsStudentAdmissionTest
    {
        public int PsStudentAdmissionTestId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int RefStandardizedAdmissionTestId { get; set; }

        public decimal? StandardizedAdmissionTestScore { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefStandardizedAdmissionTest RefStandardizedAdmissionTest { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
