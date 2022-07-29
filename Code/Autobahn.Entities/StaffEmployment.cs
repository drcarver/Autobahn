using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffEmployment")]
    public partial class StaffEmployment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffEmployment()
        {
            ELStaffEmployments = new HashSet<ELStaffEmployment>();
            K12StaffEmployment = new HashSet<K12StaffEmployment>();
            PsStaffEmployments = new HashSet<PsStaffEmployment>();
            StaffCompensations = new HashSet<StaffCompensation>();
        }

        public int StaffEmploymentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HireDate { get; set; }

        [StringLength(45)]
        public string PositionTitle { get; set; }

        [StringLength(200)]
        public string UnionMembershipName { get; set; }

        public int? WeeksEmployedPerYear { get; set; }

        [StringLength(7)]
        public string StandardOccupationalClassification { get; set; }

        public int? RefEmploymentSeparationTypeId { get; set; }

        public int? RefEmploymentSeparationReasonId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public decimal? FullTimeEquivalency { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELStaffEmployment> ELStaffEmployments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StaffEmployment> K12StaffEmployment { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsStaffEmployment> PsStaffEmployments { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmploymentSeparationReason RefEmploymentSeparationReason { get; set; }

        public virtual RefEmploymentSeparationType RefEmploymentSeparationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffCompensation> StaffCompensations { get; set; }
    }
}
