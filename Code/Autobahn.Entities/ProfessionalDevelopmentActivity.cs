using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProfessionalDevelopmentActivity")]
    public partial class ProfessionalDevelopmentActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfessionalDevelopmentActivity()
        {
            PDActivityEducationLevels = new HashSet<PDActivityEducationLevel>();
            ProfessionalDevelopmentSessions = new HashSet<ProfessionalDevelopmentSession>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        }

        public int ProfessionalDevelopmentActivityId { get; set; }

        public int ProfessionalDevelopmentRequirementId { get; set; }

        public int? CourseId { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [StringLength(40)]
        public string ActivityIdentifier { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(2000)]
        public string Objective { get; set; }

        [StringLength(30)]
        public string ActivityCode { get; set; }

        [StringLength(30)]
        public string ApprovalCode { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Credits { get; set; }

        public bool? ScholarshipStatus { get; set; }

        public bool? PublishIndicator { get; set; }

        public bool? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

        public int? RefCourseCreditUnitId { get; set; }

        public int? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        public int? RefPDAudienceTypeId { get; set; }

        public int? RefPDActivityApprovedPurposeId { get; set; }

        public int? RefPDActivityCreditTypeId { get; set; }

        public int? RefPDActivityLevelId { get; set; }

        public int? RefPDActivityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Course Course { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDActivityEducationLevel> PDActivityEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentSession> ProfessionalDevelopmentSessions { get; set; }

        public virtual ProfessionalDevelopmentRequirement ProfessionalDevelopmentRequirement { get; set; }

        public virtual RefCourseCreditUnit RefCourseCreditUnit { get; set; }

        public virtual RefProfessionalDevelopmentFinancialSupport RefProfessionalDevelopmentFinancialSupport { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPDActivityApprovedPurpose RefPDActivityApprovedPurpose { get; set; }

        public virtual RefPDActivityCreditType RefPDActivityCreditType { get; set; }

        public virtual RefPDActivityLevel RefPDActivityLevel { get; set; }

        public virtual RefPDActivityType RefPDActivityType { get; set; }

        public virtual RefPDAudienceType RefPDAudienceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
    }
}
