using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELProgramLicensing")]
    public partial class ELProgramLicensing
    {
        public int ELProgramLicensingId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefELProgramLicenseStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InitialLicenseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContinuingLicenseDate { get; set; }

        public bool? LicenseSuspensionStatus { get; set; }

        public bool? LicenseRevocationStatus { get; set; }

        public int? NumberOfFatalities { get; set; }

        public int? NumberOfInjuries { get; set; }

        public int? RefLicenseExemptId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELProgramLicenseStatu RefELProgramLicenseStatu { get; set; }

        public virtual RefLicenseExempt RefLicenseExempt { get; set; }
    }
}
