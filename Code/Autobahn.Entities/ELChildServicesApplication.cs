using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildServicesApplication")]
    public partial class ELChildServicesApplication
    {
        public int ELChildServicesApplicationId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(40)]
        public string ELApplicationIdentifier { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApplicationDate { get; set; }

        [StringLength(40)]
        public string ELEnrollmentApplicationDocumentIdentifier { get; set; }

        [StringLength(60)]
        public string ELEnrollmentApplicationDocumentName { get; set; }

        [StringLength(100)]
        public string ELEnrollmentApplicationDocumentType { get; set; }

        public bool? ELApplicationRequiredDocument { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ELEnrollmentApplicationVerificationDate { get; set; }

        [StringLength(100)]
        public string ELEnrollmentApplicationVerificationReasonType { get; set; }

        [StringLength(300)]
        public string SitePreferenceRank { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
