using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELFacilityLicensing")]
    public partial class ELFacilityLicensing
    {
        public int ELFacilityLicensingId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefELFacilityLicensingStatusId { get; set; }

        public int? StateLicensedFacilityCapacity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InitialLicensingDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContinuingLicenseDate { get; set; }

        public int? RefLicenseExemptId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELFacilityLicensingStatu RefELFacilityLicensingStatu { get; set; }

        public virtual RefLicenseExempt RefLicenseExempt { get; set; }
    }
}
